namespace sinemauygulama
{
    partial class SalonTanimForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSalonADi = new System.Windows.Forms.TextBox();
            this.TxtSubeADi = new System.Windows.Forms.TextBox();
            this.BtnGoruntule = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmrsira = new System.Windows.Forms.NumericUpDown();
            this.nmrSutun = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrsira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSutun)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ŞUBE";
            // 
            // TxtSalonADi
            // 
            this.TxtSalonADi.Location = new System.Drawing.Point(71, 29);
            this.TxtSalonADi.Name = "TxtSalonADi";
            this.TxtSalonADi.Size = new System.Drawing.Size(100, 20);
            this.TxtSalonADi.TabIndex = 2;
            // 
            // TxtSubeADi
            // 
            this.TxtSubeADi.Location = new System.Drawing.Point(71, 61);
            this.TxtSubeADi.Name = "TxtSubeADi";
            this.TxtSubeADi.Size = new System.Drawing.Size(100, 20);
            this.TxtSubeADi.TabIndex = 2;
            // 
            // BtnGoruntule
            // 
            this.BtnGoruntule.Location = new System.Drawing.Point(96, 180);
            this.BtnGoruntule.Name = "BtnGoruntule";
            this.BtnGoruntule.Size = new System.Drawing.Size(75, 23);
            this.BtnGoruntule.TabIndex = 3;
            this.BtnGoruntule.Text = "Görünütle";
            this.BtnGoruntule.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sıra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sutun";
            // 
            // nmrsira
            // 
            this.nmrsira.Location = new System.Drawing.Point(71, 98);
            this.nmrsira.Name = "nmrsira";
            this.nmrsira.Size = new System.Drawing.Size(100, 20);
            this.nmrsira.TabIndex = 6;
            // 
            // nmrSutun
            // 
            this.nmrSutun.Location = new System.Drawing.Point(71, 132);
            this.nmrSutun.Name = "nmrSutun";
            this.nmrSutun.Size = new System.Drawing.Size(100, 20);
            this.nmrSutun.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(187, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 432);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Perde";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(96, 218);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(75, 23);
            this.BtnKaydet.TabIndex = 3;
            this.BtnKaydet.Text = "kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            // 
            // SalonTanimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 453);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nmrSutun);
            this.Controls.Add(this.nmrsira);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnGoruntule);
            this.Controls.Add(this.TxtSubeADi);
            this.Controls.Add(this.TxtSalonADi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalonTanimForm";
            this.Text = "SalonTanimForm";
            ((System.ComponentModel.ISupportInitialize)(this.nmrsira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSutun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSalonADi;
        private System.Windows.Forms.TextBox TxtSubeADi;
        private System.Windows.Forms.Button BtnGoruntule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmrsira;
        private System.Windows.Forms.NumericUpDown nmrSutun;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnKaydet;
    }
}