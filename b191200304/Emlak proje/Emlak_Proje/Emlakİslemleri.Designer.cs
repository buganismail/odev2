namespace Gorsel1_Emlak_Proje
{
    partial class Emlakİslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emlakİslemleri));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_emlakozellik = new System.Windows.Forms.ComboBox();
            this.cbx_musteri = new System.Windows.Forms.ComboBox();
            this.cbx_personel = new System.Windows.Forms.ComboBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.dt_tarih = new System.Windows.Forms.DateTimePicker();
            this.lstvw_emlakislemleri = new System.Windows.Forms.ListView();
            this.EmlakÖzellik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Müsteri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Personel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emlak Özellik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Müşteri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Personel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fiyat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tarih:";
            // 
            // cbx_emlakozellik
            // 
            this.cbx_emlakozellik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_emlakozellik.FormattingEnabled = true;
            this.cbx_emlakozellik.Location = new System.Drawing.Point(100, 36);
            this.cbx_emlakozellik.Name = "cbx_emlakozellik";
            this.cbx_emlakozellik.Size = new System.Drawing.Size(270, 21);
            this.cbx_emlakozellik.TabIndex = 0;
            // 
            // cbx_musteri
            // 
            this.cbx_musteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_musteri.FormattingEnabled = true;
            this.cbx_musteri.Location = new System.Drawing.Point(100, 70);
            this.cbx_musteri.Name = "cbx_musteri";
            this.cbx_musteri.Size = new System.Drawing.Size(270, 21);
            this.cbx_musteri.TabIndex = 1;
            this.cbx_musteri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbx_musteri_KeyPress);
            // 
            // cbx_personel
            // 
            this.cbx_personel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_personel.FormattingEnabled = true;
            this.cbx_personel.Location = new System.Drawing.Point(100, 101);
            this.cbx_personel.Name = "cbx_personel";
            this.cbx_personel.Size = new System.Drawing.Size(270, 21);
            this.cbx_personel.TabIndex = 2;
            this.cbx_personel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbx_personel_KeyPress);
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(100, 131);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(270, 20);
            this.txt_fiyat.TabIndex = 3;
            this.txt_fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fiyat_KeyPress);
            // 
            // dt_tarih
            // 
            this.dt_tarih.Location = new System.Drawing.Point(100, 162);
            this.dt_tarih.Name = "dt_tarih";
            this.dt_tarih.Size = new System.Drawing.Size(270, 20);
            this.dt_tarih.TabIndex = 4;
            // 
            // lstvw_emlakislemleri
            // 
            this.lstvw_emlakislemleri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmlakÖzellik,
            this.Müsteri,
            this.Personel,
            this.Fiyat,
            this.Tarih});
            this.lstvw_emlakislemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstvw_emlakislemleri.FullRowSelect = true;
            this.lstvw_emlakislemleri.Location = new System.Drawing.Point(376, 1);
            this.lstvw_emlakislemleri.Name = "lstvw_emlakislemleri";
            this.lstvw_emlakislemleri.Size = new System.Drawing.Size(984, 360);
            this.lstvw_emlakislemleri.TabIndex = 9;
            this.lstvw_emlakislemleri.UseCompatibleStateImageBehavior = false;
            this.lstvw_emlakislemleri.View = System.Windows.Forms.View.Details;
            this.lstvw_emlakislemleri.SelectedIndexChanged += new System.EventHandler(this.lstvw_emlakislemleri_SelectedIndexChanged);
            // 
            // EmlakÖzellik
            // 
            this.EmlakÖzellik.Text = "Emlak Özellik";
            this.EmlakÖzellik.Width = 187;
            // 
            // Müsteri
            // 
            this.Müsteri.Text = "Müşteri";
            this.Müsteri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Müsteri.Width = 144;
            // 
            // Personel
            // 
            this.Personel.Text = "Personel";
            this.Personel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Personel.Width = 134;
            // 
            // Fiyat
            // 
            this.Fiyat.Text = "Fiyat";
            this.Fiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fiyat.Width = 134;
            // 
            // Tarih
            // 
            this.Tarih.Text = "Tarih";
            this.Tarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tarih.Width = 206;
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_temizle.BackgroundImage")));
            this.btn_temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Location = new System.Drawing.Point(233, 290);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(83, 84);
            this.btn_temizle.TabIndex = 8;
            this.btn_temizle.UseVisualStyleBackColor = true;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.BackgroundImage")));
            this.btn_guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Location = new System.Drawing.Point(141, 290);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(83, 84);
            this.btn_guncelle.TabIndex = 7;
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sil.BackgroundImage")));
            this.btn_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(233, 200);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(83, 84);
            this.btn_sil.TabIndex = 6;
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ekle.BackgroundImage")));
            this.btn_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(141, 199);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(83, 85);
            this.btn_ekle.TabIndex = 5;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // Emlakİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1354, 427);
            this.Controls.Add(this.lstvw_emlakislemleri);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dt_tarih);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.cbx_personel);
            this.Controls.Add(this.cbx_musteri);
            this.Controls.Add(this.cbx_emlakozellik);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Emlakİslemleri";
            this.Text = "Emlak İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Emlakİslemleri_FormClosed);
            this.Load += new System.EventHandler(this.Emlakİslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_emlakozellik;
        private System.Windows.Forms.ComboBox cbx_musteri;
        private System.Windows.Forms.ComboBox cbx_personel;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.DateTimePicker dt_tarih;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.ListView lstvw_emlakislemleri;
        private System.Windows.Forms.ColumnHeader EmlakÖzellik;
        private System.Windows.Forms.ColumnHeader Müsteri;
        private System.Windows.Forms.ColumnHeader Personel;
        private System.Windows.Forms.ColumnHeader Fiyat;
        private System.Windows.Forms.ColumnHeader Tarih;
    }
}