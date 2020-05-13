namespace Gorsel1_Emlak_Proje
{
    partial class EmlakOzellik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmlakOzellik));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_yetki = new System.Windows.Forms.ComboBox();
            this.tx_sifre = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.lstvw_kullanici = new System.Windows.Forms.ListView();
            this.KullanıcıAdı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KullanıcıSifresi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tx_kad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yetki:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sifre:";
            // 
            // cbx_yetki
            // 
            this.cbx_yetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_yetki.FormattingEnabled = true;
            this.cbx_yetki.Location = new System.Drawing.Point(122, 92);
            this.cbx_yetki.Name = "cbx_yetki";
            this.cbx_yetki.Size = new System.Drawing.Size(166, 21);
            this.cbx_yetki.TabIndex = 2;
            // 
            // tx_sifre
            // 
            this.tx_sifre.Location = new System.Drawing.Point(122, 59);
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.Size = new System.Drawing.Size(166, 20);
            this.tx_sifre.TabIndex = 3;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ekle.BackgroundImage")));
            this.btn_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(103, 156);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(83, 85);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sil.BackgroundImage")));
            this.btn_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(196, 155);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(83, 85);
            this.btn_sil.TabIndex = 5;
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.BackgroundImage")));
            this.btn_guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Location = new System.Drawing.Point(103, 247);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(83, 85);
            this.btn_guncelle.TabIndex = 6;
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_temizle.BackgroundImage")));
            this.btn_temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Location = new System.Drawing.Point(196, 247);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(83, 85);
            this.btn_temizle.TabIndex = 7;
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // lstvw_kullanici
            // 
            this.lstvw_kullanici.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lstvw_kullanici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.KullanıcıAdı,
            this.KullanıcıSifresi,
            this.Aciklama});
            this.lstvw_kullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstvw_kullanici.FullRowSelect = true;
            this.lstvw_kullanici.Location = new System.Drawing.Point(308, 0);
            this.lstvw_kullanici.Name = "lstvw_kullanici";
            this.lstvw_kullanici.Size = new System.Drawing.Size(1050, 361);
            this.lstvw_kullanici.TabIndex = 8;
            this.lstvw_kullanici.UseCompatibleStateImageBehavior = false;
            this.lstvw_kullanici.View = System.Windows.Forms.View.Details;
            this.lstvw_kullanici.SelectedIndexChanged += new System.EventHandler(this.lstvw_kullanici_SelectedIndexChanged);
            // 
            // KullanıcıAdı
            // 
            this.KullanıcıAdı.Text = "Kullanıcı Adı";
            this.KullanıcıAdı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KullanıcıAdı.Width = 142;
            // 
            // KullanıcıSifresi
            // 
            this.KullanıcıSifresi.Text = "Kullanıcı Sifresi";
            this.KullanıcıSifresi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KullanıcıSifresi.Width = 214;
            // 
            // Aciklama
            // 
            this.Aciklama.Text = "Yetkisi";
            this.Aciklama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Aciklama.Width = 214;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı: ";
            // 
            // tx_kad
            // 
            this.tx_kad.Location = new System.Drawing.Point(122, 33);
            this.tx_kad.Name = "tx_kad";
            this.tx_kad.Size = new System.Drawing.Size(166, 20);
            this.tx_kad.TabIndex = 3;
            // 
            // EmlakOzellik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1354, 381);
            this.Controls.Add(this.lstvw_kullanici);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.tx_kad);
            this.Controls.Add(this.tx_sifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_yetki);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmlakOzellik";
            this.Text = "Kullanıcı Ekleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmlakOzellik_FormClosed);
            this.Load += new System.EventHandler(this.EmlakOzellik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_yetki;
        private System.Windows.Forms.TextBox tx_sifre;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.ListView lstvw_kullanici;
        private System.Windows.Forms.ColumnHeader KullanıcıAdı;
        private System.Windows.Forms.ColumnHeader KullanıcıSifresi;
        private System.Windows.Forms.ColumnHeader Aciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_kad;
    }
}