namespace Gorsel1_Emlak_Proje
{
    partial class Emlak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emlak));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_durum = new System.Windows.Forms.ComboBox();
            this.cbx_emlaktürü = new System.Windows.Forms.ComboBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.txt_slogan = new System.Windows.Forms.TextBox();
            this.lstvw_emlak = new System.Windows.Forms.ListView();
            this.Slogan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Durum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmlakTürü = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MülkSahibi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbx_mulks = new System.Windows.Forms.ComboBox();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slogan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Durum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Emlak Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fiyat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mülk Sahibi:";
            // 
            // cbx_durum
            // 
            this.cbx_durum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_durum.FormattingEnabled = true;
            this.cbx_durum.Location = new System.Drawing.Point(116, 63);
            this.cbx_durum.Name = "cbx_durum";
            this.cbx_durum.Size = new System.Drawing.Size(166, 21);
            this.cbx_durum.TabIndex = 1;
            // 
            // cbx_emlaktürü
            // 
            this.cbx_emlaktürü.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_emlaktürü.FormattingEnabled = true;
            this.cbx_emlaktürü.Location = new System.Drawing.Point(116, 93);
            this.cbx_emlaktürü.Name = "cbx_emlaktürü";
            this.cbx_emlaktürü.Size = new System.Drawing.Size(166, 21);
            this.cbx_emlaktürü.TabIndex = 2;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(116, 123);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(166, 20);
            this.txt_fiyat.TabIndex = 3;
            this.txt_fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fiyat_KeyPress);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ekle.BackgroundImage")));
            this.btn_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(110, 323);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(83, 85);
            this.btn_ekle.TabIndex = 6;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sil.BackgroundImage")));
            this.btn_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(199, 323);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(83, 85);
            this.btn_sil.TabIndex = 7;
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.BackgroundImage")));
            this.btn_guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Location = new System.Drawing.Point(110, 414);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(83, 85);
            this.btn_guncelle.TabIndex = 8;
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_temizle.BackgroundImage")));
            this.btn_temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Location = new System.Drawing.Point(199, 414);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(83, 85);
            this.btn_temizle.TabIndex = 9;
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // txt_slogan
            // 
            this.txt_slogan.Location = new System.Drawing.Point(116, 35);
            this.txt_slogan.Name = "txt_slogan";
            this.txt_slogan.Size = new System.Drawing.Size(166, 20);
            this.txt_slogan.TabIndex = 0;
            // 
            // lstvw_emlak
            // 
            this.lstvw_emlak.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Slogan,
            this.Durum,
            this.EmlakTürü,
            this.Fiyat,
            this.MülkSahibi,
            this.Adres});
            this.lstvw_emlak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstvw_emlak.FullRowSelect = true;
            this.lstvw_emlak.Location = new System.Drawing.Point(308, -1);
            this.lstvw_emlak.Name = "lstvw_emlak";
            this.lstvw_emlak.Size = new System.Drawing.Size(1050, 500);
            this.lstvw_emlak.TabIndex = 10;
            this.lstvw_emlak.UseCompatibleStateImageBehavior = false;
            this.lstvw_emlak.View = System.Windows.Forms.View.Details;
            this.lstvw_emlak.SelectedIndexChanged += new System.EventHandler(this.lstvw_emlak_SelectedIndexChanged);
            // 
            // Slogan
            // 
            this.Slogan.Text = "Slogan";
            this.Slogan.Width = 111;
            // 
            // Durum
            // 
            this.Durum.Text = "Durum";
            this.Durum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Durum.Width = 122;
            // 
            // EmlakTürü
            // 
            this.EmlakTürü.Text = "Emlak Türü";
            this.EmlakTürü.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmlakTürü.Width = 208;
            // 
            // Fiyat
            // 
            this.Fiyat.Text = "Fiyat";
            this.Fiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fiyat.Width = 148;
            // 
            // MülkSahibi
            // 
            this.MülkSahibi.Text = "Mülk Sahibi";
            this.MülkSahibi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MülkSahibi.Width = 172;
            // 
            // Adres
            // 
            this.Adres.Text = "Adres";
            this.Adres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Adres.Width = 245;
            // 
            // cbx_mulks
            // 
            this.cbx_mulks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_mulks.FormattingEnabled = true;
            this.cbx_mulks.Location = new System.Drawing.Point(116, 153);
            this.cbx_mulks.Name = "cbx_mulks";
            this.cbx_mulks.Size = new System.Drawing.Size(166, 21);
            this.cbx_mulks.TabIndex = 4;
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(116, 193);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(166, 102);
            this.txt_adres.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Adres:";
            // 
            // Emlak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1354, 532);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_mulks);
            this.Controls.Add(this.lstvw_emlak);
            this.Controls.Add(this.txt_slogan);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.cbx_emlaktürü);
            this.Controls.Add(this.cbx_durum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Emlak";
            this.Text = "Emlak";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Emlak_FormClosed);
            this.Load += new System.EventHandler(this.Emlak_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_durum;
        private System.Windows.Forms.ComboBox cbx_emlaktürü;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.TextBox txt_slogan;
        private System.Windows.Forms.ListView lstvw_emlak;
        private System.Windows.Forms.ColumnHeader Slogan;
        private System.Windows.Forms.ColumnHeader Durum;
        private System.Windows.Forms.ColumnHeader EmlakTürü;
        private System.Windows.Forms.ColumnHeader Fiyat;
        private System.Windows.Forms.ColumnHeader MülkSahibi;
        private System.Windows.Forms.ComboBox cbx_mulks;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader Adres;
    }
}