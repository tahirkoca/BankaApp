namespace BankaApp
{
    partial class BankaMusterileriGoruntule
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
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnBankaListele = new System.Windows.Forms.Button();
            this.btnMusteriEkleDon = new System.Windows.Forms.Button();
            this.btnAnaSayfaDon = new System.Windows.Forms.Button();
            this.lstMusteriler = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(580, 338);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(154, 88);
            this.btnKapat.TabIndex = 9;
            this.btnKapat.Text = "Programı Sonlandır";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnBankaListele
            // 
            this.btnBankaListele.Location = new System.Drawing.Point(420, 338);
            this.btnBankaListele.Name = "btnBankaListele";
            this.btnBankaListele.Size = new System.Drawing.Size(154, 88);
            this.btnBankaListele.TabIndex = 8;
            this.btnBankaListele.Text = "Banka Listeleme Sayfasına Dön";
            this.btnBankaListele.UseVisualStyleBackColor = true;
            this.btnBankaListele.Click += new System.EventHandler(this.btnBankaListele_Click);
            // 
            // btnMusteriEkleDon
            // 
            this.btnMusteriEkleDon.Location = new System.Drawing.Point(260, 338);
            this.btnMusteriEkleDon.Name = "btnMusteriEkleDon";
            this.btnMusteriEkleDon.Size = new System.Drawing.Size(154, 88);
            this.btnMusteriEkleDon.TabIndex = 7;
            this.btnMusteriEkleDon.Text = "Banka Müşteri Ekle";
            this.btnMusteriEkleDon.UseVisualStyleBackColor = true;
            this.btnMusteriEkleDon.Click += new System.EventHandler(this.btnMusteriEkleDon_Click);
            // 
            // btnAnaSayfaDon
            // 
            this.btnAnaSayfaDon.Location = new System.Drawing.Point(100, 338);
            this.btnAnaSayfaDon.Name = "btnAnaSayfaDon";
            this.btnAnaSayfaDon.Size = new System.Drawing.Size(154, 88);
            this.btnAnaSayfaDon.TabIndex = 6;
            this.btnAnaSayfaDon.Text = "Banka Ekleme Sayfasına Dön";
            this.btnAnaSayfaDon.UseVisualStyleBackColor = true;
            this.btnAnaSayfaDon.Click += new System.EventHandler(this.btnAnaSayfaDon_Click);
            // 
            // lstMusteriler
            // 
            this.lstMusteriler.HideSelection = false;
            this.lstMusteriler.Location = new System.Drawing.Point(12, 12);
            this.lstMusteriler.Name = "lstMusteriler";
            this.lstMusteriler.Size = new System.Drawing.Size(789, 320);
            this.lstMusteriler.TabIndex = 5;
            this.lstMusteriler.UseCompatibleStateImageBehavior = false;
            // 
            // BankaMusterileriGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 441);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnBankaListele);
            this.Controls.Add(this.btnMusteriEkleDon);
            this.Controls.Add(this.btnAnaSayfaDon);
            this.Controls.Add(this.lstMusteriler);
            this.Name = "BankaMusterileriGoruntule";
            this.Text = "BankaMusterileriGosterme";
            this.Load += new System.EventHandler(this.BankaMusterileriGoruntule_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnBankaListele;
        private System.Windows.Forms.Button btnMusteriEkleDon;
        private System.Windows.Forms.Button btnAnaSayfaDon;
        private System.Windows.Forms.ListView lstMusteriler;
    }
}