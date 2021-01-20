using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product
{
    public partial class CalculeRevenue : UserControl
    {
        public CalculeRevenue()
        {
            InitializeComponent();
        }
        ADO d = new ADO();
        private void CalculeRevenue_Load(object sender, EventArgs e)
        {
            d.conected();
            calcule();
            RemplirGV();
            DGV_TotalRev.Columns[0].Width = 120;
            DGV_TotalRev.Columns[1].Width = 120;
            DGV_TotalRev.Columns[2].Width = 120;
            DGV_TotalRev.Columns[3].Width = 120;
        }
        public void RemplirGV()
        {
            string DateNow = dateTimePicker1.Value.ToString("yyyy");
            if (d.dt.Rows != null)
            {
                d.dt.Clear();
            }
            //afficher dans le DATAGRIDVIEW 
            //FORMAT(1, 'N');
            d.cmd.CommandText = "select DateM as 'Date Dette', FORMAT(totlaDete,'N') as 'Total Dette', FORMAT(totalJour,'N') as 'Total Entrée', FORMAT(TotalRev,'N') as 'Total Revenue'  from Revenue where year(DateM) =" + DateNow;
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            DGV_TotalRev.DataSource = d.dt;
            d.dr.Close();
        }
        public void calcule()
        {
            string DateNow = dateTimePicker1.Value.ToString("yyyy");

            d.cmd.CommandText = "select sum(totalJour) from Revenue where YEAR(dateM) =" + DateNow;
            d.cmd.Connection = d.con;
            LBL_total_dt.Text = d.cmd.ExecuteScalar().ToString();

            d.cmd.CommandText = "select sum(totlaDete) from Revenue where YEAR(dateM) =" + DateNow;
            d.cmd.Connection = d.con;
            LBL_total_Rev.Text = d.cmd.ExecuteScalar().ToString();

            d.cmd.CommandText = "select sum(TotalRev) from Revenue where YEAR(dateM) =" + DateNow;
            d.cmd.Connection = d.con;
            LBL_total_soustotal.Text = d.cmd.ExecuteScalar().ToString();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RemplirGV();
            calcule();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            string DateNow = dateTimePicker1.Value.ToString("yyyy");
            DialogResult result = MessageBox.Show("Cela effacera toutes les données sauvegardées cette année et ne pourra pas être annulé, confermer par ok!", "attention", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                d.cmd.CommandText = "delete from Revenue where year(DateM) =" + DateNow;
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                RemplirGV();
            }
        }
    }
}
