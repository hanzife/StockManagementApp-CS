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
    public partial class SortiesJour : UserControl
    {
        public SortiesJour()
        {
            InitializeComponent();

           

        }
        ADO d = new ADO();
        Products Product = new Products();
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlConnection connection = new SqlConnection();
            //    connection.ConnectionString = @"Data Source=DESKTOP-IKEFCK7\SQLEXPRESS;Initial Catalog=stock01;Integrated Security=True";
            //    SqlDataAdapter adapter = new SqlDataAdapter();
            //    connection.Open();
            //    SqlDataReader dr;
            //    SqlCommand command = new SqlCommand("select NomProduit from prroduct_sortie where NomProduit like @NomProduit", connection);
            //    command.Parameters.Add(new SqlParameter("@NomProduit", "%" + TXT_NomProduit_Sorties.Text + "%"));
            //    dr = command.ExecuteReader();
            //    AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            //    while (dr.Read())
            //    {
            //        col.Add(dr.GetString(0));
            //    }
            //    TXT_NomProduit_Sorties.AutoCompleteCustomSource = col;
            //    connection.Close();
            //}
            //catch { }
        }
        private void BTN_Withdraw_Click(object sender, EventArgs e)
        {
          try
            {
                d.cmd.CommandText = "insert into prroduct_sortie(NomProduit, Date_Sortie, Quantite_Sortie, DestinationP) values('" + TXT_NomProduit_Sorties.Text + "',CONVERT(VARCHAR(10), getdate(), 111),'" + TXT_Qu_Sorties.Text + "','" + CMB_distination.SelectedItem.ToString() + "')";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                RemplirDGV_SortiesJour();
                
            }
            catch
            {
                 MessageBox.Show("s'il vous plaît assurez-vous que le produit est disponible dans la liste,si le produit existe, assurez-vous que la valeur est un numérique", "Message");
            }
            // Product.OutstockCount();
            //string Query = "insert into prroduct_sortie(NomProduit, Date_Sortie, Quantite_Sortie, DestinationP)" +
            //         " values(@NomProduit,CONVERT(VARCHAR(10), getdate(), 111),@Quantite_Sortie,@DestinationP)";
            //d.cmd.CommandText = Query;
            //d.cmd.Connection = d.con;
            ////Parameters est Valuer
            //d.cmd.Parameters.Add("@NomProduit", SqlDbType.Char, 30).Value = TXT_NomProduit_Sorties.Text;
            //d.cmd.Parameters.Add("@Quantite_Sortie", SqlDbType.Int).Value = TXT_Qu_Sorties.Text;
            //d.cmd.Parameters.Add("@DestinationP", SqlDbType.Char, 20).Value = CMB_distination.SelectedItem.ToString();



        }
        public void RemplirDGV_SortiesJour()
        {

            if (d.dt.Rows != null)
            {
                d.dt.Clear();
            }
            //afficher dans le DATAGRIDVIEW
            d.cmd.CommandText = "select Date_Sortie as DATE_SORTIE, NomProduit as NOM_ARTICLE, Quantite_Sortie as QU_SORTIE ,DestinationP as DESTINATION,cast(TotalPrix as decimal(10, 2)) as TOTAL  from prroduct_sortie where Date_Sortie= CONVERT(VARCHAR(10), getdate(), 111)"; 
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            DGV_SortiesJour.DataSource = d.dt;
            d.dr.Close();

            DGV_SortiesJour.Columns[0].Width = 120;
            DGV_SortiesJour.Columns[1].Width = 124;
            DGV_SortiesJour.Columns[2].Width = 70;
            DGV_SortiesJour.Columns[3].Width = 130;
            DGV_SortiesJour.Columns[4].Width = 95;
        }

        private void SortiesJour_Load(object sender, EventArgs e)
        {
            d.conected();
            RemplirDGV_SortiesJour();
            getdateJOURsortie();
            
            comboBox1.SelectedIndex = 0;
        }
       
    
        
        public void RemplirGV()
        {
            d.dt.Clear();
            d.cmd.Connection = d.con;
                d.dr = d.cmd.ExecuteReader();
                d.dt.Load(d.dr);
                DGV_SortiesJour.DataSource = d.dt;
                d.dr.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dat = dateTimePicker1.Value.ToString("MM");
            string datd = dateTimePicker1.Value.ToString("dd");
            if (comboBox1.SelectedIndex == 0)
            {
                d.cmd.CommandText = "select Date_Sortie as DATE_SORTIE, NomProduit as NOM_ARTICLE, Quantite_Sortie as QU_SORTIE ,DestinationP as DESTINATION,TotalPrix as TOTAL  from prroduct_sortie where  month(Date_Sortie)=" + dat + "and day(Date_Sortie) =" + datd; 
                RemplirGV();
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                d.cmd.CommandText = "select Date_Sortie as DATE_SORTIE, NomProduit as NOM_ARTICLE, Quantite_Sortie as QU_SORTIE ,DestinationP as DESTINATION,TotalPrix as TOTAL  from prroduct_sortie where DestinationP='Cuisine' and month(Date_Sortie)=" + dat + "and day(Date_Sortie) =" + datd;
                RemplirGV();
            }
            else if (comboBox1.SelectedIndex == 2)
            {

                d.cmd.CommandText = "select Date_Sortie as DATE_SORTIE, NomProduit as NOM_ARTICLE, Quantite_Sortie as QU_SORTIE ,DestinationP as DESTINATION,TotalPrix as TOTAL  from prroduct_sortie where DestinationP= 'Restaurent' and month(Date_Sortie)=" + dat + "and day(Date_Sortie) =" + datd;
                RemplirGV();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            getdateJOURsortie();
        }
        public void getdateJOURsortie()
        {
            string dat = dateTimePicker1.Value.ToString("MM");
            string datd = dateTimePicker1.Value.ToString("dd");
            d.cmd.CommandText = " select Date_Sortie as DATE_SORTIE, NomProduit as NOM_ARTICLE, Quantite_Sortie as QU_SORTIE ,DestinationP as DESTINATION,TotalPrix as TOTAL" +
                " from prroduct_sortie where month(Date_Sortie)=" + dat + "and day(Date_Sortie) =" + datd;
            RemplirGV();
        }

        private void DGV_SortiesJour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Cela effacera toutes les données sauvegardées aujourd'hui et ne pourra pas être annulé, confermer par ok!", "attention", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                d.cmd.CommandText = "delete from prroduct_sortie where day(Date_Sortie) =day(getdate())";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                RemplirGV();
            }
        }
    }
}
