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
    public partial class Products : UserControl
    {
        public Products()
        {
            InitializeComponent();
            
            
        }
        ADO d = new ADO();
        
        //add product
        private void BTN_add_Stock_Click(object sender, EventArgs e)
        {
            try
            {


                if (TXT_nomProduit_Stock.Text == "" || TXT_prix_Stock.Text == "" || TXT_QuStock.Text == "" || TXT_QuStock.Text == "")
            {
                MessageBox.Show("merci de remplir tout les chemps");
                return;

            }
            else if(Convert.ToInt32(TXT_QuStock.Text) < Convert.ToInt32(TXT_QuMin_Stock.Text))
                {
                    MessageBox.Show("assurez-vous que la quantité sortie est supérieure à la quantité minimale");
                    return;
                }
            if (Ajouter() == true)
            {
                MessageBox.Show("ce produit est ajouter avec succes");
                RemplirDGV_ProduitStock();
            }
            else
            {
                MessageBox.Show("ce produit existe deja");

            }
            }
            catch
            {
                MessageBox.Show("Assurez-vous que toutes les valeurs sont numériques ", "Erreur", MessageBoxButtons.OK);
            }

        }
        //declaration de la method nombre if product exist
        public int nombre()
        {

            int cpt;
            d.cmd.CommandText = "select count(NomProduit) from produitSTOCK where NomProduit='" + TXT_nomProduit_Stock.Text + "'";
            d.cmd.Connection = d.con;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;

        }
        //declaration de method ajouter
        public bool Ajouter()
        {
            if (nombre() == 0)
            {
                d.cmd.CommandText = "insert into produitSTOCK values('" + TXT_nomProduit_Stock.Text + "','" + TXT_QuStock.Text + "','" + TXT_prix_Stock.Text + "','" + TXT_QuMin_Stock.Text + "','" + "OK" + "')";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            else return false;

            //paramertres
            //string Query = "insert into produitSTOCK values(@NomProduit,@QuStock,@prix_Stock,@QuMin_Stock,@Status)";
            //d.cmd.CommandText = Query;
            //d.cmd.Connection = d.con;
            ////Parameters est Valuer
            //d.cmd.Parameters.Add("@NomProduit", SqlDbType.Char, 30).Value = TXT_nomProduit_Stock.Text;
            //d.cmd.Parameters.Add("@QuStock", SqlDbType.Int).Value = TXT_QuStock.Text;
            //d.cmd.Parameters.Add("@prix_Stock", SqlDbType.Float).Value = TXT_prix_Stock.Text;
            //d.cmd.Parameters.Add("@QuMin_Stock", SqlDbType.Int).Value = TXT_QuMin_Stock.Text;
            //d.cmd.Parameters.Add("@Status", SqlDbType.Char, 20).Value = "OK";

            //procedure
            //SqlCommand cmd = new SqlCommand("sp_insert", d.con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("NomProduit", TXT_nomProduit_Stock.Text);
            //cmd.Parameters.AddWithValue("QuStock", TXT_QuStock.Text);
            //cmd.Parameters.AddWithValue("prix_Stock", TXT_prix_Stock.Text);
            //cmd.Parameters.AddWithValue("QuMin_Stock", TXT_QuMin_Stock.Text);
            //cmd.Parameters.AddWithValue("Status", "OK");

        }

        public void OutstockCount()
        {
            d.cmd = new SqlCommand("select COUNT(Statut) from produitSTOCK where Statut='En rupture de stock'");
            d.cmd.Connection = d.con;
            LBL_OUTOFSTOCK.Text = d.cmd.ExecuteScalar().ToString(); // assign to your label
        }
        private void Products_Load(object sender, EventArgs e)
        {
            d.conected();
            OutstockCount();



        }
        //clear DGV
        
        //afficher dans le DATAGRIDVIEW
        public void RemplirDGV_ProduitStock()
        {
            
            if(d.dt.Rows != null )
            {
                d.dt.Clear();
            }
            //afficher dans le DATAGRIDVIEW
           //string query = select NomProduit as 'Nom Produit',Qun as 'Quantité',Qun_Min as 'Quantité Min',cast(prix as decimal(10, 2)) as 'Prix',Statut from produitSTOCK"
            
            d.cmd.CommandText = "select * from produitSTOCK";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            DGV_ProductsStock.DataSource = d.dt;
            d.dr.Close();

            DGV_ProductsStock.Columns[0].Width = 130;
            DGV_ProductsStock.Columns[1].Width = 72;
            DGV_ProductsStock.Columns[2].Width = 130;
            DGV_ProductsStock.Columns[3].Width = 68;
            DGV_ProductsStock.Columns[4].Width = 130;

        }

        //delete product from stock
        public bool delete()
        {
            if (nombre() != 0)
            {
                //d.cmd.CommandText = "delete prroduct_sortie where NomProduit='" + TXT_search.Text + "'";
                d.cmd.CommandText = "delete from produitSTOCK where NomProduit='" + TXT_search.Text + "'";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            else return false;
        }
        private void BTN_DELETE_Stock_Click(object sender, EventArgs e)
        {
            d.cmd.CommandText = "select * from produitSTOCK where NomProduit='" + TXT_search.Text + "'";
            try
            {
                //DGV_ProductsStock.Rows.Clear();
                if (TXT_search.Text == "")
                {
                    MessageBox.Show("veuillez rechercher un produit que vous souhaitez supprimer");
                    return;

                }
                if (delete() == true)
                {
                    MessageBox.Show("ce produit est supprimer avec succes");

                    RemplirDGV_ProduitStock();
                }
                else
                {
                    MessageBox.Show("ce produit n'existe pas");
                }

            }
            catch
            {
                MessageBox.Show("ne peut pas supprimer ce produit");
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = @"Data Source=DESKTOP-IKEFCK7\SQLEXPRESS;Initial Catalog=stock01;Integrated Security=True";
                SqlDataAdapter adapter = new SqlDataAdapter();
                connection.Open();
                SqlDataReader dr;
                SqlCommand command = new SqlCommand("select NomProduit from produitSTOCK where NomProduit like @NomProduit", connection);
                command.Parameters.Add(new SqlParameter("@NomProduit", "%" + TXT_search.Text + "%"));
                dr = command.ExecuteReader();
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    col.Add(dr.GetString(0));
                }
                TXT_search.AutoCompleteCustomSource = col;
                connection.Close();
            }
            catch
            {

            }
            
        }
        //edit product
        private void BTN_edit_Stock_Click(object sender, EventArgs e)
        {   try
            {

            
            OutstockCount();
            if (TXT_nomProduit_Stock.Text == "" || TXT_prix_Stock.Text == "" || TXT_QuStock.Text == "" || TXT_QuStock.Text == "")
            {
                MessageBox.Show("merci de remplir tout les chemps");
                return;

            }
            if (edit_Product() == true)
            {
                MessageBox.Show("ce produit est modifier avec succes");
                RemplirDGV_ProduitStock();
            }
            else
            {
                MessageBox.Show("ce produit n'existe pas");

            }
            }
            catch
            {
                MessageBox.Show("Assurez-vous que toutes les valeurs sont numériques", "Erreur", MessageBoxButtons.OK);
            }
        }
        public bool edit_Product()
        {
            if (nombre() != 0)
            {
                    d.cmd.CommandText = "update produitSTOCK set NomProduit ='" + TXT_nomProduit_Stock.Text + "',Qun='" + TXT_QuStock.Text+ "',prix='" + TXT_prix_Stock.Text+ "',Qun_Min='" + TXT_QuMin_Stock.Text+ "'where NomProduit='" + TXT_nomProduit_Stock.Text + "'";
                    d.cmd.Connection = d.con;
                    d.cmd.ExecuteNonQuery();
                    return true;          
            }
            else return false;
        }

        //search product by search box
        private void BTN_search_Stock_Click(object sender, EventArgs e)
        {
            d.dt.Clear();
            d.dr = null;
            d.cmd.CommandText = "select * from produitSTOCK where NomProduit='" + TXT_search.Text + "'";
            d.dr = d.cmd.ExecuteReader();

            while (d.dr.Read())
            {
                TXT_nomProduit_Stock.Text = (d.dr["NomProduit"].ToString());
                TXT_prix_Stock.Text = (d.dr["prix"].ToString());
                TXT_QuMin_Stock.Text = (d.dr["Qun_min"].ToString());
                TXT_QuStock.Text = (d.dr["Qun"].ToString());
                //DGV_ProductsStock.DataSource = d.dr;
            }
            d.dr.Close();

            d.cmd.CommandText = "select * from produitSTOCK where NomProduit='" + TXT_search.Text + "'";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            DGV_ProductsStock.DataSource = d.dt;
            d.dr.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            RemplirDGV_ProduitStock();
            TXT_nomProduit_Stock.Text = "";
            TXT_prix_Stock.Text = "";
            TXT_QuMin_Stock.Text = "";
            TXT_QuStock.Text = "";
            TXT_search.Text = "";
            OutstockCount();
        }

        private void BTN_seemore_Stock_Click(object sender, EventArgs e)
        {
            
            //afficher dans le DATAGRIDVIEW
            d.cmd.CommandText = "select * from produitSTOCK where Statut='En rupture de stock'";
            RemplirDGV();
        }
        public void RemplirDGV()
        {
            if (d.dt.Rows != null)
            {
                d.dt.Clear();
            }
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            DGV_ProductsStock.DataSource = d.dt;
            d.dr.Close();
        }

        private void LBL_OUTOFSTOCK_Click(object sender, EventArgs e)
        {

        }

        private void DGV_ProductsStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.DGV_ProductsStock.Rows[e.RowIndex];
                TXT_search.Text = row.Cells[0].Value.ToString();
                TXT_nomProduit_Stock.Text = row.Cells[0].Value.ToString();
                TXT_QuStock.Text = row.Cells[1].Value.ToString();
                TXT_QuMin_Stock.Text = row.Cells[3].Value.ToString();
                TXT_prix_Stock.Text = row.Cells[2].Value.ToString();
            }
        }

        private void DGV_ProductsStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TXT_prix_Stock_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_prix_Stock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BTN_add_Stock.PerformClick();
        }

        private void TXT_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
               BTN_search_Stock.PerformClick();
        }

        private void DGV_ProductsStock_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_ProductsStock_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.DGV_ProductsStock.Rows[e.RowIndex];
                TXT_search.Text = row.Cells[0].Value.ToString();
                TXT_nomProduit_Stock.Text = row.Cells[0].Value.ToString();
                TXT_QuStock.Text = row.Cells[1].Value.ToString();
                TXT_QuMin_Stock.Text = row.Cells[3].Value.ToString();
                TXT_prix_Stock.Text = row.Cells[2].Value.ToString();
            }
        }

        private void TXT_nomProduit_Stock_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
