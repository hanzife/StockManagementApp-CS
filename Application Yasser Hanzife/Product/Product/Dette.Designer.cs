namespace Product
{
    partial class dette
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dette));
            this.GDVTotalDette = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.LBL_total = new System.Windows.Forms.Label();
            this.LBL_numpersone = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DTP_datenow = new System.Windows.Forms.DateTimePicker();
            this.DGVdetteMonth = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_delete = new System.Windows.Forms.Button();
            this.TXT_Personne = new System.Windows.Forms.TextBox();
            this.BTN_add = new System.Windows.Forms.Button();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.TXT_Dette = new System.Windows.Forms.MaskedTextBox();
            this.txt_Numb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GDVTotalDette)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdetteMonth)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GDVTotalDette
            // 
            this.GDVTotalDette.AllowUserToAddRows = false;
            this.GDVTotalDette.AllowUserToDeleteRows = false;
            this.GDVTotalDette.BackgroundColor = System.Drawing.Color.White;
            this.GDVTotalDette.ColumnHeadersHeight = 30;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GDVTotalDette.DefaultCellStyle = dataGridViewCellStyle1;
            this.GDVTotalDette.EnableHeadersVisualStyles = false;
            this.GDVTotalDette.Location = new System.Drawing.Point(361, 245);
            this.GDVTotalDette.Name = "GDVTotalDette";
            this.GDVTotalDette.ReadOnly = true;
            this.GDVTotalDette.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GDVTotalDette.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GDVTotalDette.RowHeadersVisible = false;
            this.GDVTotalDette.Size = new System.Drawing.Size(231, 229);
            this.GDVTotalDette.TabIndex = 54;
            this.GDVTotalDette.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GDVTotalDette_CellClick);
            this.GDVTotalDette.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GDVTotalDette_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 1);
            this.panel3.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 28);
            this.label11.TabIndex = 52;
            this.label11.Text = "Dette";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.LBL_total);
            this.panel2.Controls.Add(this.LBL_numpersone);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(598, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 147);
            this.panel2.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(87)))), ((int)(((byte)(58)))));
            this.label10.Location = new System.Drawing.Point(17, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Sous Total :";
            // 
            // LBL_total
            // 
            this.LBL_total.AutoSize = true;
            this.LBL_total.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(87)))), ((int)(((byte)(58)))));
            this.LBL_total.Location = new System.Drawing.Point(17, 102);
            this.LBL_total.Name = "LBL_total";
            this.LBL_total.Size = new System.Drawing.Size(17, 15);
            this.LBL_total.TabIndex = 6;
            this.LBL_total.Text = "--";
            // 
            // LBL_numpersone
            // 
            this.LBL_numpersone.AutoSize = true;
            this.LBL_numpersone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_numpersone.Location = new System.Drawing.Point(17, 46);
            this.LBL_numpersone.Name = "LBL_numpersone";
            this.LBL_numpersone.Size = new System.Drawing.Size(17, 15);
            this.LBL_numpersone.TabIndex = 6;
            this.LBL_numpersone.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nomber De Debuteur :";
            // 
            // DTP_datenow
            // 
            this.DTP_datenow.Location = new System.Drawing.Point(641, 44);
            this.DTP_datenow.Name = "DTP_datenow";
            this.DTP_datenow.Size = new System.Drawing.Size(132, 20);
            this.DTP_datenow.TabIndex = 50;
            this.DTP_datenow.ValueChanged += new System.EventHandler(this.DTP_datenow_ValueChanged);
            // 
            // DGVdetteMonth
            // 
            this.DGVdetteMonth.AllowUserToAddRows = false;
            this.DGVdetteMonth.AllowUserToDeleteRows = false;
            this.DGVdetteMonth.BackgroundColor = System.Drawing.Color.White;
            this.DGVdetteMonth.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVdetteMonth.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVdetteMonth.EnableHeadersVisualStyles = false;
            this.DGVdetteMonth.Location = new System.Drawing.Point(13, 102);
            this.DGVdetteMonth.Name = "DGVdetteMonth";
            this.DGVdetteMonth.ReadOnly = true;
            this.DGVdetteMonth.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVdetteMonth.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVdetteMonth.RowHeadersVisible = false;
            this.DGVdetteMonth.RowTemplate.Height = 30;
            this.DGVdetteMonth.Size = new System.Drawing.Size(341, 372);
            this.DGVdetteMonth.TabIndex = 48;
            this.DGVdetteMonth.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVdetteMonth_CellClick);
            this.DGVdetteMonth.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVdetteMonth_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BTN_Edit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BTN_delete);
            this.panel1.Controls.Add(this.TXT_Personne);
            this.panel1.Controls.Add(this.BTN_add);
            this.panel1.Controls.Add(this.BTN_Clear);
            this.panel1.Controls.Add(this.TXT_Dette);
            this.panel1.Location = new System.Drawing.Point(360, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 137);
            this.panel1.TabIndex = 49;
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            this.BTN_Edit.FlatAppearance.BorderSize = 0;
            this.BTN_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Edit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BTN_Edit.ForeColor = System.Drawing.Color.White;
            this.BTN_Edit.Location = new System.Drawing.Point(162, 93);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(86, 26);
            this.BTN_Edit.TabIndex = 23;
            this.BTN_Edit.Text = "Modifier";
            this.BTN_Edit.UseVisualStyleBackColor = false;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(160, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total De Jour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(16, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Débiteur";
            // 
            // BTN_delete
            // 
            this.BTN_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            this.BTN_delete.FlatAppearance.BorderSize = 0;
            this.BTN_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_delete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BTN_delete.ForeColor = System.Drawing.Color.White;
            this.BTN_delete.Location = new System.Drawing.Point(305, 93);
            this.BTN_delete.Name = "BTN_delete";
            this.BTN_delete.Size = new System.Drawing.Size(95, 26);
            this.BTN_delete.TabIndex = 37;
            this.BTN_delete.Tag = "Rafraîchir la page";
            this.BTN_delete.Text = "Supprimer";
            this.BTN_delete.UseVisualStyleBackColor = false;
            this.BTN_delete.Click += new System.EventHandler(this.BTN_delete_Click);
            // 
            // TXT_Personne
            // 
            this.TXT_Personne.AutoCompleteCustomSource.AddRange(new string[] {
            "fvd",
            "gfd",
            "gfg",
            "ggf",
            "ggfggf"});
            this.TXT_Personne.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TXT_Personne.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TXT_Personne.Location = new System.Drawing.Point(19, 50);
            this.TXT_Personne.Name = "TXT_Personne";
            this.TXT_Personne.Size = new System.Drawing.Size(117, 20);
            this.TXT_Personne.TabIndex = 0;
            this.TXT_Personne.TextChanged += new System.EventHandler(this.TXT_Personne_TextChanged);
            this.TXT_Personne.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_Personne_KeyDown);
            // 
            // BTN_add
            // 
            this.BTN_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            this.BTN_add.FlatAppearance.BorderSize = 0;
            this.BTN_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_add.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BTN_add.ForeColor = System.Drawing.Color.White;
            this.BTN_add.Location = new System.Drawing.Point(19, 93);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(86, 26);
            this.BTN_add.TabIndex = 4;
            this.BTN_add.Text = "Ajouter";
            this.BTN_add.UseVisualStyleBackColor = false;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click_1);
            this.BTN_add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BTN_add_KeyDown);
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            this.BTN_Clear.FlatAppearance.BorderSize = 0;
            this.BTN_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Clear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BTN_Clear.ForeColor = System.Drawing.Color.White;
            this.BTN_Clear.Location = new System.Drawing.Point(305, 44);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(95, 26);
            this.BTN_Clear.TabIndex = 36;
            this.BTN_Clear.Text = "Effacer Tous";
            this.BTN_Clear.UseVisualStyleBackColor = false;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // TXT_Dette
            // 
            this.TXT_Dette.Location = new System.Drawing.Point(163, 50);
            this.TXT_Dette.Name = "TXT_Dette";
            this.TXT_Dette.Size = new System.Drawing.Size(116, 20);
            this.TXT_Dette.TabIndex = 1;
            this.TXT_Dette.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TXT_Dette_MaskInputRejected);
            this.TXT_Dette.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_Dette_KeyDown);
            // 
            // txt_Numb
            // 
            this.txt_Numb.Location = new System.Drawing.Point(254, 236);
            this.txt_Numb.Name = "txt_Numb";
            this.txt_Numb.Size = new System.Drawing.Size(100, 20);
            this.txt_Numb.TabIndex = 55;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 478);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(598, 300);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 58;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(711, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 21);
            this.button1.TabIndex = 58;
            this.button1.Text = "Chercher";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DGVdetteMonth);
            this.Controls.Add(this.txt_Numb);
            this.Controls.Add(this.GDVTotalDette);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DTP_datenow);
            this.Controls.Add(this.panel1);
            this.Name = "dette";
            this.Size = new System.Drawing.Size(791, 507);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GDVTotalDette)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdetteMonth)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GDVTotalDette;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LBL_total;
        private System.Windows.Forms.Label LBL_numpersone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTP_datenow;
        private System.Windows.Forms.DataGridView DGVdetteMonth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_delete;
        private System.Windows.Forms.TextBox TXT_Personne;
        private System.Windows.Forms.Button BTN_add;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.MaskedTextBox TXT_Dette;
        private System.Windows.Forms.TextBox txt_Numb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}
