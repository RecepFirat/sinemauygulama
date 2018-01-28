namespace sinemauygulama
{
    partial class FilmTanimForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFilmADi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFilmTur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilmAciklama = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSeansBaslamaSaati = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSeansBitisSaati = new System.Windows.Forms.MaskedTextBox();
            this.BtnFilmKaydet = new System.Windows.Forms.Button();
            this.listSeanslar = new System.Windows.Forms.ListBox();
            this.CmbSeansSalon = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSeansSalonEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.BtnFilmKaydet);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.txtFilmAciklama);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtFilmTur);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFilmADi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 446);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Özellikleri";
            // 
            // txtFilmADi
            // 
            this.txtFilmADi.Location = new System.Drawing.Point(70, 31);
            this.txtFilmADi.Name = "txtFilmADi";
            this.txtFilmADi.Size = new System.Drawing.Size(100, 20);
            this.txtFilmADi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tür";
            // 
            // TxtFilmTur
            // 
            this.TxtFilmTur.Location = new System.Drawing.Point(70, 57);
            this.TxtFilmTur.Name = "TxtFilmTur";
            this.TxtFilmTur.Size = new System.Drawing.Size(100, 20);
            this.TxtFilmTur.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Süre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Açıklama";
            // 
            // txtFilmAciklama
            // 
            this.txtFilmAciklama.Location = new System.Drawing.Point(70, 109);
            this.txtFilmAciklama.Multiline = true;
            this.txtFilmAciklama.Name = "txtFilmAciklama";
            this.txtFilmAciklama.Size = new System.Drawing.Size(100, 100);
            this.txtFilmAciklama.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(70, 83);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmbSeansSalon);
            this.groupBox2.Controls.Add(this.BtnSeansSalonEkle);
            this.groupBox2.Controls.Add(this.listSeanslar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSeansBitisSaati);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSeansBaslamaSaati);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(293, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 443);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seans";
            // 
            // txtSeansBaslamaSaati
            // 
            this.txtSeansBaslamaSaati.Location = new System.Drawing.Point(94, 31);
            this.txtSeansBaslamaSaati.Mask = "00:00";
            this.txtSeansBaslamaSaati.Name = "txtSeansBaslamaSaati";
            this.txtSeansBaslamaSaati.Size = new System.Drawing.Size(100, 20);
            this.txtSeansBaslamaSaati.TabIndex = 0;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(463, 109);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Basşlama Saati";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bitis Saati";
            // 
            // txtSeansBitisSaati
            // 
            this.txtSeansBitisSaati.Location = new System.Drawing.Point(94, 73);
            this.txtSeansBitisSaati.Mask = "00:00";
            this.txtSeansBitisSaati.Name = "txtSeansBitisSaati";
            this.txtSeansBitisSaati.Size = new System.Drawing.Size(100, 20);
            this.txtSeansBitisSaati.TabIndex = 0;
            // 
            // BtnFilmKaydet
            // 
            this.BtnFilmKaydet.Location = new System.Drawing.Point(25, 267);
            this.BtnFilmKaydet.Name = "BtnFilmKaydet";
            this.BtnFilmKaydet.Size = new System.Drawing.Size(198, 99);
            this.BtnFilmKaydet.TabIndex = 1;
            this.BtnFilmKaydet.Text = "Olustur";
            this.BtnFilmKaydet.UseVisualStyleBackColor = true;
            // 
            // listSeanslar
            // 
            this.listSeanslar.FormattingEnabled = true;
            this.listSeanslar.Location = new System.Drawing.Point(9, 251);
            this.listSeanslar.Name = "listSeanslar";
            this.listSeanslar.Size = new System.Drawing.Size(225, 186);
            this.listSeanslar.TabIndex = 2;
            // 
            // CmbSeansSalon
            // 
            this.CmbSeansSalon.FormattingEnabled = true;
            this.CmbSeansSalon.Location = new System.Drawing.Point(94, 106);
            this.CmbSeansSalon.Name = "CmbSeansSalon";
            this.CmbSeansSalon.Size = new System.Drawing.Size(121, 21);
            this.CmbSeansSalon.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Salon";
            // 
            // BtnSeansSalonEkle
            // 
            this.BtnSeansSalonEkle.Location = new System.Drawing.Point(129, 151);
            this.BtnSeansSalonEkle.Name = "BtnSeansSalonEkle";
            this.BtnSeansSalonEkle.Size = new System.Drawing.Size(86, 27);
            this.BtnSeansSalonEkle.TabIndex = 1;
            this.BtnSeansSalonEkle.Text = "Seans Ekle";
            this.BtnSeansSalonEkle.UseVisualStyleBackColor = true;
            // 
            // FilmTanimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 476);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FilmTanimForm";
            this.Text = "FilmTanimForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFilmAciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFilmTur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilmADi;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtSeansBaslamaSaati;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtSeansBitisSaati;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnFilmKaydet;
        private System.Windows.Forms.ComboBox CmbSeansSalon;
        private System.Windows.Forms.ListBox listSeanslar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSeansSalonEkle;
    }
}