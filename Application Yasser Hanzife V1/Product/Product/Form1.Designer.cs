namespace Product
{
    partial class Home_FROM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_FROM));
            this.Sidebar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Dette = new System.Windows.Forms.Button();
            this.BTN_Entree_Mois = new System.Windows.Forms.Button();
            this.BTN_SortiesMois = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_Dashboard = new System.Windows.Forms.Button();
            this.BTN_Products = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.BTN_Mins = new System.Windows.Forms.Button();
            this.dette1 = new Product.dette();
            this.incomes1 = new Product.Incomes();
            this.userDash1 = new Product.UserDash();
            this.userControl11 = new Product.UserControl1();
            this.sortiesJour1 = new Product.SortiesJour();
            this.products1 = new Product.Products();
            this.calculeRevenue1 = new Product.CalculeRevenue();
            this.button2 = new System.Windows.Forms.Button();
            this.Sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.Sidebar.Controls.Add(this.button2);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.Controls.Add(this.label1);
            this.Sidebar.Controls.Add(this.BTN_Dette);
            this.Sidebar.Controls.Add(this.BTN_Entree_Mois);
            this.Sidebar.Controls.Add(this.BTN_SortiesMois);
            this.Sidebar.Controls.Add(this.button1);
            this.Sidebar.Controls.Add(this.BTN_Dashboard);
            this.Sidebar.Controls.Add(this.BTN_Products);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(187, 539);
            this.Sidebar.TabIndex = 1;
            this.Sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.Sidebar_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Entree  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sorties  :";
            // 
            // BTN_Dette
            // 
            this.BTN_Dette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.BTN_Dette.FlatAppearance.BorderSize = 0;
            this.BTN_Dette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Dette.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Dette.ForeColor = System.Drawing.Color.White;
            this.BTN_Dette.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Dette.Image")));
            this.BTN_Dette.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Dette.Location = new System.Drawing.Point(0, 358);
            this.BTN_Dette.Name = "BTN_Dette";
            this.BTN_Dette.Size = new System.Drawing.Size(187, 26);
            this.BTN_Dette.TabIndex = 2;
            this.BTN_Dette.Text = "     Endettement";
            this.BTN_Dette.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Dette.UseVisualStyleBackColor = false;
            this.BTN_Dette.Click += new System.EventHandler(this.BTN_Dette_Click);
            // 
            // BTN_Entree_Mois
            // 
            this.BTN_Entree_Mois.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.BTN_Entree_Mois.FlatAppearance.BorderSize = 0;
            this.BTN_Entree_Mois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Entree_Mois.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Entree_Mois.ForeColor = System.Drawing.Color.White;
            this.BTN_Entree_Mois.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Entree_Mois.Image")));
            this.BTN_Entree_Mois.Location = new System.Drawing.Point(0, 320);
            this.BTN_Entree_Mois.Name = "BTN_Entree_Mois";
            this.BTN_Entree_Mois.Size = new System.Drawing.Size(187, 26);
            this.BTN_Entree_Mois.TabIndex = 2;
            this.BTN_Entree_Mois.Text = "     Entrée De Mois";
            this.BTN_Entree_Mois.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Entree_Mois.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Entree_Mois.UseVisualStyleBackColor = false;
            this.BTN_Entree_Mois.Click += new System.EventHandler(this.BTN_Entree_Mois_Click);
            // 
            // BTN_SortiesMois
            // 
            this.BTN_SortiesMois.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.BTN_SortiesMois.FlatAppearance.BorderSize = 0;
            this.BTN_SortiesMois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SortiesMois.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SortiesMois.ForeColor = System.Drawing.Color.White;
            this.BTN_SortiesMois.Image = ((System.Drawing.Image)(resources.GetObject("BTN_SortiesMois.Image")));
            this.BTN_SortiesMois.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_SortiesMois.Location = new System.Drawing.Point(0, 215);
            this.BTN_SortiesMois.Name = "BTN_SortiesMois";
            this.BTN_SortiesMois.Size = new System.Drawing.Size(187, 26);
            this.BTN_SortiesMois.TabIndex = 2;
            this.BTN_SortiesMois.Text = "     Sorties De Mois";
            this.BTN_SortiesMois.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_SortiesMois.UseVisualStyleBackColor = false;
            this.BTN_SortiesMois.Click += new System.EventHandler(this.BTN_SortiesMois_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "     Sorties";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_Dashboard
            // 
            this.BTN_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.BTN_Dashboard.FlatAppearance.BorderSize = 0;
            this.BTN_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Dashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Dashboard.ForeColor = System.Drawing.Color.White;
            this.BTN_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Dashboard.Image")));
            this.BTN_Dashboard.Location = new System.Drawing.Point(0, 42);
            this.BTN_Dashboard.Name = "BTN_Dashboard";
            this.BTN_Dashboard.Size = new System.Drawing.Size(187, 26);
            this.BTN_Dashboard.TabIndex = 2;
            this.BTN_Dashboard.Text = "     Dashboard";
            this.BTN_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Dashboard.UseVisualStyleBackColor = false;
            this.BTN_Dashboard.Click += new System.EventHandler(this.BTN_Dashboard_Click);
            // 
            // BTN_Products
            // 
            this.BTN_Products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.BTN_Products.FlatAppearance.BorderSize = 0;
            this.BTN_Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Products.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Products.ForeColor = System.Drawing.Color.White;
            this.BTN_Products.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Products.Image")));
            this.BTN_Products.Location = new System.Drawing.Point(0, 139);
            this.BTN_Products.Name = "BTN_Products";
            this.BTN_Products.Size = new System.Drawing.Size(187, 26);
            this.BTN_Products.TabIndex = 2;
            this.BTN_Products.Text = "     Produits";
            this.BTN_Products.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Products.UseVisualStyleBackColor = false;
            this.BTN_Products.Click += new System.EventHandler(this.BTN_Products_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.calculeRevenue1);
            this.panel2.Controls.Add(this.dette1);
            this.panel2.Controls.Add(this.incomes1);
            this.panel2.Controls.Add(this.userDash1);
            this.panel2.Controls.Add(this.userControl11);
            this.panel2.Controls.Add(this.sortiesJour1);
            this.panel2.Controls.Add(this.products1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(187, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 507);
            this.panel2.TabIndex = 2;
            // 
            // BTN_Close
            // 
            this.BTN_Close.FlatAppearance.BorderSize = 0;
            this.BTN_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Close.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Close.Image")));
            this.BTN_Close.Location = new System.Drawing.Point(952, 1);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(26, 25);
            this.BTN_Close.TabIndex = 3;
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // BTN_Mins
            // 
            this.BTN_Mins.FlatAppearance.BorderSize = 0;
            this.BTN_Mins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Mins.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Mins.Image")));
            this.BTN_Mins.Location = new System.Drawing.Point(920, 1);
            this.BTN_Mins.Name = "BTN_Mins";
            this.BTN_Mins.Size = new System.Drawing.Size(26, 25);
            this.BTN_Mins.TabIndex = 3;
            this.BTN_Mins.UseVisualStyleBackColor = true;
            this.BTN_Mins.Click += new System.EventHandler(this.BTN_Mins_Click);
            this.BTN_Mins.MouseHover += new System.EventHandler(this.BTN_Mins_MouseHover);
            // 
            // dette1
            // 
            this.dette1.Location = new System.Drawing.Point(0, 0);
            this.dette1.Name = "dette1";
            this.dette1.Size = new System.Drawing.Size(791, 507);
            this.dette1.TabIndex = 5;
            this.dette1.Load += new System.EventHandler(this.dette1_Load);
            // 
            // incomes1
            // 
            this.incomes1.Location = new System.Drawing.Point(0, 0);
            this.incomes1.Name = "incomes1";
            this.incomes1.Size = new System.Drawing.Size(791, 507);
            this.incomes1.TabIndex = 4;
            // 
            // userDash1
            // 
            this.userDash1.Location = new System.Drawing.Point(0, 0);
            this.userDash1.Name = "userDash1";
            this.userDash1.Size = new System.Drawing.Size(791, 507);
            this.userDash1.TabIndex = 3;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(0, -12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(791, 507);
            this.userControl11.TabIndex = 2;
            // 
            // sortiesJour1
            // 
            this.sortiesJour1.Location = new System.Drawing.Point(0, -12);
            this.sortiesJour1.Name = "sortiesJour1";
            this.sortiesJour1.Size = new System.Drawing.Size(791, 507);
            this.sortiesJour1.TabIndex = 1;
            // 
            // products1
            // 
            this.products1.Location = new System.Drawing.Point(0, -12);
            this.products1.Name = "products1";
            this.products1.Size = new System.Drawing.Size(791, 507);
            this.products1.TabIndex = 0;
            // 
            // calculeRevenue1
            // 
            this.calculeRevenue1.Location = new System.Drawing.Point(-3, 0);
            this.calculeRevenue1.Name = "calculeRevenue1";
            this.calculeRevenue1.Size = new System.Drawing.Size(791, 507);
            this.calculeRevenue1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(0, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "      Le Revenue   ";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Home_FROM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 539);
            this.Controls.Add(this.BTN_Mins);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home_FROM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_FROM_Load);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Button BTN_Products;
        private System.Windows.Forms.Button BTN_Entree_Mois;
        private System.Windows.Forms.Button BTN_SortiesMois;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Dashboard;
        private System.Windows.Forms.Panel panel2;
        private UserControl1 userControl11;
        private SortiesJour sortiesJour1;
        private Products products1;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.Button BTN_Mins;
        private UserDash userDash1;
        private System.Windows.Forms.Button BTN_Dette;
        private Incomes incomes1;
        private dette dette1;
        private System.Windows.Forms.Button button2;
        private CalculeRevenue calculeRevenue1;
    }
}

