namespace ApiSample
{
    partial class Form1
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
            this.listBoxKurzusok = new System.Windows.Forms.ListBox();
            this.panelBetelt = new System.Windows.Forms.Panel();
            this.TLeiras = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tNev = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUj = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxNyelv = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbReviews = new System.Windows.Forms.CheckBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.CbTax = new System.Windows.Forms.CheckBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnUj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelBetelt.SuspendLayout();
            this.panelUj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxKurzusok
            // 
            this.listBoxKurzusok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxKurzusok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.listBoxKurzusok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.listBoxKurzusok.FormattingEnabled = true;
            this.listBoxKurzusok.ItemHeight = 25;
            this.listBoxKurzusok.Location = new System.Drawing.Point(59, 136);
            this.listBoxKurzusok.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listBoxKurzusok.Name = "listBoxKurzusok";
            this.listBoxKurzusok.Size = new System.Drawing.Size(308, 879);
            this.listBoxKurzusok.TabIndex = 0;
            this.listBoxKurzusok.SelectedIndexChanged += new System.EventHandler(this.listBoxKurzusok_SelectedIndexChanged);
            // 
            // panelBetelt
            // 
            this.panelBetelt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBetelt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.panelBetelt.Controls.Add(this.TLeiras);
            this.panelBetelt.Controls.Add(this.label2);
            this.panelBetelt.Controls.Add(this.tNev);
            this.panelBetelt.Controls.Add(this.label1);
            this.panelBetelt.Location = new System.Drawing.Point(423, 15);
            this.panelBetelt.Margin = new System.Windows.Forms.Padding(4);
            this.panelBetelt.Name = "panelBetelt";
            this.panelBetelt.Size = new System.Drawing.Size(336, 990);
            this.panelBetelt.TabIndex = 1;
            // 
            // TLeiras
            // 
            this.TLeiras.AutoSize = true;
            this.TLeiras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TLeiras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.TLeiras.Location = new System.Drawing.Point(76, 218);
            this.TLeiras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TLeiras.MaximumSize = new System.Drawing.Size(267, 0);
            this.TLeiras.Name = "TLeiras";
            this.TLeiras.Size = new System.Drawing.Size(0, 31);
            this.TLeiras.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(40, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Leírás";
            // 
            // tNev
            // 
            this.tNev.AutoSize = true;
            this.tNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tNev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.tNev.Location = new System.Drawing.Point(76, 86);
            this.tNev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tNev.Name = "tNev";
            this.tNev.Size = new System.Drawing.Size(0, 36);
            this.tNev.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kurzus neve";
            // 
            // panelUj
            // 
            this.panelUj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelUj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.panelUj.Controls.Add(this.label9);
            this.panelUj.Controls.Add(this.dateTimePicker1);
            this.panelUj.Controls.Add(this.label3);
            this.panelUj.Controls.Add(this.comboBoxNyelv);
            this.panelUj.Controls.Add(this.label8);
            this.panelUj.Controls.Add(this.label7);
            this.panelUj.Controls.Add(this.label6);
            this.panelUj.Controls.Add(this.label5);
            this.panelUj.Controls.Add(this.label4);
            this.panelUj.Controls.Add(this.CbReviews);
            this.panelUj.Controls.Add(this.numQuantity);
            this.panelUj.Controls.Add(this.CbTax);
            this.panelUj.Controls.Add(this.txtCost);
            this.panelUj.Controls.Add(this.txtPrice);
            this.panelUj.Controls.Add(this.txtDescription);
            this.panelUj.Controls.Add(this.txtName);
            this.panelUj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.panelUj.Location = new System.Drawing.Point(905, 15);
            this.panelUj.Margin = new System.Windows.Forms.Padding(4);
            this.panelUj.Name = "panelUj";
            this.panelUj.Size = new System.Drawing.Size(597, 990);
            this.panelUj.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.label9.Location = new System.Drawing.Point(83, 489);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 37);
            this.label9.TabIndex = 15;
            this.label9.Text = "Dátum";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(227, 493);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 31);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(83, 708);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 37);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nyelv";
            // 
            // comboBoxNyelv
            // 
            this.comboBoxNyelv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxNyelv.BackColor = System.Drawing.Color.White;
            this.comboBoxNyelv.FormattingEnabled = true;
            this.comboBoxNyelv.Location = new System.Drawing.Point(227, 712);
            this.comboBoxNyelv.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxNyelv.Name = "comboBoxNyelv";
            this.comboBoxNyelv.Size = new System.Drawing.Size(252, 33);
            this.comboBoxNyelv.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.label8.Location = new System.Drawing.Point(83, 654);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 37);
            this.label8.TabIndex = 11;
            this.label8.Text = "Min. mennyiség";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.label7.Location = new System.Drawing.Point(83, 604);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 37);
            this.label7.TabIndex = 10;
            this.label7.Text = "Költség";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.label6.Location = new System.Drawing.Point(83, 546);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 37);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ár";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.label5.Location = new System.Drawing.Point(65, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Leírás";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.label4.Location = new System.Drawing.Point(65, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kurzus neve";
            // 
            // CbReviews
            // 
            this.CbReviews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CbReviews.AutoSize = true;
            this.CbReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CbReviews.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.CbReviews.Location = new System.Drawing.Point(79, 780);
            this.CbReviews.Margin = new System.Windows.Forms.Padding(4);
            this.CbReviews.Name = "CbReviews";
            this.CbReviews.Size = new System.Drawing.Size(242, 41);
            this.CbReviews.TabIndex = 6;
            this.CbReviews.Text = "Értékelések?";
            this.CbReviews.UseVisualStyleBackColor = true;
            // 
            // numQuantity
            // 
            this.numQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numQuantity.BackColor = System.Drawing.Color.White;
            this.numQuantity.Location = new System.Drawing.Point(364, 661);
            this.numQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(72, 31);
            this.numQuantity.TabIndex = 5;
            // 
            // CbTax
            // 
            this.CbTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CbTax.AutoSize = true;
            this.CbTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CbTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.CbTax.Location = new System.Drawing.Point(401, 780);
            this.CbTax.Margin = new System.Windows.Forms.Padding(4);
            this.CbTax.Name = "CbTax";
            this.CbTax.Size = new System.Drawing.Size(134, 41);
            this.CbTax.TabIndex = 4;
            this.CbTax.Text = "ÁFA?";
            this.CbTax.UseVisualStyleBackColor = true;
            // 
            // txtCost
            // 
            this.txtCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCost.BackColor = System.Drawing.Color.White;
            this.txtCost.Location = new System.Drawing.Point(227, 610);
            this.txtCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(252, 31);
            this.txtCost.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(227, 552);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(252, 31);
            this.txtPrice.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(79, 177);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.MaximumSize = new System.Drawing.Size(400, 500);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(400, 286);
            this.txtDescription.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(72, 80);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(407, 31);
            this.txtName.TabIndex = 0;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.btnInfo.Location = new System.Drawing.Point(796, 341);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(77, 144);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = ">";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnUj
            // 
            this.btnUj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.btnUj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.btnUj.Location = new System.Drawing.Point(1570, 327);
            this.btnUj.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(167, 179);
            this.btnUj.TabIndex = 5;
            this.btnUj.Text = "A kurzus cseréje";
            this.btnUj.UseVisualStyleBackColor = false;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.button1.Location = new System.Drawing.Point(59, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 111);
            this.button1.TabIndex = 6;
            this.button1.Text = "A lista frissítése";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(173)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(1974, 1419);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.panelUj);
            this.Controls.Add(this.panelBetelt);
            this.Controls.Add(this.listBoxKurzusok);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBetelt.ResumeLayout(false);
            this.panelBetelt.PerformLayout();
            this.panelUj.ResumeLayout(false);
            this.panelUj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listBoxKurzusok;
        private System.Windows.Forms.Panel panelBetelt;
        private System.Windows.Forms.Panel panelUj;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Label TLeiras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tNev;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CbReviews;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.CheckBox CbTax;
        public System.Windows.Forms.TextBox txtCost;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBoxNyelv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}