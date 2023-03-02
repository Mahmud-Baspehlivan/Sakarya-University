
namespace KutuphaneSQL
{
    partial class KutuphaneArayuz
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnUyeIslem = new System.Windows.Forms.Button();
            this.btnKitapIslem = new System.Windows.Forms.Button();
            this.btnOduncIslem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUyeIslem
            // 
            this.btnUyeIslem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUyeIslem.Location = new System.Drawing.Point(92, 115);
            this.btnUyeIslem.Margin = new System.Windows.Forms.Padding(2);
            this.btnUyeIslem.Name = "btnUyeIslem";
            this.btnUyeIslem.Size = new System.Drawing.Size(105, 55);
            this.btnUyeIslem.TabIndex = 0;
            this.btnUyeIslem.Text = "Üye İşlemleri";
            this.btnUyeIslem.UseCompatibleTextRendering = true;
            this.btnUyeIslem.UseVisualStyleBackColor = false;
            this.btnUyeIslem.Click += new System.EventHandler(this.btnUyeIslem_Click);
            // 
            // btnKitapIslem
            // 
            this.btnKitapIslem.Location = new System.Drawing.Point(255, 115);
            this.btnKitapIslem.Margin = new System.Windows.Forms.Padding(2);
            this.btnKitapIslem.Name = "btnKitapIslem";
            this.btnKitapIslem.Size = new System.Drawing.Size(105, 55);
            this.btnKitapIslem.TabIndex = 1;
            this.btnKitapIslem.Text = "Kitap İşlemleri";
            this.btnKitapIslem.UseVisualStyleBackColor = true;
            this.btnKitapIslem.Click += new System.EventHandler(this.btnKitapIslem_Click);
            // 
            // btnOduncIslem
            // 
            this.btnOduncIslem.Location = new System.Drawing.Point(417, 115);
            this.btnOduncIslem.Margin = new System.Windows.Forms.Padding(2);
            this.btnOduncIslem.Name = "btnOduncIslem";
            this.btnOduncIslem.Size = new System.Drawing.Size(105, 55);
            this.btnOduncIslem.TabIndex = 2;
            this.btnOduncIslem.Text = "Ödünç İşlemleri";
            this.btnOduncIslem.UseVisualStyleBackColor = true;
            this.btnOduncIslem.Click += new System.EventHandler(this.btnOduncIslem_Click);
            // 
            // KutuphaneArayuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneSQL.Properties.Resources.indir;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnOduncIslem);
            this.Controls.Add(this.btnKitapIslem);
            this.Controls.Add(this.btnUyeIslem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KutuphaneArayuz";
            this.Text = "Kütüphane Arayüzü";
            this.Load += new System.EventHandler(this.KutuphaneArayuz_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnUyeIslem;
        private System.Windows.Forms.Button btnKitapIslem;
        private System.Windows.Forms.Button btnOduncIslem;
    }
}

