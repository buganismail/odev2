namespace Gorsel1_Emlak_Proje
{
    partial class Musteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteri));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_tcNo = new System.Windows.Forms.TextBox();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.lstvw_musteriler = new System.Windows.Forms.ListView();
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tcno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eposta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.cbx_cinsiyet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_eposta = new System.Windows.Forms.TextBox();
            this.dt_tarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tc No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adres:";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(110, 29);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(166, 20);
            this.txt_ad.TabIndex = 0;
            this.txt_ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ad_KeyPress);
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(110, 115);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(166, 20);
            this.txt_telefon.TabIndex = 3;
            this.txt_telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefon_KeyPress);
            // 
            // txt_tcNo
            // 
            this.txt_tcNo.Location = new System.Drawing.Point(110, 60);
            this.txt_tcNo.MaxLength = 11;
            this.txt_tcNo.Name = "txt_tcNo";
            this.txt_tcNo.Size = new System.Drawing.Size(166, 20);
            this.txt_tcNo.TabIndex = 1;
            this.txt_tcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tcNo_KeyPress);
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(110, 171);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(166, 102);
            this.txt_adres.TabIndex = 5;
            // 
            // lstvw_musteriler
            // 
            this.lstvw_musteriler.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lstvw_musteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ad,
            this.tcno,
            this.eposta,
            this.Telefon,
            this.Cinsiyet,
            this.Adres,
            this.Tarih});
            this.lstvw_musteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstvw_musteriler.FullRowSelect = true;
            this.lstvw_musteriler.Location = new System.Drawing.Point(308, 12);
            this.lstvw_musteriler.Name = "lstvw_musteriler";
            this.lstvw_musteriler.Size = new System.Drawing.Size(1050, 512);
            this.lstvw_musteriler.TabIndex = 10;
            this.lstvw_musteriler.UseCompatibleStateImageBehavior = false;
            this.lstvw_musteriler.View = System.Windows.Forms.View.Details;
            this.lstvw_musteriler.SelectedIndexChanged += new System.EventHandler(this.lstvw_musteriler_SelectedIndexChanged);
            // 
            // Ad
            // 
            this.Ad.Text = "Ad Soyad";
            this.Ad.Width = 104;
            // 
            // tcno
            // 
            this.tcno.Text = "Tc No";
            this.tcno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tcno.Width = 108;
            // 
            // eposta
            // 
            this.eposta.Text = "E-Posta";
            this.eposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eposta.Width = 187;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Telefon.Width = 153;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.Text = "Cinsiyet";
            this.Cinsiyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cinsiyet.Width = 77;
            // 
            // Adres
            // 
            this.Adres.Text = "Adres";
            this.Adres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Adres.Width = 232;
            // 
            // Tarih
            // 
            this.Tarih.Text = "Tarih";
            this.Tarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tarih.Width = 146;
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_temizle.BackgroundImage")));
            this.btn_temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Location = new System.Drawing.Point(193, 439);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(83, 85);
            this.btn_temizle.TabIndex = 9;
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.BackgroundImage")));
            this.btn_guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Location = new System.Drawing.Point(104, 439);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(83, 85);
            this.btn_guncelle.TabIndex = 8;
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sil.BackgroundImage")));
            this.btn_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(193, 348);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(83, 85);
            this.btn_sil.TabIndex = 7;
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ekle.BackgroundImage")));
            this.btn_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(104, 348);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(83, 85);
            this.btn_ekle.TabIndex = 6;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // cbx_cinsiyet
            // 
            this.cbx_cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_cinsiyet.FormattingEnabled = true;
            this.cbx_cinsiyet.Location = new System.Drawing.Point(110, 142);
            this.cbx_cinsiyet.Name = "cbx_cinsiyet";
            this.cbx_cinsiyet.Size = new System.Drawing.Size(166, 21);
            this.cbx_cinsiyet.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "E-Posta:";
            // 
            // txt_eposta
            // 
            this.txt_eposta.Location = new System.Drawing.Point(110, 88);
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.Size = new System.Drawing.Size(166, 20);
            this.txt_eposta.TabIndex = 2;
            // 
            // dt_tarih
            // 
            this.dt_tarih.Location = new System.Drawing.Point(99, 294);
            this.dt_tarih.Name = "dt_tarih";
            this.dt_tarih.Size = new System.Drawing.Size(177, 20);
            this.dt_tarih.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tarih:";
            // 
            // Musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1354, 517);
            this.Controls.Add(this.dt_tarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_eposta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbx_cinsiyet);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.lstvw_musteriler);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.txt_tcNo);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Musteri";
            this.Text = "Müşteri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Musteri_FormClosed);
            this.Load += new System.EventHandler(this.Musteri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_tcNo;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.ListView lstvw_musteriler;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.ComboBox cbx_cinsiyet;
        private System.Windows.Forms.ColumnHeader tcno;
        private System.Windows.Forms.ColumnHeader eposta;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Cinsiyet;
        private System.Windows.Forms.ColumnHeader Adres;
        private System.Windows.Forms.ColumnHeader Tarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_eposta;
        private System.Windows.Forms.DateTimePicker dt_tarih;
        private System.Windows.Forms.Label label2;
    }
}