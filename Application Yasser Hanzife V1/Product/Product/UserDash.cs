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
    public partial class UserDash : UserControl
    {
        public UserDash()
        {
            InitializeComponent();
           

        }     
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        ADO d = new ADO();
        public class SPanel : Panel
        {


            protected override void OnPaint(PaintEventArgs e)
            {
               
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserDash_Load(object sender, EventArgs e)
        {
           
            
            d.conected();
            dash();
            rempliroutst();

        }
        public void rempliroutst()
        {
            
            GDVoutofstock.ColumnHeadersHeight = 30;

            d.cmd.CommandText = "select NomProduit,Qun as'Quantité',Statut as 'Statut' from produitSTOCK where Statut='en rupture de stock'";
            d.cmd.Connection = d.con;

            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(d.cmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            GDVoutofstock.DataSource = dtRecord;
            GDVoutofstock.Columns[0].Width = 130;
            GDVoutofstock.Columns[1].Width = 72;
            GDVoutofstock.Columns[2].Width = 130;
        }

        public void dash()
        {
            d.cmd = new SqlCommand("select sum(cast(Total as decimal(10,2))) from Dette where MONTH(date_dette) = month(getdate())");
            d.cmd.Connection = d.con;
            LBL_dept.Text = d.cmd.ExecuteScalar().ToString();
            d.cmd = new SqlCommand("select sum(cast(TotalJour as decimal(10,2)))  from EntresMois01 where month(datePayment)=month(getdate())");
            d.cmd.Connection = d.con;
            LBL_income.Text = d.cmd.ExecuteScalar().ToString();
            d.cmd = new SqlCommand("select SUM(cast(Total_jour as decimal(10,2))) from Total_Sorite_Mois where month(Date_sortie) = month(getdate())");
            d.cmd.Connection = d.con;
            LBL_sortie.Text = d.cmd.ExecuteScalar().ToString();

            d.cmd = new SqlCommand("select COUNT('NomProduit') from produitSTOCK where Statut='En rupture de stock'");
            d.cmd.Connection = d.con;
            LBL_Outstock.Text = d.cmd.ExecuteScalar().ToString();

            d.cmd = new SqlCommand("select count(NomProduit) from prroduct_sortie where day(Date_Sortie) =DAY(getdate())");
            d.cmd.Connection = d.con;
            LBL_SortieNow.Text = d.cmd.ExecuteScalar().ToString();

            d.cmd = new SqlCommand("select SUM(cast(TotalPrix as decimal(10,2))) from prroduct_sortie where DAY(Date_Sortie) = DAY(getdate())");
            d.cmd.Connection = d.con;
            lbl_sortNow.Text = d.cmd.ExecuteScalar().ToString();

            d.cmd = new SqlCommand("select sum(cast(TotalJour as decimal(10,2)))  from EntresMois01 where day(datePayment)=day(getdate())");
            d.cmd.Connection = d.con;
            LBL_EntreeJour.Text = d.cmd.ExecuteScalar().ToString();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GDVoutofstock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
