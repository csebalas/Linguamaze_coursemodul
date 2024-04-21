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
            this.tSzam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tNev = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUj = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnUj = new System.Windows.Forms.Button();
            this.panelBetelt.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxKurzusok
            // 
            this.listBoxKurzusok.FormattingEnabled = true;
            this.listBoxKurzusok.ItemHeight = 25;
            this.listBoxKurzusok.Location = new System.Drawing.Point(18, 21);
            this.listBoxKurzusok.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxKurzusok.Name = "listBoxKurzusok";
            this.listBoxKurzusok.Size = new System.Drawing.Size(336, 804);
            this.listBoxKurzusok.TabIndex = 0;
            this.listBoxKurzusok.SelectedIndexChanged += new System.EventHandler(this.listBoxKurzusok_SelectedIndexChanged);
            // 
            // panelBetelt
            // 
            this.panelBetelt.Controls.Add(this.TLeiras);
            this.panelBetelt.Controls.Add(this.label2);
            this.panelBetelt.Controls.Add(this.tSzam);
            this.panelBetelt.Controls.Add(this.label3);
            this.panelBetelt.Controls.Add(this.tNev);
            this.panelBetelt.Controls.Add(this.label1);
            this.panelBetelt.Location = new System.Drawing.Point(408, 21);
            this.panelBetelt.Name = "panelBetelt";
            this.panelBetelt.Size = new System.Drawing.Size(471, 804);
            this.panelBetelt.TabIndex = 1;
            // 
            // TLeiras
            // 
            this.TLeiras.AutoSize = true;
            this.TLeiras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TLeiras.Location = new System.Drawing.Point(64, 373);
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
            this.label2.Location = new System.Drawing.Point(42, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Leírás";
            // 
            // tSzam
            // 
            this.tSzam.AutoSize = true;
            this.tSzam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tSzam.Location = new System.Drawing.Point(75, 233);
            this.tSzam.Name = "tSzam";
            this.tSzam.Size = new System.Drawing.Size(95, 36);
            this.tSzam.TabIndex = 3;
            this.tSzam.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(42, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Csoportlétszám";
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1993, 865);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.panelUj);
            this.Controls.Add(this.panelBetelt);
            this.Controls.Add(this.listBoxKurzusok);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBetelt.ResumeLayout(false);
            this.panelBetelt.PerformLayout();
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
        private System.Windows.Forms.Label tSzam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tNev;
        private System.Windows.Forms.Label label1;
    }
}