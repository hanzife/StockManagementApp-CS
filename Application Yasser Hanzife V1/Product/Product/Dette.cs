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
    public partial class dette : UserControl
    {
       
        public dette()
        {
            InitializeComponent();
        }
        ADO d = new ADO();
        
       
        //if date now exist 
        public int nombre()
        {

            int cpt;
            d.cmd.CommandText = "select count(Date_Dette) from Dette where Date_Dette=CONVERT(VARCHAR(10), getdate(), 111)";
            d.cmd.Connection = d.con;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;

        }
        public void RemplirDGV()
        {
            if (d.dt.Rows != null)
            {
                d.dt.Clear();
            }
            string DateNow = DTP_datenow.Value.ToString("MM");
            //afficher dans le DATAGRIDVIEW
            d.cmd.CommandText = "select numb as No,date_dette as 'Date De la Dette',debiteur as Débiteur,cast(Total as decimal(10,2)) as Dette from Dette where MONTH(date_dette) = " + DateNow;
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            DGVdetteMonth.DataSource = d.dt;
            d.dr.Close();
            RemplirDGV_Total();

            //design DGVs
            DGVdetteMonth.Columns[0].Width =38;
            DGVdetteMonth.Columns[1].Width = 100;
            DGVdetteMonth.Columns[2].Width = 150;
            DGVdetteMonth.Columns[3].Width = 50;

            GDVTotalDette.Columns[0].Width = 150;
            GDVTotalDette.Columns[1].Width = 76;

        }
        public void RemplirDGV_Total()
        {
            string DateNow = DTP_datenow.Value.ToString("MM");
            //afficher dans le DATAGRIDVIEW
             d.cmd.CommandText = "select debiteur as 'Débitteur',sum(cast(Total as decimal(10,2)))as 'Sous-Total' from Dette where MONTH(date_dette) = " + DateNow + " group by debiteur ";
             d.cmd.Connection = d.con;
            
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(d.cmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            GDVTotalDette.DataSource = dtRecord;

        }

     
        private void UserControl2_Load(object sender, EventArgs e)
        {
            d.conected();
            RemplirDGV();
            sous_total();


        }

        private void BTN_add_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (TXT_Dette.Text == "" || TXT_Personne.Text == "")
            {
                MessageBox.Show("merci de remplir tous les champs", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                d.cmd.CommandText = "insert into Dette values('" + DTP_datenow.Text + "','" + TXT_Personne.Text + "','" + TXT_Dette.Text + "')";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                TXT_Dette.Text = ""; txt_Numb.Text = ""; TXT_Personne.Text = "";
                }

            }
            catch
            {
                MessageBox.Show("le dette doit être numérique", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            RemplirDGV();
            sous_total();
            
        }
        public void sous_total()
        {
            string DateNow = DTP_datenow.Value.ToString("MM");
            d.cmd = new SqlCommand("select count(debiteur) from Dette where month(date_dette) =" + DateNow);
            d.cmd.Connection = d.con;
            LBL_numpersone.Text = d.cmd.ExecuteScalar().ToString();

            d.cmd = new SqlCommand("select sum(cast(Total as decimal(10,2))) from Dette where MONTH(date_dette) = " + DateNow);
            d.cmd.Connection = d.con;
            LBL_total.Text = d.cmd.ExecuteScalar().ToString();



        }
        private void BTN_delete_Click(object sender, EventArgs e)
        {
            if(TXT_Dette.Text=="" || TXT_Personne.Text=="")
            {
                MessageBox.Show("veuillez sélectionner une date dans le tableau pour apporter des modifications", "Message Info", MessageBoxButtons.OK);
                TXT_Personne.Focus();
            }
            else
            {

                string DateNow = DTP_datenow.Value.ToString("MM");
                DialogResult result = MessageBox.Show("supprimer cette date", "attention", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    d.cmd.CommandText = "delete from dette where numb ='" + txt_Numb.Text+"'";
                    d.cmd.Connection = d.con;
                    d.cmd.ExecuteNonQuery();
                    RemplirDGV();
                    sous_total();
                    TXT_Dette.Text = ""; TXT_Personne.Text = "";
                }
            }
        }

        private void DTP_datenow_ValueChanged(object sender, EventArgs e)
        {
            RemplirDGV();
            sous_total();
        }
       
           

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            if (TXT_Personne.Text == "" || TXT_Dette.Text == ""  || txt_Numb.Text=="")
            {
                MessageBox.Show("veuillez sélectionner une date dans le tableau!", "message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                
                    d.cmd.CommandText = "update dette set debiteur ='" + TXT_Personne.Text + "',Total=" + TXT_Dette.Text + "where numb = '"+ txt_Numb.Text+"'";
                    d.cmd.Connection = d.con;
                    d.cmd.ExecuteNonQuery();
                
                RemplirDGV();
                sous_total();
                MessageBox.Show("modifié avec succès", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DGVdetteMonth_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.DGVdetteMonth.Rows[e.RowIndex];
                txt_Numb.Text= row.Cells[0].Value.ToString();
                TXT_Personne.Text = row.Cells[2].Value.ToString();
                TXT_Dette.Text = row.Cells[3].Value.ToString();
            }
        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            string DateNow = DTP_datenow.Value.ToString("MM");
            DialogResult result = MessageBox.Show("Cela effacera toutes les données sauvegardées dans ce mois et ne pourra pas être annulé, confermer par ok!", "attention", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                d.cmd.CommandText = "delete from dette where month(date_dette) =" + DateNow;
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                RemplirDGV();
                sous_total();
            }

        }

        private void TXT_Personne_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=DESKTOP-IKEFCK7\SQLEXPRESS;Initial Catalog=stock01;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            connection.Open();
            SqlDataReader dr;
            SqlCommand command = new SqlCommand("select debiteur from dette where debiteur like @nompersone",connection);
            command.Parameters.Add(new SqlParameter("@nompersone", "%" + TXT_Personne.Text + "%"));
            dr=command.ExecuteReader();
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            while(dr.Read())
            {
                col.Add(dr.GetString(0));
            }
            TXT_Personne.AutoCompleteCustomSource = col;
            connection.Close();
        }

        private void BTN_add_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void TXT_Personne_KeyDown(object sender, KeyEventArgs e)
        {
            //try
            //{
            //    if (e.KeyCode == Keys.Enter)
            //        BTN_add.PerformClick();
            //}
            //catch
            //{

            //}  
        }

        private void TXT_Dette_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BTN_add.PerformClick();
        }

        private void TXT_Dette_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void GDVTotalDette_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVdetteMonth_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GDVTotalDette_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.GDVTotalDette.Rows[e.RowIndex];
                string Debetor = row.Cells[0].Value.ToString();
                string DateNow = DTP_datenow.Value.ToString("MM");
                d.cmd.CommandText = "select numb as No,date_dette as 'Date De la Dette',debiteur as Débiteur,cast(Total as decimal(10,2)) as Dette from Dette where MONTH(date_dette) = " + DateNow + "and debiteur ='" + Debetor + "'";
                d.cmd.Connection = d.con;

                d.dr = d.cmd.ExecuteReader();
                if (d.dt.Rows != null)
                {
                    d.dt.Clear();
                }
                d.dt.Load(d.dr);
                DGVdetteMonth.DataSource = d.dt;
                d.dr.Close();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RemplirDGV();
            RemplirDGV_Total();
            TXT_Personne.Text = "";
            TXT_Dette.Text = "";
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=DESKTOP-IKEFCK7\SQLEXPRESS;Initial Catalog=stock01;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            connection.Open();
            SqlDataReader dr;
            SqlCommand command = new SqlCommand("select debiteur from dette where debiteur like @nompersone", connection);
            command.Parameters.Add(new SqlParameter("@nompersone", "%" + textBox1.Text + "%"));
            dr = command.ExecuteReader();
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                col.Add(dr.GetString(0));
            }
            textBox1.AutoCompleteCustomSource = col;
            connection.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (d.dt.Rows != null)
                {
                    d.dt.Clear();
                }
                string DateNow = DTP_datenow.Value.ToString("MM");
                //afficher dans le DATAGRIDVIEW
                d.cmd.CommandText = "select numb as No,date_dette as 'Date De la Dette',debiteur as Débiteur,cast(Total as decimal(10,2)) as Dette from Dette where MONTH(date_dette) = " + DateNow + "and  debiteur ='" + textBox1.Text + "'";
                d.cmd.Connection = d.con;
                d.dr = d.cmd.ExecuteReader();
                d.dt.Load(d.dr);
                DGVdetteMonth.DataSource = d.dt;
                d.dr.Close();


                d.cmd.CommandText = "select debiteur as 'Débitteur',sum(cast(Total as decimal(10,2)))as 'Sous-Total' from Dette where MONTH(date_dette) = " + DateNow + "and debiteur = '" + textBox1.Text + "' group by debiteur";
                d.cmd.Connection = d.con;

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(d.cmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                GDVTotalDette.DataSource = dtRecord;
            }

            catch { }


        }
    }
}

