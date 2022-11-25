namespace BankaApp
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
            this.btnBankaEkle = new System.Windows.Forms.Button();
            this.btnBankaListele = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBankaEkle
            // 
            this.btnBankaEkle.Location = new System.Drawing.Point(397, 606);
            this.btnBankaEkle.Name = "btnBankaEkle";
            this.btnBankaEkle.Size = new System.Drawing.Size(275, 113);
            this.btnBankaEkle.TabIndex = 0;
            this.btnBankaEkle.Text = "Banka Ekle";
            this.btnBankaEkle.UseVisualStyleBackColor = true;
            this.btnBankaEkle.Click += new System.EventHandler(this.btnBankaEkle_Click);
            // 
            // btnBankaListele
            // 
            this.btnBankaListele.Location = new System.Drawing.Point(678, 606);
            this.btnBankaListele.Name = "btnBankaListele";
            this.btnBankaListele.Size = new System.Drawing.Size(275, 113);
            this.btnBankaListele.TabIndex = 1;
            this.btnBankaListele.Text = "Banka Listele";
            this.btnBankaListele.UseVisualStyleBackColor = true;
            this.btnBankaListele.Click += new System.EventHandler(this.btnBankaListele_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(281, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(776, 382);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 731);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnBankaListele);
            this.Controls.Add(this.btnBankaEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBankaEkle;
        private System.Windows.Forms.Button btnBankaListele;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

