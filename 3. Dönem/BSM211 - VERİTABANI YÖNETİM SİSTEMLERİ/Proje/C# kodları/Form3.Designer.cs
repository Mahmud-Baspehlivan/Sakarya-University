
namespace KutuphaneSQL
{
    partial class KitapIslemleri
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
            this.txtKid = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtKitapAra = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnKitapGuncelle = new System.Windows.Forms.Button();
            this.btnKitapSil = new System.Windows.Forms.Button();
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtKsayfa = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtKisbn = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKbasimyili = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKadi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.cmbKyayin = new System.Windows.Forms.ComboBox();
            this.txtKturadi = new System.Windows.Forms.TextBox();
            this.txtKyazar = new System.Windows.Forms.TextBox();
            this.txtKstok = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKid
            // 
            this.txtKid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKid.Location = new System.Drawing.Point(785, 393);
            this.txtKid.Margin = new System.Windows.Forms.Padding(2);
            this.txtKid.Name = "txtKid";
            this.txtKid.Size = new System.Drawing.Size(84, 24);
            this.txtKid.TabIndex = 53;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(583, 396);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(198, 18);
            this.label20.TabIndex = 52;
            this.label20.Text = "İşlem yapılacak IDyi girin:";
            // 
            // txtKitapAra
            // 
            this.txtKitapAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAra.Location = new System.Drawing.Point(785, 365);
            this.txtKitapAra.Margin = new System.Windows.Forms.Padding(2);
            this.txtKitapAra.Name = "txtKitapAra";
            this.txtKitapAra.Size = new System.Drawing.Size(84, 24);
            this.txtKitapAra.TabIndex = 51;
            this.txtKitapAra.TextChanged += new System.EventHandler(this.txtKitapAra_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(729, 368);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 18);
            this.label19.TabIndex = 50;
            this.label19.Text = "ARA:";
            // 
            // btnKitapGuncelle
            // 
            this.btnKitapGuncelle.Location = new System.Drawing.Point(445, 364);
            this.btnKitapGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnKitapGuncelle.Name = "btnKitapGuncelle";
            this.btnKitapGuncelle.Size = new System.Drawing.Size(116, 50);
            this.btnKitapGuncelle.TabIndex = 49;
            this.btnKitapGuncelle.Text = "Güncelle";
            this.btnKitapGuncelle.UseVisualStyleBackColor = true;
            this.btnKitapGuncelle.Click += new System.EventHandler(this.btnKitapGuncelle_Click);
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.Location = new System.Drawing.Point(302, 364);
            this.btnKitapSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.Size = new System.Drawing.Size(116, 50);
            this.btnKitapSil.TabIndex = 48;
            this.btnKitapSil.Text = "Kitap Sil";
            this.btnKitapSil.UseVisualStyleBackColor = true;
            this.btnKitapSil.Click += new System.EventHandler(this.btnKitapSil_Click);
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.Location = new System.Drawing.Point(168, 364);
            this.btnKitapListele.Margin = new System.Windows.Forms.Padding(2);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(116, 50);
            this.btnKitapListele.TabIndex = 47;
            this.btnKitapListele.Text = "Listele";
            this.btnKitapListele.UseVisualStyleBackColor = true;
            this.btnKitapListele.Click += new System.EventHandler(this.btnKitapListele_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(33, 364);
            this.btnKitapEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(116, 50);
            this.btnKitapEkle.TabIndex = 46;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(724, 292);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 18);
            this.label17.TabIndex = 43;
            this.label17.Text = "Yazar Adı:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(737, 256);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 18);
            this.label16.TabIndex = 41;
            this.label16.Text = "Tür Adı:";
            // 
            // txtKsayfa
            // 
            this.txtKsayfa.Location = new System.Drawing.Point(816, 218);
            this.txtKsayfa.Margin = new System.Windows.Forms.Padding(2);
            this.txtKsayfa.Name = "txtKsayfa";
            this.txtKsayfa.Size = new System.Drawing.Size(100, 20);
            this.txtKsayfa.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(711, 217);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 18);
            this.label15.TabIndex = 38;
            this.label15.Text = "Sayfa Sayısı:";
            // 
            // txtKisbn
            // 
            this.txtKisbn.Location = new System.Drawing.Point(816, 180);
            this.txtKisbn.Margin = new System.Windows.Forms.Padding(2);
            this.txtKisbn.Name = "txtKisbn";
            this.txtKisbn.Size = new System.Drawing.Size(100, 20);
            this.txtKisbn.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(753, 180);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 18);
            this.label14.TabIndex = 36;
            this.label14.Text = "ISBN:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(713, 147);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 18);
            this.label13.TabIndex = 35;
            this.label13.Text = "Stok Miktarı:";
            // 
            // txtKbasimyili
            // 
            this.txtKbasimyili.Location = new System.Drawing.Point(816, 109);
            this.txtKbasimyili.Margin = new System.Windows.Forms.Padding(2);
            this.txtKbasimyili.Name = "txtKbasimyili";
            this.txtKbasimyili.Size = new System.Drawing.Size(100, 20);
            this.txtKbasimyili.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(724, 108);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 18);
            this.label12.TabIndex = 32;
            this.label12.Text = "Basım Yılı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(726, 72);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 18);
            this.label11.TabIndex = 30;
            this.label11.Text = "Yayın Evi:";
            // 
            // txtKadi
            // 
            this.txtKadi.Location = new System.Drawing.Point(816, 36);
            this.txtKadi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.Size = new System.Drawing.Size(100, 20);
            this.txtKadi.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(729, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "Kitap Adı:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(11, 9);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(694, 334);
            this.dataGridView3.TabIndex = 27;
            // 
            // cmbKyayin
            // 
            this.cmbKyayin.FormattingEnabled = true;
            this.cmbKyayin.Location = new System.Drawing.Point(816, 70);
            this.cmbKyayin.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKyayin.Name = "cmbKyayin";
            this.cmbKyayin.Size = new System.Drawing.Size(100, 21);
            this.cmbKyayin.TabIndex = 54;
            // 
            // txtKturadi
            // 
            this.txtKturadi.Location = new System.Drawing.Point(816, 254);
            this.txtKturadi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKturadi.Name = "txtKturadi";
            this.txtKturadi.Size = new System.Drawing.Size(100, 20);
            this.txtKturadi.TabIndex = 55;
            // 
            // txtKyazar
            // 
            this.txtKyazar.Location = new System.Drawing.Point(816, 290);
            this.txtKyazar.Margin = new System.Windows.Forms.Padding(2);
            this.txtKyazar.Name = "txtKyazar";
            this.txtKyazar.Size = new System.Drawing.Size(100, 20);
            this.txtKyazar.TabIndex = 56;
            // 
            // txtKstok
            // 
            this.txtKstok.Location = new System.Drawing.Point(816, 145);
            this.txtKstok.Margin = new System.Windows.Forms.Padding(2);
            this.txtKstok.Name = "txtKstok";
            this.txtKstok.Size = new System.Drawing.Size(100, 20);
            this.txtKstok.TabIndex = 58;
            // 
            // KitapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneSQL.Properties.Resources.ircica_kütüphanesi;
            this.ClientSize = new System.Drawing.Size(938, 446);
            this.Controls.Add(this.txtKstok);
            this.Controls.Add(this.txtKyazar);
            this.Controls.Add(this.txtKturadi);
            this.Controls.Add(this.cmbKyayin);
            this.Controls.Add(this.txtKid);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtKitapAra);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnKitapGuncelle);
            this.Controls.Add(this.btnKitapSil);
            this.Controls.Add(this.btnKitapListele);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtKsayfa);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtKisbn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtKbasimyili);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtKadi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KitapIslemleri";
            this.Text = "Kitap İşlemleri";
            this.Load += new System.EventHandler(this.KitapIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKid;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtKitapAra;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnKitapGuncelle;
        private System.Windows.Forms.Button btnKitapSil;
        private System.Windows.Forms.Button btnKitapListele;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtKsayfa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtKisbn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKbasimyili;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKadi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox cmbKyayin;
        private System.Windows.Forms.TextBox txtKturadi;
        private System.Windows.Forms.TextBox txtKyazar;
        private System.Windows.Forms.TextBox txtKstok;
    }
}