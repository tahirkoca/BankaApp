namespace BankaApp
{
    partial class BankaListelemeFormu
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
            this.lstBankalar = new System.Windows.Forms.ListView();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnMusteriGoruntule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBankalar
            // 
            this.lstBankalar.HideSelection = false;
            this.lstBankalar.Location = new System.Drawing.Point(71, 12);
            this.lstBankalar.Name = "lstBankalar";
            this.lstBankalar.Size = new System.Drawing.Size(1035, 503);
            this.lstBankalar.TabIndex = 0;
            this.lstBankalar.UseCompatibleStateImageBehavior = false;
            this.lstBankalar.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstBankalar_ItemSelectionChanged);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(323, 552);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(258, 114);
            this.btnMusteriEkle.TabIndex = 1;
            this.btnMusteriEkle.Text = "Banka Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnMusteriGoruntule
            // 
            this.btnMusteriGoruntule.Location = new System.Drawing.Point(620, 552);
            this.btnMusteriGoruntule.Name = "btnMusteriGoruntule";
            this.btnMusteriGoruntule.Size = new System.Drawing.Size(258, 114);
            this.btnMusteriGoruntule.TabIndex = 2;
            this.btnMusteriGoruntule.Text = "Banka Müşterileri Görüntüle";
            this.btnMusteriGoruntule.UseVisualStyleBackColor = true;
            this.btnMusteriGoruntule.Click += new System.EventHandler(this.btnMusteriGoruntule_Click);
            // 
            // BankaListelemeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 723);
            this.Controls.Add(this.btnMusteriGoruntule);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.lstBankalar);
            this.Name = "BankaListelemeFormu";
            this.Text = "BankaListelemeFormu";
            this.Load += new System.EventHandler(this.BankaListelemeFormu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstBankalar;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusteriGoruntule;
    }
}