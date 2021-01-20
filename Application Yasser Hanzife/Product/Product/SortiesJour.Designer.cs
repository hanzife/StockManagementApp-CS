namespace Product
{
    partial class SortiesJour
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CMB_distination = new System.Windows.Forms.ComboBox();
            this.BTN_Withdraw = new System.Windows.Forms.Button();
            this.TXT_NomProduit_Sorties = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_Qu_Sorties = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DGV_SortiesJour = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SortiesJour)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 1);
            this.panel3.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Sorties";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CMB_distination);
            this.panel1.Controls.Add(this.BTN_Withdraw);
            this.panel1.Controls.Add(this.TXT_NomProduit_Sorties);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TXT_Qu_Sorties);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(13, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 234);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CMB_distination
            // 
            this.CMB_distination.FormattingEnabled = true;
            this.CMB_distination.Items.AddRange(new object[] {
            "Cuisine",
            "Restaurent"});
            this.CMB_distination.Location = new System.Drawing.Point(8, 156);
            this.CMB_distination.Name = "CMB_distination";
            this.CMB_distination.Size = new System.Drawing.Size(121, 21);
            this.CMB_distination.TabIndex = 27;
            // 
            // BTN_Withdraw
            // 
            this.BTN_Withdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            this.BTN_Withdraw.FlatAppearance.BorderSize = 0;
            this.BTN_Withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Withdraw.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Withdraw.ForeColor = System.Drawing.Color.White;
            this.BTN_Withdraw.Location = new System.Drawing.Point(8, 193);
            this.BTN_Withdraw.Name = "BTN_Withdraw";
            this.BTN_Withdraw.Size = new System.Drawing.Size(107, 27);
            this.BTN_Withdraw.TabIndex = 26;
            this.BTN_Withdraw.Text = "Désister";
            this.BTN_Withdraw.UseVisualStyleBackColor = false;
            this.BTN_Withdraw.Click += new System.EventHandler(this.BTN_Withdraw_Click);
            // 
            // TXT_NomProduit_Sorties
            // 
            this.TXT_NomProduit_Sorties.AutoCompleteCustomSource.AddRange(new string[] {
            "alsa levure",
            "alsa sucre",
            "beure",
            "cafe",
            "champignons",
            "coca cola",
            "confiture",
            "couscous",
            "cream fresh",
            "danon",
            "fanta",
            "fromage",
            "fromage mixte",
            "hawai",
            "huille d\'oliver",
            "huille de table",
            "l\'eau 0.25 Litre",
            "l\'eau 0.5 Litre",
            "l\'eau 1 Litre",
            "lait",
            "levure chemique",
            "lipton",
            "mais",
            "moutarde",
            "mozzarella",
            "palpi",
            "papier serviette",
            "poms",
            "poude de cacao",
            "ris",
            "schweppes citron",
            "schweppes tonic",
            "soja",
            "spaghetti",
            "sprite",
            "sucre",
            "sucre granule",
            "tagliatelle",
            "the",
            "ton",
            "vinaigre"});
            this.TXT_NomProduit_Sorties.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TXT_NomProduit_Sorties.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TXT_NomProduit_Sorties.Location = new System.Drawing.Point(8, 40);
            this.TXT_NomProduit_Sorties.Name = "TXT_NomProduit_Sorties";
            this.TXT_NomProduit_Sorties.Size = new System.Drawing.Size(106, 20);
            this.TXT_NomProduit_Sorties.TabIndex = 0;
            this.TXT_NomProduit_Sorties.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nom Produit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(113)))));
            this.label6.Location = new System.Drawing.Point(4, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Quantité Sortie";
            // 
            // TXT_Qu_Sorties
            // 
            this.TXT_Qu_Sorties.Location = new System.Drawing.Point(8, 97);
            this.TXT_Qu_Sorties.Name = "TXT_Qu_Sorties";
            this.TXT_Qu_Sorties.Size = new System.Drawing.Size(121, 20);
            this.TXT_Qu_Sorties.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(113)))));
            this.label4.Location = new System.Drawing.Point(4, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Destination";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(718, 481);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 21);
            this.button3.TabIndex = 26;
            this.button3.Text = "Effacer";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Toutes les destinations",
            "Cuisine",
            "Restaurent"});
            this.comboBox1.Location = new System.Drawing.Point(508, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(635, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 22);
            this.dateTimePicker1.TabIndex = 29;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DGV_SortiesJour
            // 
            this.DGV_SortiesJour.AllowUserToAddRows = false;
            this.DGV_SortiesJour.AllowUserToDeleteRows = false;
            this.DGV_SortiesJour.BackgroundColor = System.Drawing.Color.White;
            this.DGV_SortiesJour.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_SortiesJour.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_SortiesJour.EnableHeadersVisualStyles = false;
            this.DGV_SortiesJour.Location = new System.Drawing.Point(233, 91);
            this.DGV_SortiesJour.Name = "DGV_SortiesJour";
            this.DGV_SortiesJour.ReadOnly = true;
            this.DGV_SortiesJour.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_SortiesJour.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_SortiesJour.RowHeadersVisible = false;
            this.DGV_SortiesJour.RowTemplate.Height = 30;
            this.DGV_SortiesJour.Size = new System.Drawing.Size(543, 386);
            this.DGV_SortiesJour.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(113)))));
            this.label3.Location = new System.Drawing.Point(326, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Rechercher Dans L\'histoire";
            // 
            // SortiesJour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DGV_SortiesJour);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Name = "SortiesJour";
            this.Size = new System.Drawing.Size(791, 507);
            this.Load += new System.EventHandler(this.SortiesJour_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SortiesJour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_Qu_Sorties;
        private System.Windows.Forms.Button BTN_Withdraw;
        private System.Windows.Forms.TextBox TXT_NomProduit_Sorties;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox CMB_distination;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView DGV_SortiesJour;
        private System.Windows.Forms.Label label3;
    }
}
