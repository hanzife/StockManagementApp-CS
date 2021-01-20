namespace Product
{
    partial class UserControl1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_AddExpense = new System.Windows.Forms.Button();
            this.TXT_linge = new System.Windows.Forms.TextBox();
            this.TXT_hotel = new System.Windows.Forms.TextBox();
            this.TXT_Fournisseur = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBL_total_soustotal = new System.Windows.Forms.Label();
            this.LBL_total_linge = new System.Windows.Forms.Label();
            this.LBL_total_cuisine = new System.Windows.Forms.Label();
            this.LBL_total_hotel = new System.Windows.Forms.Label();
            this.LBL_total_fournisseur = new System.Windows.Forms.Label();
            this.LBL_total_restaurent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DGV_TotalMois = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TotalMois)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 1);
            this.panel3.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sorties Mois";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BTN_AddExpense);
            this.panel2.Controls.Add(this.TXT_linge);
            this.panel2.Controls.Add(this.TXT_hotel);
            this.panel2.Controls.Add(this.TXT_Fournisseur);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(13, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 84);
            this.panel2.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(196, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 27);
            this.button3.TabIndex = 29;
            this.button3.Text = "Effacer";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(22, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 27);
            this.button1.TabIndex = 28;
            this.button1.Tag = "Rafraîchir la page";
            this.button1.Text = "Rafraîchir la page";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "les frais de jour";
            // 
            // BTN_AddExpense
            // 
            this.BTN_AddExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            this.BTN_AddExpense.FlatAppearance.BorderSize = 0;
            this.BTN_AddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AddExpense.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BTN_AddExpense.ForeColor = System.Drawing.Color.White;
            this.BTN_AddExpense.Location = new System.Drawing.Point(636, 50);
            this.BTN_AddExpense.Name = "BTN_AddExpense";
            this.BTN_AddExpense.Size = new System.Drawing.Size(107, 27);
            this.BTN_AddExpense.TabIndex = 26;
            this.BTN_AddExpense.Text = "Ajouter";
            this.BTN_AddExpense.UseVisualStyleBackColor = false;
            this.BTN_AddExpense.Click += new System.EventHandler(this.BTN_AddExpense_Click);
            // 
            // TXT_linge
            // 
            this.TXT_linge.Location = new System.Drawing.Point(384, 22);
            this.TXT_linge.Name = "TXT_linge";
            this.TXT_linge.Size = new System.Drawing.Size(121, 20);
            this.TXT_linge.TabIndex = 27;
            this.TXT_linge.TextChanged += new System.EventHandler(this.TXT_linge_TextChanged);
            // 
            // TXT_hotel
            // 
            this.TXT_hotel.Location = new System.Drawing.Point(622, 22);
            this.TXT_hotel.Name = "TXT_hotel";
            this.TXT_hotel.Size = new System.Drawing.Size(121, 20);
            this.TXT_hotel.TabIndex = 26;
            this.TXT_hotel.TextChanged += new System.EventHandler(this.TXT_hotel_TextChanged);
            // 
            // TXT_Fournisseur
            // 
            this.TXT_Fournisseur.Location = new System.Drawing.Point(145, 22);
            this.TXT_Fournisseur.Name = "TXT_Fournisseur";
            this.TXT_Fournisseur.Size = new System.Drawing.Size(121, 20);
            this.TXT_Fournisseur.TabIndex = 0;
            this.TXT_Fournisseur.TextChanged += new System.EventHandler(this.TXT_Fournisseur_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(113)))));
            this.label7.Location = new System.Drawing.Point(301, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Linge";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(113)))));
            this.label8.Location = new System.Drawing.Point(18, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Fournisseur";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(113)))));
            this.label9.Location = new System.Drawing.Point(540, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Hotel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LBL_total_soustotal);
            this.panel1.Controls.Add(this.LBL_total_linge);
            this.panel1.Controls.Add(this.LBL_total_cuisine);
            this.panel1.Controls.Add(this.LBL_total_hotel);
            this.panel1.Controls.Add(this.LBL_total_fournisseur);
            this.panel1.Controls.Add(this.LBL_total_restaurent);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(13, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 78);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(228, 12);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(101, 17);
            this.lbl2.TabIndex = 25;
            this.lbl2.Text = "FOURNISSEUR :";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.lbl1.Location = new System.Drawing.Point(486, 45);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(89, 17);
            this.lbl1.TabIndex = 25;
            this.lbl1.Text = "SOUS-TOTAL :";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(228, 45);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(51, 17);
            this.lbl3.TabIndex = 25;
            this.lbl3.Text = "LINGE :";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(486, 12);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(54, 17);
            this.lbl.TabIndex = 25;
            this.lbl.Text = "HOTEL :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "RESTAURENT :";
            // 
            // LBL_total_soustotal
            // 
            this.LBL_total_soustotal.AutoSize = true;
            this.LBL_total_soustotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_total_soustotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.LBL_total_soustotal.Location = new System.Drawing.Point(631, 45);
            this.LBL_total_soustotal.Name = "LBL_total_soustotal";
            this.LBL_total_soustotal.Size = new System.Drawing.Size(18, 17);
            this.LBL_total_soustotal.TabIndex = 25;
            this.LBL_total_soustotal.Text = "--";
            // 
            // LBL_total_linge
            // 
            this.LBL_total_linge.AutoSize = true;
            this.LBL_total_linge.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_total_linge.Location = new System.Drawing.Point(378, 45);
            this.LBL_total_linge.Name = "LBL_total_linge";
            this.LBL_total_linge.Size = new System.Drawing.Size(18, 17);
            this.LBL_total_linge.TabIndex = 25;
            this.LBL_total_linge.Text = "--";
            // 
            // LBL_total_cuisine
            // 
            this.LBL_total_cuisine.AutoSize = true;
            this.LBL_total_cuisine.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_total_cuisine.Location = new System.Drawing.Point(119, 45);
            this.LBL_total_cuisine.Name = "LBL_total_cuisine";
            this.LBL_total_cuisine.Size = new System.Drawing.Size(18, 17);
            this.LBL_total_cuisine.TabIndex = 25;
            this.LBL_total_cuisine.Text = "--";
            this.LBL_total_cuisine.Click += new System.EventHandler(this.label13_Click);
            // 
            // LBL_total_hotel
            // 
            this.LBL_total_hotel.AutoSize = true;
            this.LBL_total_hotel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_total_hotel.Location = new System.Drawing.Point(630, 12);
            this.LBL_total_hotel.Name = "LBL_total_hotel";
            this.LBL_total_hotel.Size = new System.Drawing.Size(18, 17);
            this.LBL_total_hotel.TabIndex = 25;
            this.LBL_total_hotel.Text = "--";
            // 
            // LBL_total_fournisseur
            // 
            this.LBL_total_fournisseur.AutoSize = true;
            this.LBL_total_fournisseur.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_total_fournisseur.Location = new System.Drawing.Point(378, 12);
            this.LBL_total_fournisseur.Name = "LBL_total_fournisseur";
            this.LBL_total_fournisseur.Size = new System.Drawing.Size(18, 17);
            this.LBL_total_fournisseur.TabIndex = 25;
            this.LBL_total_fournisseur.Text = "--";
            // 
            // LBL_total_restaurent
            // 
            this.LBL_total_restaurent.AutoSize = true;
            this.LBL_total_restaurent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_total_restaurent.Location = new System.Drawing.Point(119, 12);
            this.LBL_total_restaurent.Name = "LBL_total_restaurent";
            this.LBL_total_restaurent.Size = new System.Drawing.Size(18, 17);
            this.LBL_total_restaurent.TabIndex = 25;
            this.LBL_total_restaurent.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "CUISINE :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(649, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 20);
            this.dateTimePicker1.TabIndex = 29;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DGV_TotalMois
            // 
            this.DGV_TotalMois.AllowUserToAddRows = false;
            this.DGV_TotalMois.AllowUserToDeleteRows = false;
            this.DGV_TotalMois.BackgroundColor = System.Drawing.Color.White;
            this.DGV_TotalMois.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_TotalMois.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_TotalMois.EnableHeadersVisualStyles = false;
            this.DGV_TotalMois.Location = new System.Drawing.Point(13, 157);
            this.DGV_TotalMois.Name = "DGV_TotalMois";
            this.DGV_TotalMois.ReadOnly = true;
            this.DGV_TotalMois.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TotalMois.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_TotalMois.RowHeadersVisible = false;
            this.DGV_TotalMois.RowTemplate.Height = 30;
            this.DGV_TotalMois.Size = new System.Drawing.Size(762, 259);
            this.DGV_TotalMois.TabIndex = 30;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DGV_TotalMois);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(791, 507);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TotalMois)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTN_AddExpense;
        private System.Windows.Forms.TextBox TXT_linge;
        private System.Windows.Forms.TextBox TXT_hotel;
        private System.Windows.Forms.TextBox TXT_Fournisseur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBL_total_soustotal;
        private System.Windows.Forms.Label LBL_total_linge;
        private System.Windows.Forms.Label LBL_total_cuisine;
        private System.Windows.Forms.Label LBL_total_hotel;
        private System.Windows.Forms.Label LBL_total_fournisseur;
        private System.Windows.Forms.Label LBL_total_restaurent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView DGV_TotalMois;
    }
}
