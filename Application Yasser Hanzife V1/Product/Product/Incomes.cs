using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Product
{
    public partial class Incomes : UserControl
    {
        public Incomes()
        {
            InitializeComponent();
        }
        ADO d = new ADO();
        private void BTN_add_Click(object sender, EventArgs e)
        {
            try
            {
                string day = DTP_date.Value.ToString("yyyy-MM-dd");
                if(txt_Cheque.Text == "" && TXT_CChambre.Text == "" && TXT_CCarte.Text== "" && TXT_Cash.Text == "")
                {
                    MessageBox.Show("veuillez ajouter au moins un paiement", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (nombreDATE() == 0)
                    {
                        d.cmd.CommandText = "insert into EntresMois01(datePayment,Credit_Card, Cash, cheque, Credit_chambre) values('"+day+"','" + TXT_CCarte.Text + "','" + TXT_Cash.Text + "','" + txt_Cheque.Text + "','" + TXT_CChambre.Text + "')";
                        // d.cmd.CommandText = "update EntresMois01 set Credit_Card='" "' where datePayment =CONVERT(VARCHAR(10), getdate(), 111)";
                        d.cmd.Connection = d.con;
                        d.cmd.ExecuteNonQuery();
                    }
                    else 
                    {
                        d.cmd.CommandText = "update EntresMois01 set Credit_Card =Credit_Card+'" + TXT_CCarte.Text + "',cash=cash+'" + TXT_Cash.Text + "',cheque=cheque+'" + txt_Cheque.Text + "',Credit_chambre=Credit_chambre+'" + TXT_CChambre.Text + "' where datePayment ='"+ day+"'";
                        d.cmd.Connection = d.con;
                        d.cmd.ExecuteNonQuery();
                    }
                    RemplirDGV_IncomeMonth();
                    sous_total();
                    GDVIncomeMonth.Rows[0].Selected = false;
                    txt_Cheque.Text = "";TXT_CChambre.Text = "";TXT_CCarte.Text = "";TXT_Cash.Text = ""; DTP_date.Value = DateTime.Now;
                    MessageBox.Show("paiement ajouter avec success en date : "+DTP_date.Text, "Message Inffo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Assurez - vous que le paiement est un numéro", "Message Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int nombreDATE()
        {
            string day = DTP_date.Value.ToString("yyyy-MM-dd");

            int cpt;
            d.cmd.CommandText = "select count(datePayment) from EntresMois01 where datePayment='"+ day + "'";
            d.cmd.Connection = d.con;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }
        public void RemplirDGV_IncomeMonth()
        {
            string DateNow = DTP_datenow.Value.ToString("MM");
            if (d.dt.Rows != null)
            {
                d.dt.Clear();
            }
            //afficher dans le DATAGRIDVIEW
            d.cmd.CommandText = "select datePayment as 'Date Paiement',cast(Credit_chambre as decimal(10,2)) as 'Credit Chambre', cast(Credit_Card as decimal(10,2)) as 'Carte Crédit',cast(Cash as decimal(10,2)) as 'Cash' ,cast(Cheque as decimal(10,2)) as 'Cheque',cast(TotalJour as decimal(10,2))  as 'Total Jour'  from EntresMois01 where month(datePayment)= " + DateNow;
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            GDVIncomeMonth.DataSource = d.dt;
            d.dr.Close();

            GDVIncomeMonth.Columns[5].Width = 80;

        }
        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            string DateNow = DTP_datenow.Value.ToString("MM");
            DialogResult result = MessageBox.Show("Cela effacera toutes les données sauvegardées dans ce mois et ne pourra pas être annulé, confermer par ok!", "attention", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                d.cmd.CommandText = "delete from EntresMois01 where month(datePayment) ="+ DateNow;
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                RemplirDGV_IncomeMonth();
                sous_total();
            }

        }
        public void sous_total()
        {
            string DateNow = DTP_datenow.Value.ToString("MM");
            d.cmd = new SqlCommand("select SUM(cast(Credit_chambre as decimal(10,2))) from EntresMois01 where month(datePayment) =" + DateNow);
            d.cmd.Connection = d.con;
            LBL_Cchambre.Text = d.cmd.ExecuteScalar().ToString();

            d.cmd = new SqlCommand("select SUM(cast(Credit_Card as decimal(10,2))) from EntresMois01 where month(datePayment) =" + DateNow);
            d.cmd.Connection = d.con;
            LBL_Ccarte.Text = d.cmd.ExecuteScalar().ToString();

            d.cmd = new SqlCommand("select SUM(cast(Cash as decimal(10,2))) from EntresMois01 where month(datePayment) =" + DateNow);
            d.cmd.Connection = d.con;
            LBL_cash.Text = d.cmd.ExecuteScalar().ToString();

            d.cmd = new SqlCommand("select SUM(cast(Cheque as decimal(10,2))) from EntresMois01 where month(datePayment) =" + DateNow);
            d.cmd.Connection = d.con;
            LBL_cheque.Text = d.cmd.ExecuteScalar().ToString();

            d.cmd = new SqlCommand("select SUM(cast(TotalJour as decimal(10,2))) from EntresMois01 where month(datePayment) =" + DateNow);
            d.cmd.Connection = d.con;
            LBL_total.Text = d.cmd.ExecuteScalar().ToString();
           
    }
        private void Incomes_Load(object sender, EventArgs e)
        {
            d.conected();
            RemplirDGV_IncomeMonth();
            sous_total();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DTP_datenow_ValueChanged(object sender, EventArgs e)
        {
            RemplirDGV_IncomeMonth();
            sous_total();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void GDVIncomeMonth_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.GDVIncomeMonth.Rows[e.RowIndex];
                
                TXT_CChambre.Text = row.Cells[1].Value.ToString();
                TXT_CCarte.Text = row.Cells[2].Value.ToString();
                TXT_Cash.Text = row.Cells[3].Value.ToString();
                txt_Cheque.Text = row.Cells[4].Value.ToString();
                DTP_date.Text = row.Cells[0].Value.ToString();
                GDVIncomeMonth.CurrentCell = GDVIncomeMonth.Rows[e.RowIndex].Cells[0];
                GDVIncomeMonth.Rows[0].Selected = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string day = DTP_date.Value.ToString("yyyy-MM-dd");
            if (TXT_Cash.Text=="" || txt_Cheque.Text=="" || TXT_CChambre.Text=="" || TXT_CCarte.Text=="")
            {
                MessageBox.Show("veuillez sélectionner une date dans le tableau", "message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (nombreDATE() == 1)
                {
                    d.cmd.CommandText = "update EntresMois01 set Credit_Card ='" + TXT_CCarte.Text + "',cash='" + TXT_Cash.Text + "',cheque='" + txt_Cheque.Text + "',Credit_chambre='" + TXT_CChambre.Text + "' where datePayment ='"+ day+"'";
                    d.cmd.Connection = d.con;
                    d.cmd.ExecuteNonQuery();
                }
                RemplirDGV_IncomeMonth();
                sous_total();
                MessageBox.Show("Paiemnt en date "+ DTP_date.Text +" modifié avec succès ", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
