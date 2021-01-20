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
    public partial class UserControl1 : UserControl
    {
        ADO d = new ADO();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        public void CountSUMmonth()
        {
            string theDate = dateTimePicker1.Value.ToString("MM");
            d.cmd = new SqlCommand("select SUM(cast(restaurent as decimal(10,2))) from Total_Sorite_Mois where month(Date_sortie) = MONTH(getdate())");
            d.cmd.Connection = d.con;
            LBL_total_restaurent.Text = d.cmd.ExecuteScalar().ToString();
            d.cmd = new SqlCommand("select SUM(cast(hotel as decimal(10,2))) from Total_Sorite_Mois where month(Date_sortie) = MONTH(getdate())");
            d.cmd.Connection = d.con;
            LBL_total_hotel.Text = d.cmd.ExecuteScalar().ToString();
            d.cmd = new SqlCommand("select SUM(cast(linge as decimal(10,2))) from Total_Sorite_Mois where month(Date_sortie) = MONTH(getdate())");
            d.cmd.Connection = d.con;
            LBL_total_linge.Text = d.cmd.ExecuteScalar().ToString();
            d.cmd = new SqlCommand("select SUM(cast(fournisseur as decimal(10,2))) from Total_Sorite_Mois where month(Date_sortie) = MONTH(getdate())");
            d.cmd.Connection = d.con;
            LBL_total_fournisseur.Text = d.cmd.ExecuteScalar().ToString();
            d.cmd = new SqlCommand("select SUM(cast(cuisine as decimal(10,2))) from Total_Sorite_Mois where month(Date_sortie) = MONTH(getdate())");
            d.cmd.Connection = d.con;
            LBL_total_cuisine.Text = d.cmd.ExecuteScalar().ToString();
            d.cmd = new SqlCommand("select SUM(cast(Total_jour as decimal(10,2))) from Total_Sorite_Mois where month(Date_sortie) = MONTH(getdate())");
            d.cmd.Connection = d.con;
            LBL_total_soustotal.Text = d.cmd.ExecuteScalar().ToString();


        }

        //Load DATA    --   Afficher List de danner  -- show database 
        public void RemplirGV()
        {
            d.dt.Clear();
            d.cmd.CommandText = "select * from Total_Sorite_Mois";
            //d.dt.Clear();
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            DGV_TotalMois.DataSource = d.dt;
            d.dr.Close();
            CountSUMmonth();

            DGV_TotalMois.Columns[0].Width = 150;
            DGV_TotalMois.Columns[1].Width = 102;
            DGV_TotalMois.Columns[2].Width = 102;
            DGV_TotalMois.Columns[3].Width = 100;
            DGV_TotalMois.Columns[4].Width = 100;
            DGV_TotalMois.Columns[5].Width = 104;
        }
        private void BTN_AddExpense_Click(object sender, EventArgs e)
        {
            d.cmd.CommandText = "update Total_Sorite_Mois set Hotel ='" + TXT_hotel.Text + "',Linge='" + TXT_linge.Text + "',Fournisseur ='" + TXT_Fournisseur.Text + "' where Date_sortie =CONVERT(VARCHAR(10), getdate(), 111)";
            d.cmd.Connection = d.con;
            d.cmd.ExecuteNonQuery();
            RemplirGV();
            TXT_hotel.Text = "";
            TXT_linge.Text = "";
            TXT_Fournisseur.Text = "";

        }
        // if date now existe


        private void UserControl1_Load(object sender, EventArgs e)
        {
            d.conected();
            RemplirGV();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RemplirGV();
            CountSUMmonth();
            TXT_Fournisseur.Clear();
            TXT_hotel.Clear();
            TXT_linge.Clear();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("MM");
            d.cmd.CommandText = "select * from Total_Sorite_Mois where month(Date_sortie) = " + theDate;
            d.dt.Clear();
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            DGV_TotalMois.DataSource = d.dt;
            d.dr.Close();


            d.cmd = new SqlCommand("select SUM(restaurent) from Total_Sorite_Mois where month(Date_sortie) =" + theDate);
            // or (Date_sortie between thedate and Date_sortie = thedate)
            d.cmd.Connection = d.con;
            LBL_total_restaurent.Text = d.cmd.ExecuteScalar().ToString();
            d.cmd = new SqlCommand("select SUM(hotel) from Total_Sorite_Mois where month(Date_sortie) = " + theDate);
            d.cmd.Connection = d.con;
            LBL_total_hotel.Text = d.cmd.ExecuteScalar().ToString();
            d.cmd = new SqlCommand("select SUM(linge) from Total_Sorite_Mois where month(Date_sortie) = " + theDate);
            d.cmd.Connection = d.con;
            LBL_total_linge.Text = d.cmd.ExecuteScalar().ToString();
            d.cmd = new SqlCommand("select SUM(fournisseur) from Total_Sorite_Mois where month(Date_sortie) = " + theDate);
            d.cmd.Connection = d.con;
            LBL_total_fournisseur.Text = d.cmd.ExecuteScalar().ToString();
            d.cmd = new SqlCommand("select SUM(cuisine) from Total_Sorite_Mois where month(Date_sortie) = " + theDate);
            d.cmd.Connection = d.con;
            LBL_total_cuisine.Text = d.cmd.ExecuteScalar().ToString();
            d.cmd = new SqlCommand("select SUM(Total_jour) from Total_Sorite_Mois where month(Date_sortie) = " + theDate);
            d.cmd.Connection = d.con;
            LBL_total_soustotal.Text = d.cmd.ExecuteScalar().ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("MM");
            DialogResult result = MessageBox.Show("vous perdrez tous les enregistrements de la base de données","attention", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                d.cmd.CommandText = "delete from Total_Sorite_Mois where month(Date_sortie) =" + theDate;
                d.cmd.Connection = d.con;
                  d.cmd.ExecuteNonQuery();
            RemplirGV();
           }
        }

        private void TXT_Fournisseur_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string theDate = dateTimePicker1.Value.ToString("dd");
                d.cmd = new SqlCommand("select linge from Total_Sorite_Mois where day(Date_sortie) = " + theDate);
                d.cmd.Connection = d.con;
                TXT_linge.Text = d.cmd.ExecuteScalar().ToString();

                d.cmd = new SqlCommand("select hotel from Total_Sorite_Mois where day(Date_sortie) = " + theDate);
                d.cmd.Connection = d.con;
                TXT_hotel.Text = d.cmd.ExecuteScalar().ToString();
            }
            catch { }
        }

        private void TXT_linge_TextChanged(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("dd");
            d.cmd = new SqlCommand("select fournisseur from Total_Sorite_Mois where day(Date_sortie) = " + theDate);
            d.cmd.Connection = d.con;
            TXT_Fournisseur.Text = d.cmd.ExecuteScalar().ToString();

            d.cmd = new SqlCommand("select hotel from Total_Sorite_Mois where day(Date_sortie) = " + theDate);
            d.cmd.Connection = d.con;
            TXT_hotel.Text = d.cmd.ExecuteScalar().ToString();
        }

        private void TXT_hotel_TextChanged(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("dd");
            d.cmd = new SqlCommand("select fournisseur from Total_Sorite_Mois where day(Date_sortie) = " + theDate);
            d.cmd.Connection = d.con;
            TXT_Fournisseur.Text = d.cmd.ExecuteScalar().ToString();

            d.cmd = new SqlCommand("select linge  from Total_Sorite_Mois where day(Date_sortie) = " + theDate);
            d.cmd.Connection = d.con;
            TXT_linge.Text = d.cmd.ExecuteScalar().ToString();


        }
    }
}

