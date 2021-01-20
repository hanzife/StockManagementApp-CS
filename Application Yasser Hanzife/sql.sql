create database stock01
use stock01
--Tables
create table produitSTOCK(NomProduit char(30) primary key, Qun int, prix float, Qun_Min int, Statut char(20));
create table prroduct_sortie
( nombre int primary key IDENTITY, NomProduit char(30)foreign key references produitSTOCK, Date_Sortie date, Quantite_Sortie int, DestinationP char(20),TotalPrix float);
create table Total_Sorite_Mois (Date_sortie date primary key, cuisine float, restaurent float, Expence_fournisuer float)
alter table Total_Sorite_Mois add Total_jour float
alter table Total_Sorite_Mois add hotel float
alter table Total_Sorite_Mois add linge float
alter table Total_Sorite_Mois add fournisseur float
create table EntresMois01(num int primary key identity, datePayment date, Credit_Card float, Cash float, cheque float, Credit_chambre float, TotalJour float);
create table Dette (numb int primary key identity, date_dette date, debiteur char(30),total float)
create table Revenue (DateM date primary key, totlaDete float, totalJour float, TotalRev float)
	
-- test Q=Q-Q_min
alter trigger T_withdraw_Product
	on prroduct_sortie
    for insert
    as
    begin
	-- Qun = Qun - Qun_Sortie from inserted
		 Declare @newQuantite int set @newQuantite =  (select Qun from produitSTOCK where NomProduit in (select NomProduit from inserted))
		 Declare @qunMin int set @qunMin = (select Qun_Min from produitSTOCK where NomProduit in (select NomProduit from inserted))
		
		 if (@newQuantite >0)
		 begin
			 update produitSTOCK set Qun = 
			 (select Qun from produitSTOCK where NomProduit in (select NomProduit from inserted)) -
			 (select Quantite_Sortie from inserted where NomProduit in (select NomProduit from produitSTOCK))
			  where NomProduit in (select NomProduit from inserted)
			  
		 end
		  if((select Qun from produitSTOCK where NomProduit in (select NomProduit from inserted)) <= @qunMin )
		 begin
			update produitSTOCK set Statut = 'En rupture de stock' where NomProduit in (select NomProduit from inserted)
		 end 
		 
		  if ((select Quantite_Sortie from inserted where NomProduit in (select NomProduit from produitSTOCK))>(@newQuantite))
		 begin
		 delete prroduct_sortie where nombre in (select nombre from inserted)
		  rollback end
	  end
--calculate total day and month
alter trigger T_TotalJOUR
	on prroduct_sortie
	for insert
	as
	begin

		declare @sumday float
		set @sumday = ( select (inserted.Quantite_Sortie)*(produitSTOCK.prix) from produitSTOCK,inserted 
			where produitSTOCK.NomProduit in (select NomProduit from inserted) )
		update prroduct_sortie set TotalPrix = @sumday where nombre in (select nombre from inserted) and Date_Sortie = CONVERT(VARCHAR(10), getdate(), 111)
		if((select count(Date_sortie) from Total_Sorite_Mois where Date_sortie = CONVERT(VARCHAR(10), getdate(), 111)) = 0 )
		begin
			insert into Total_Sorite_Mois(Date_sortie) values(CONVERT(VARCHAR(10), getdate(), 111))
			
			exec P_TotalJOUR
		end
		else 
		begin
			exec P_TotalJOUR	
		end
	end
-- calculate total destination
alter procedure P_TotalJOUR
	as begin
		update Total_Sorite_Mois set cuisine=(select SUM(TotalPrix) from prroduct_sortie 
			where prroduct_sortie.DestinationP='cuisine' and prroduct_sortie.Date_Sortie = CONVERT(VARCHAR(10), getdate(), 111)) 
			 where Total_Sorite_Mois.Date_Sortie = CONVERT(VARCHAR(10), getdate(), 111)

		update Total_Sorite_Mois set restaurent=(select SUM(TotalPrix) from prroduct_sortie 
			where  prroduct_sortie.DestinationP='restaurent' and prroduct_sortie.Date_Sortie = CONVERT(VARCHAR(10), getdate(), 111))
			 where Total_Sorite_Mois.Date_Sortie = CONVERT(VARCHAR(10), getdate(), 111)

		update Total_Sorite_Mois set restaurent=0 where restaurent is null;
		update Total_Sorite_Mois set cuisine=0 where cuisine is null
	end
