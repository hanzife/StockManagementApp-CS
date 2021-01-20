using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Runtime.InteropServices;


namespace Product
{
    public partial class Home_FROM : Form
    {
        public Home_FROM()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            


        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        ADO d = new ADO();
        private void BTN_Products_Click(object sender, EventArgs e)
        {
            products1.RemplirDGV_ProduitStock();
            //SidePanel.Height = BTN_Products.Height; SidePanel.Top = BTN_Products.Top;
            products1.BringToFront();
            //button color
            BTN_Products.BackColor = ColorTranslator.FromHtml("#1AAAA0");
            //change others
            button1.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_SortiesMois.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Entree_Mois.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Dette.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Dashboard.BackColor = ColorTranslator.FromHtml("#2C363B");
            button2.BackColor = ColorTranslator.FromHtml("#2C363B");

        }
        UserControl1 U1 = new UserControl1();
        
        private void button1_Click(object sender, EventArgs e)
        {
            //SidePanel.Height = button1.Height; SidePanel.Top = button1.Top;
            sortiesJour1.BringToFront();
            sortiesJour1.getdateJOURsortie();
            //button color
            BTN_Products.BackColor = ColorTranslator.FromHtml("#2C363B");
            button1.BackColor = ColorTranslator.FromHtml("#1AAAA0");
            BTN_SortiesMois.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Entree_Mois.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Dette.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Dashboard.BackColor = ColorTranslator.FromHtml("#2C363B");
            button2.BackColor = ColorTranslator.FromHtml("#2C363B");


        }

        private void BTN_SortiesMois_Click(object sender, EventArgs e)
        {
            //SidePanel.Height = BTN_SortiesMois.Height; SidePanel.Top = BTN_SortiesMois.Top;
            userControl11.BringToFront();
            //button color
            BTN_SortiesMois.BackColor = ColorTranslator.FromHtml("#1AAAA0");
            button1.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Products.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Entree_Mois.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Dette.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Dashboard.BackColor = ColorTranslator.FromHtml("#2C363B");
            button2.BackColor = ColorTranslator.FromHtml("#2C363B");
        }

        private void BTN_Dashboard_Click(object sender, EventArgs e)
        {
            userDash1.BringToFront();
            userDash1.dash();
            userDash1.rempliroutst();
            BTN_Dashboard.BackColor = ColorTranslator.FromHtml("#1AAAA0");
            button1.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Products.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Entree_Mois.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Dette.BackColor = ColorTranslator.FromHtml("#2C363B");
            button2.BackColor = ColorTranslator.FromHtml("#2C363B");

        }
        //Close App
        private void BTN_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous quitter ?", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                d.disconected();
                this.Close();

            }
        }
        //Home for Load
        private void Home_FROM_Load(object sender, EventArgs e)
        {
            d.conected();
            userDash1.BringToFront();
            BTN_Dashboard.BackColor = ColorTranslator.FromHtml("#1AAAA0");
            userDash1.dash();


        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
        //Minimise Page
        private void BTN_Mins_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void BTN_Entree_Mois_Click(object sender, EventArgs e)
        {
            incomes1.BringToFront();
            incomes1.RemplirDGV_IncomeMonth();
            //color
            BTN_Entree_Mois.BackColor = ColorTranslator.FromHtml("#1AAAA0");
            //change others
            BTN_SortiesMois.BackColor = ColorTranslator.FromHtml("#2C363B");
            button1.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Products.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Dette.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Dashboard.BackColor = ColorTranslator.FromHtml("#2C363B");
            button2.BackColor = ColorTranslator.FromHtml("#2C363B");


        }
        //debit ucontrol = new debit(); 
        private void BTN_Dette_Click(object sender, EventArgs e)
        {
            dette1.BringToFront();
            dette1.RemplirDGV();
            //dette1.RemplirDGV_Total();
            //color 
            BTN_Dette.BackColor = ColorTranslator.FromHtml("#1AAAA0");
            //others
            BTN_SortiesMois.BackColor = ColorTranslator.FromHtml("#2C363B");
            button1.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Products.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Entree_Mois.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Dashboard.BackColor = ColorTranslator.FromHtml("#2C363B");
            button2.BackColor = ColorTranslator.FromHtml("#2C363B");


        }

        private void dette1_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Mins_MouseHover(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculeRevenue1.BringToFront();
            //color  
            button2.BackColor = ColorTranslator.FromHtml("#1AAAA0");
            //others
            BTN_SortiesMois.BackColor = ColorTranslator.FromHtml("#2C363B");
            button1.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Products.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Entree_Mois.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Dashboard.BackColor = ColorTranslator.FromHtml("#2C363B");
            BTN_Dette.BackColor = ColorTranslator.FromHtml("#2C363B");
        }
    }
}
