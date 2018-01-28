namespace sinemauygulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.koltuk1 = new sinemauygulama.Koltuk();
            this.SuspendLayout();
            // 
            // koltuk1
            // 
            this.koltuk1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("koltuk1.BackgroundImage")));
            this.koltuk1.Bilet = null;
            this.koltuk1.Durum = sinemauygulama.KoltukDurum.Bos;
            this.koltuk1.Location = new System.Drawing.Point(13, 25);
            this.koltuk1.Name = "koltuk1";
            this.koltuk1.Numara = 0;
            this.koltuk1.Sıra = null;
            this.koltuk1.Size = new System.Drawing.Size(50, 49);
            this.koltuk1.TabIndex = 0;
            this.koltuk1.Text = "koltuk1";
            this.koltuk1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.koltuk1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Koltuk koltuk1;
    }
}