-- Update Status
alter trigger T_UpdateQunMIN
	on produitSTOCK
	after update
	as
	begin
		declare @QunMIN int
		set @QunMIN = (select inserted.Qun_Min from inserted,produitSTOCK where inserted.NomProduit=produitSTOCK.NomProduit )
		declare @QunMax int
		set @QunMax = (select inserted.qun from inserted,produitSTOCK where inserted.NomProduit=produitSTOCK.NomProduit)
		if(@QunMax>@QunMIN)
		begin
			update produitSTOCK set Statut='OK' where NomProduit in (select NomProduit from inserted)

			select * from produitSTOCK
		end 
		else if(@QunMax<@QunMIN)
		begin
			update produitSTOCK set Statut='En rupture de stock' where NomProduit in (select NomProduit from inserted)

			select * from produitSTOCK
		end
	end
--calculer Total les frais ajouter
alter trigger T_calculateTOTAL
	on prroduct_sortie
	for insert,update
	as
	begin
		declare @TOTALjour float
		set @TOTALjour = (select SUM((cuisine)+(restaurent)+(hotel)+(linge)+(fournisseur)) 
			from Total_Sorite_Mois where Date_sortie =CONVERT(VARCHAR(10), getdate(), 111))
		update Total_Sorite_Mois set Total_jour = @TOTALjour where Date_sortie = CONVERT(VARCHAR(10), getdate(), 111)
		 
	end
/*alter trigger T_Upcalculate
	on Total_Sorite_Mois
	for update
	as
	begin
		declare @TOTALjour float
		set @TOTALjour = (select SUM((cuisine)+(restaurent)+(hotel)+(linge)+(fournisseur)) from Total_Sorite_Mois where Date_sortie =CONVERT(VARCHAR(10), getdate(), 111))
		update Total_Sorite_Mois set Total_jour = @TOTALjour where Date_sortie = CONVERT(VARCHAR(10), getdate(), 111)
	end*/
--calculate total entre jour
alter trigger T_calculateJOUR01
	on EntresMois01
	for insert,update
	as begin
		update EntresMois01 set TotalJour = (select SUM((Credit_Card)+(Credit_chambre)+(Cash)+(cheque)) from EntresMois01  
			where datePayment =(select datePayment from inserted where inserted.num = EntresMois01.num) ) 
		where datePayment = (select datePayment from inserted where inserted.num = EntresMois01.num)
	end
/*--Not Working--
/*drop trigger T_calJOUR02
	on EntresMois01
	for update
	as begin
		update EntresMois01 set TotalJour = (select SUM((Credit_Card)+(Credit_chambre)+(Cash)+(cheque)) from EntresMois01  where datePayment = CONVERT(VARCHAR(10), getdate(), 111) ) where datePayment = CONVERT(VARCHAR(10), getdate(), 111)
	end*/

--insert into EntresMois01(datePayment,Credit_Card, Cash, cheque, Credit_chambre) values(CONVERT(VARCHAR(10), getdate(), 111),15,12,54,1) *
--test
select datePayment, sum((Credit_Card)+(Credit_chambre)+(Cash)+(cheque)) from entresmois01 group by datePayment
select date_dette as Date_Dette,debiteur as Débiteur,cast(Total as decimal(10,2)) as Total from Dette
select debiteur as 'Débitteur',sum(cast(Total as decimal(10,2)))as 'Sous-Total' from Dette where MONTH(date_dette) = MONTH(CONVERT(VARCHAR(10), getdate(), 111)) group by debiteur 
select * from produitSTOCK
select Date_sortie,SUM((cqsh)+(credit)+(Hotel)+(Linge)+(Fournisseur))as total from  group by Date_sortie
select * from Total_Sorite_Mois
insert into Total_Sorite_Mois(Date_sortie,cuisine) values(GETDATE(),'')
delete Total_Sorite_Mois
select sum(cast(TotalJour as decimal(10,2)))  from EntresMois01 where datePayment
select * from Total_Sorite_Mois*/


-------------------------------------------------------------------------
drop table Revenue
drop trigger TcalculeRevdette
drop proc PcalculeRev

