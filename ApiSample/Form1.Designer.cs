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
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnUj = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.CbTax = new System.Windows.Forms.CheckBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.CbReviews = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelBetelt.SuspendLayout();
            this.panelUj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxKurzusok
            // 
            this.listBoxKurzusok.FormattingEnabled = true;
            this.listBoxKurzusok.ItemHeight = 25;
            this.listBoxKurzusok.Location = new System.Drawing.Point(18, 21);
            this.listBoxKurzusok.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxKurzusok.Name = "listBoxKurzusok";
            this.listBoxKurzusok.Size = new System.Drawing.Size(336, 1429);
            this.listBoxKurzusok.TabIndex = 0;
            this.listBoxKurzusok.SelectedIndexChanged += new System.EventHandler(this.listBoxKurzusok_SelectedIndexChanged);
            // 
            // panelBetelt
            // 
            this.panelBetelt.Controls.Add(this.TLeiras);
            this.panelBetelt.Controls.Add(this.label2);
            this.panelBetelt.Controls.Add(this.tNev);
            this.panelBetelt.Controls.Add(this.label1);
            this.panelBetelt.Location = new System.Drawing.Point(408, 21);
            this.panelBetelt.Name = "panelBetelt";
            this.panelBetelt.Size = new System.Drawing.Size(471, 1442);
            this.panelBetelt.TabIndex = 1;
            // 
            // TLeiras
            // 
            this.TLeiras.AutoSize = true;
            this.TLeiras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TLeiras.Location = new System.Drawing.Point(75, 218);
            this.TLeiras.MaximumSize = new System.Drawing.Size(400, 0);
            this.TLeiras.Name = "TLeiras";
            this.TLeiras.Size = new System.Drawing.Size(95, 36);
            this.TLeiras.TabIndex = 5;
            this.TLeiras.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(40, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Leírás";
            // 
            // tNev
            // 
            this.tNev.AutoSize = true;
            this.tNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tNev.Location = new System.Drawing.Point(75, 87);
            this.tNev.Name = "tNev";
            this.tNev.Size = new System.Drawing.Size(95, 36);
            this.tNev.TabIndex = 1;
            this.tNev.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kurzus neve";
            // 
            // panelUj
            // 
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
            this.panelUj.Location = new System.Drawing.Point(1079, 21);
            this.panelUj.Name = "panelUj";
            this.panelUj.Size = new System.Drawing.Size(652, 804);
            this.panelUj.TabIndex = 2;
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnInfo.Location = new System.Drawing.Point(941, 317);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(78, 145);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = ">";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(1762, 254);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(208, 108);
            this.btnTorles.TabIndex = 4;
            this.btnTorles.Text = "Betelt kurzus eltüntetése az oldalról";
            this.btnTorles.UseVisualStyleBackColor = true;
            // 
            // btnUj
            // 
            this.btnUj.Location = new System.Drawing.Point(1762, 382);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(208, 108);
            this.btnUj.TabIndex = 5;
            this.btnUj.Text = "Új kurzus hozzáadása";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(331, 31);
            this.txtName.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(128, 156);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(436, 31);
            this.txtDescription.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(128, 516);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(331, 31);
            this.txtPrice.TabIndex = 2;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(128, 589);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(331, 31);
            this.txtCost.TabIndex = 3;
            // 
            // CbTax
            // 
            this.CbTax.AutoSize = true;
            this.CbTax.Location = new System.Drawing.Point(128, 738);
            this.CbTax.Name = "CbTax";
            this.CbTax.Size = new System.Drawing.Size(97, 29);
            this.CbTax.TabIndex = 4;
            this.CbTax.Text = "ÁFA?";
            this.CbTax.UseVisualStyleBackColor = true;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(128, 664);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 31);
            this.numQuantity.TabIndex = 5;
            // 
            // CbReviews
            // 
            this.CbReviews.AutoSize = true;
            this.CbReviews.Location = new System.Drawing.Point(377, 738);
            this.CbReviews.Name = "CbReviews";
            this.CbReviews.Size = new System.Drawing.Size(169, 29);
            this.CbReviews.TabIndex = 6;
            this.CbReviews.Text = "Értékelések?";
            this.CbReviews.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(105, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kurzus neve";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(105, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "Leírás";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(105, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 36);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ár";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(105, 550);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 36);
            this.label7.TabIndex = 10;
            this.label7.Text = "Költség";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(105, 625);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 36);
            this.label8.TabIndex = 11;
            this.label8.Text = "Minimális mennyiség";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1993, 1759);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.panelUj);
            this.Controls.Add(this.panelBetelt);
            this.Controls.Add(this.listBoxKurzusok);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBetelt.ResumeLayout(false);
            this.panelBetelt.PerformLayout();
            this.panelUj.ResumeLayout(false);
            this.panelUj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKurzusok;
        private System.Windows.Forms.Panel panelBetelt;
        private System.Windows.Forms.Panel panelUj;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Label TLeiras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tNev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CbReviews;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.CheckBox CbTax;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtPrice;
    }
}