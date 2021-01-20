namespace Product
{
    partial class Incomes
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
            this.TXT_Cash = new System.Windows.Forms.MaskedTextBox();
            this.TXT_CChambre = new System.Windows.Forms.TextBox();
            this.TXT_CCarte = new System.Windows.Forms.MaskedTextBox();
            this.txt_Cheque = new System.Windows.Forms.MaskedTextBox();
            this.GDVIncomeMonth = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTP_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DTP_datenow = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LBL_total = new System.Windows.Forms.Label();
            this.LBL_cheque = new System.Windows.Forms.Label();
            this.LBL_cash = new System.Windows.Forms.Label();
            this.LBL_Cchambre = new System.Windows.Forms.Label();
            this.LBL_Ccarte = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GDVIncomeMonth)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXT_Cash
            // 
            this.TXT_Cash.Location = new System.Drawing.Point(16, 160);
            this.TXT_Cash.Name = "TXT_Cash";
            this.TXT_Cash.Size = new System.Drawing.Size(100, 20);
            this.TXT_Cash.TabIndex = 1;
            // 
            // TXT_CChambre
            // 
            this.TXT_CChambre.Location = new System.Drawing.Point(16, 41);
            this.TXT_CChambre.Name = "TXT_CChambre";
            this.TXT_CChambre.Size = new System.Drawing.Size(100, 20);
            this.TXT_CChambre.TabIndex = 0;
            // 
            // TXT_CCarte
            // 
            this.TXT_CCarte.Location = new System.Drawing.Point(16, 96);
            this.TXT_CCarte.Name = "TXT_CCarte";
            this.TXT_CCarte.Size = new System.Drawing.Size(100, 20);
            this.TXT_CCarte.TabIndex = 1;
            // 
            // txt_Cheque
            // 
            this.txt_Cheque.Location = new System.Drawing.Point(16, 217);
            this.txt_Cheque.Name = "txt_Cheque";
            this.txt_Cheque.Size = new System.Drawing.Size(100, 20);
            this.txt_Cheque.TabIndex = 1;
            // 
            // GDVIncomeMonth
            // 
            this.GDVIncomeMonth.AllowUserToAddRows = false;
            this.GDVIncomeMonth.AllowUserToDeleteRows = false;
            this.GDVIncomeMonth.BackgroundColor = System.Drawing.Color.White;
            this.GDVIncomeMonth.ColumnHeadersHeight = 30;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GDVIncomeMonth.DefaultCellStyle = dataGridViewCellStyle1;
            this.GDVIncomeMonth.EnableHeadersVisualStyles = false;
            this.GDVIncomeMonth.Location = new System.Drawing.Point(190, 74);
            this.GDVIncomeMonth.Name = "GDVIncomeMonth";
            this.GDVIncomeMonth.ReadOnly = true;
            this.GDVIncomeMonth.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GDVIncomeMonth.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GDVIncomeMonth.RowHeadersVisible = false;
            this.GDVIncomeMonth.RowTemplate.Height = 30;
            this.GDVIncomeMonth.Size = new System.Drawing.Size(583, 339);
            this.GDVIncomeMonth.TabIndex = 2;
            this.GDVIncomeMonth.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GDVIncomeMonth_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BTN_add);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TXT_CChambre);
            this.panel1.Controls.Add(this.DTP_date);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TXT_CCarte);
            this.panel1.Controls.Add(this.TXT_Cash);
            this.panel1.Controls.Add(this.txt_Cheque);
            this.panel1.Location = new System.Drawing.Point(13, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 351);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BTN_add
            // 
            this.BTN_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            this.BTN_add.FlatAppearance.BorderSize = 0;
            this.BTN_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_add.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BTN_add.ForeColor = System.Drawing.Color.White;
            this.BTN_add.Location = new System.Drawing.Point(9, 312);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(154, 26);
            this.BTN_add.TabIndex = 4;
            this.BTN_add.Text = "Ajouter Paiement";
            this.BTN_add.UseVisualStyleBackColor = false;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Credit Carte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Credit Chambre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date Paiement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cheque";
            // 
            // DTP_date
            // 
            this.DTP_date.Location = new System.Drawing.Point(14, 282);
            this.DTP_date.Name = "DTP_date";
            this.DTP_date.Size = new System.Drawing.Size(132, 20);
            this.DTP_date.TabIndex = 4;
            this.DTP_date.ValueChanged += new System.EventHandler(this.DTP_datenow_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cash";
            // 
            // DTP_datenow
            // 
            this.DTP_datenow.Location = new System.Drawing.Point(641, 27);
            this.DTP_datenow.Name = "DTP_datenow";
            this.DTP_datenow.Size = new System.Drawing.Size(132, 20);
            this.DTP_datenow.TabIndex = 4;
            this.DTP_datenow.ValueChanged += new System.EventHandler(this.DTP_datenow_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.LBL_total);
            this.panel2.Controls.Add(this.LBL_cheque);
            this.panel2.Controls.Add(this.LBL_cash);
            this.panel2.Controls.Add(this.LBL_Cchambre);
            this.panel2.Controls.Add(this.LBL_Ccarte);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(190, 419);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 70);
            this.panel2.TabIndex = 21;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(87)))), ((int)(((byte)(58)))));
            this.label10.Location = new System.Drawing.Point(414, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Sous Total :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(250, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Total Cheque :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(250, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total Cash :";
            // 
            // LBL_total
            // 
            this.LBL_total.AutoSize = true;
            this.LBL_total.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(87)))), ((int)(((byte)(58)))));
            this.LBL_total.Location = new System.Drawing.Point(491, 18);
            this.LBL_total.Name = "LBL_total";
            this.LBL_total.Size = new System.Drawing.Size(17, 15);
            this.LBL_total.TabIndex = 6;
            this.LBL_total.Text = "--";
            // 
            // LBL_cheque
            // 
            this.LBL_cheque.AutoSize = true;
            this.LBL_cheque.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_cheque.Location = new System.Drawing.Point(341, 47);
            this.LBL_cheque.Name = "LBL_cheque";
            this.LBL_cheque.Size = new System.Drawing.Size(17, 15);
            this.LBL_cheque.TabIndex = 6;
            this.LBL_cheque.Text = "--";
            // 
            // LBL_cash
            // 
            this.LBL_cash.AutoSize = true;
            this.LBL_cash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_cash.Location = new System.Drawing.Point(324, 18);
            this.LBL_cash.Name = "LBL_cash";
            this.LBL_cash.Size = new System.Drawing.Size(17, 15);
            this.LBL_cash.TabIndex = 6;
            this.LBL_cash.Text = "--";
            // 
            // LBL_Cchambre
            // 
            this.LBL_Cchambre.AutoSize = true;
            this.LBL_Cchambre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Cchambre.Location = new System.Drawing.Point(153, 18);
            this.LBL_Cchambre.Name = "LBL_Cchambre";
            this.LBL_Cchambre.Size = new System.Drawing.Size(17, 15);
            this.LBL_Cchambre.TabIndex = 6;
            this.LBL_Cchambre.Text = "--";
            // 
            // LBL_Ccarte
            // 
            this.LBL_Ccarte.AutoSize = true;
            this.LBL_Ccarte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Ccarte.Location = new System.Drawing.Point(133, 47);
            this.LBL_Ccarte.Name = "LBL_Ccarte";
            this.LBL_Ccarte.Size = new System.Drawing.Size(17, 15);
            this.LBL_Ccarte.TabIndex = 6;
            this.LBL_Ccarte.Text = "--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Credit Carte :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Credit Chambre :";
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            this.BTN_Clear.FlatAppearance.BorderSize = 0;
            this.BTN_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Clear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BTN_Clear.ForeColor = System.Drawing.Color.White;
            this.BTN_Clear.Location = new System.Drawing.Point(13, 463);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(95, 26);
            this.BTN_Clear.TabIndex = 22;
            this.BTN_Clear.Text = "Effacer Tous";
            this.BTN_Clear.UseVisualStyleBackColor = false;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(13, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 26);
            this.button2.TabIndex = 29;
            this.button2.Tag = "Rafraîchir la page";
            this.button2.Text = "Modifer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 1);
            this.panel3.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 28);
            this.label11.TabIndex = 30;
            this.label11.Text = "Entrée Mois";
            // 
            // Incomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.DTP_datenow);
            this.Controls.Add(this.GDVIncomeMonth);
            this.Controls.Add(this.panel1);
            this.Name = "Incomes";
            this.Size = new System.Drawing.Size(791, 507);
            this.Load += new System.EventHandler(this.Incomes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GDVIncomeMonth)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox TXT_Cash;
        private System.Windows.Forms.TextBox TXT_CChambre;
        private System.Windows.Forms.MaskedTextBox TXT_CCarte;
        private System.Windows.Forms.MaskedTextBox txt_Cheque;
        private System.Windows.Forms.DataGridView GDVIncomeMonth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_add;
        private System.Windows.Forms.DateTimePicker DTP_datenow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LBL_total;
        private System.Windows.Forms.Label LBL_cheque;
        private System.Windows.Forms.Label LBL_cash;
        private System.Windows.Forms.Label LBL_Cchambre;
        private System.Windows.Forms.Label LBL_Ccarte;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DTP_date;
        private System.Windows.Forms.Label label5;
    }
}