--alter trigger TcalculeRev
--on EntresMois01
--for insert
--as 
--begin
--if ((select count(DateM) from Revenue where DateM = CONVERT(VARCHAR(10), getdate(), 111)) = 0 )
--begin
--insert into Revenue(DateM) values (CONVERT(VARCHAR(10), getdate(), 111))
--exec PcalculeRev
--end
--else 
--begin
--exec PcalculeRev
--end
--end
--func trigger or proc whatever
alter trigger Tcalcule
	on dette,EntresMois01
	for insert
	as
	begin
		declare @totalJour float
		declare @totlaDete float
		declare @TotalRev float
		declare @dateNow date
		set @dateNow = MONTH(CONVERT(VARCHAR(10), getdate(), 111))
		set @totlaDete = (select sum(total) from Dette where MONTH(dette.date_dette) =  @dateNow )
		set @totalJour = (select SUM(TotalJour) from EntresMois01 where MONTH(EntresMois01.datePayment) =  @dateNow)
		set @TotalRev = @totlaDete + @totalJour  
		if ((select count(Month(DateM)) from Revenue where DateM =  EOMONTH(DATEFROMPARTS(year(getdate()),month(getdate()),1))) = 0 )
		begin
			insert into Revenue(DateM) values (DATEFROMPARTS(year(getdate()),month(getdate()),1))
			update Revenue set totlaDete = @totlaDete, totalJour = @totalJour, TotalRev = @TotalRev where MONTH(DateM) =  @dateNow)
		end
		else
		begin
			update Revenue set totlaDete = @totlaDete, totalJour = @totalJour, TotalRev = @TotalRev where MONTH(DateM) =  @dateNow)
		end
	end
alter trigger TcalculeEntresMois01
	on EntresMois01
	for insert
	as
	begin
		declare @totalJour float
		declare @totlaDete float
		declare @TotalRev float
		set @totlaDete = (select sum(total) from Dette where MONTH(dette.date_dette) =  MONTH(CONVERT(VARCHAR(10), getdate(), 111)))
		set @totalJour = (select SUM(TotalJour) from EntresMois01 where MONTH(EntresMois01.datePayment) = MONTH(CONVERT(VARCHAR(10), getdate(), 111)))
		set @TotalRev = @totlaDete + @totalJour  
		if ((select count(Month(DateM)) from Revenue where DateM = EOMONTH(DATEFROMPARTS(year(getdate()),month(getdate()),1))) = 0 )
		begin
			insert into Revenue(DateM) values (DATEFROMPARTS(year(getdate()),month(getdate()),1))
			update Revenue set totlaDete = @totlaDete, totalJour = @totalJour, TotalRev = @TotalRev where MONTH(DateM) = MONTH(CONVERT(VARCHAR(10), getdate(), 111))
		end
		else
		begin
			update Revenue set totlaDete = @totlaDete, totalJour = @totalJour, TotalRev = @TotalRev where MONTH(DateM) = MONTH(CONVERT(VARCHAR(10), getdate(), 111))
		end
	end


select COUNT(CAST(Statut AS decimal(10,1))) from produitSTOCK where Statut='En rupture de stock'
	select totald from Revenue where MONTH(DateM) = MONTH(CONVERT(VARCHAR(10), getdate(), 111))
	delete Revenue
	delete dette
	select CONVERT(VARCHAR(10), getdate(), 111) as 'Date Total Revenue', totalJour,totalJour,TotalRev from Revenue where Month(DateM) = MONTH(CONVERT(VARCHAR(10), getdate(), 111))

	select * from produitSTOCK
	select NomProduit from produitSTOCK where NomProduit like @nompersone", connection);


	select sum(total) from dette where Month(date_dette) = MONTH(CONVERT(VARCHAR(10), getdate(), 111))
	select * from Revenue
	delete Revenue

--alter trigger TcalculeRevdette
--on dette
--for insert
--as 
--begin
--if ((select count(MONTH(DateM)) from Revenue where DateM = CONVERT(VARCHAR(10), getdate(), 111)) = 0 )
--begin
--insert into Revenue(DateM) values (CONVERT(VARCHAR(10), getdate(), 111))
--exec PcalculeRev
--end
--else 
--begin
--exec PcalculeRev
--end
--end
--select MONTH(CONVERT(VARCHAR(10), getdate(), 111))
--alter proc PcalculeRev
--as 
--begin
--	update Revenue set totalJour=(select SUM(TotalJour) from EntresMois01 where MONTH(EntresMois01.datePayment) = MONTH(CONVERT(VARCHAR(10), getdate(), 111))) where MONTH(DateM)= MONTH(CONVERT(VARCHAR(10), getdate(), 111))
--	update Revenue set totlaDete=(select sum(total) from Dette where MONTH(dette.date_dette) =  MONTH(CONVERT(VARCHAR(10), getdate(), 111))) where MONTH(DateM)= MONTH(CONVERT(VARCHAR(10), getdate(), 111))
--	update Revenue set TotalRev = ( select totalJour + totlaDete from Revenue where MONTH(dateM) = MONTH(CONVERT(VARCHAR(10), getdate(), 111))) where MONTH(DateM)= MONTH(CONVERT(VARCHAR(10), getdate(), 111))
--end
select * from  Revenue
delete Revenue
		
insert into EntresMois01(datePayment,Credit_Card) values(CONVERT(VARCHAR(10), getdate(), 111),75) 

select * from dette
select * from EntresMois01