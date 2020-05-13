namespace Gorsel1_Emlak_Proje
{
    partial class EmlakTanimlamalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmlakTanimlamalar));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstvw_mulks = new System.Windows.Forms.ListView();
            this.emlaközellik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eotbtn_ekle = new System.Windows.Forms.Button();
            this.txt_mulks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eotbtn_temizle = new System.Windows.Forms.Button();
            this.eotbtn_guncelle = new System.Windows.Forms.Button();
            this.eotbtn_sil = new System.Windows.Forms.Button();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstvw_emlakDurum = new System.Windows.Forms.ListView();
            this.emlakd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dbtn_ekle = new System.Windows.Forms.Button();
            this.txt_durum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dbtn_temizle = new System.Windows.Forms.Button();
            this.dbtn_guncelle = new System.Windows.Forms.Button();
            this.dbtn_sil = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lstw_emlaktur = new System.Windows.Forms.ListView();
            this.emlatur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_emlaktür = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.etbtn_temizle = new System.Windows.Forms.Button();
            this.etbtn_guncelle = new System.Windows.Forms.Button();
            this.etbtn_sil = new System.Windows.Forms.Button();
            this.etbtn_ekle = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tabPage1.Controls.Add(this.lstvw_mulks);
            this.tabPage1.Controls.Add(this.eotbtn_ekle);
            this.tabPage1.Controls.Add(this.txt_mulks);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.eotbtn_temizle);
            this.tabPage1.Controls.Add(this.eotbtn_guncelle);
            this.tabPage1.Controls.Add(this.eotbtn_sil);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1351, 615);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mülk sahibi";
            // 
            // lstvw_mulks
            // 
            this.lstvw_mulks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.emlaközellik});
            this.lstvw_mulks.FullRowSelect = true;
            this.lstvw_mulks.Location = new System.Drawing.Point(260, 27);
            this.lstvw_mulks.Name = "lstvw_mulks";
            this.lstvw_mulks.Size = new System.Drawing.Size(133, 275);
            this.lstvw_mulks.TabIndex = 5;
            this.lstvw_mulks.UseCompatibleStateImageBehavior = false;
            this.lstvw_mulks.View = System.Windows.Forms.View.Details;
            this.lstvw_mulks.SelectedIndexChanged += new System.EventHandler(this.lstvw_emlakOzellikTuru_SelectedIndexChanged);
            // 
            // emlaközellik
            // 
            this.emlaközellik.Text = "Emlak Özellik Türü";
            this.emlaközellik.Width = 140;
            // 
            // eotbtn_ekle
            // 
            this.eotbtn_ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eotbtn_ekle.BackgroundImage")));
            this.eotbtn_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eotbtn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eotbtn_ekle.Location = new System.Drawing.Point(55, 78);
            this.eotbtn_ekle.Name = "eotbtn_ekle";
            this.eotbtn_ekle.Size = new System.Drawing.Size(82, 68);
            this.eotbtn_ekle.TabIndex = 1;
            this.eotbtn_ekle.UseVisualStyleBackColor = true;
            this.eotbtn_ekle.Click += new System.EventHandler(this.eotbtn_ekle_Click);
            // 
            // txt_mulks
            // 
            this.txt_mulks.Location = new System.Drawing.Point(112, 37);
            this.txt_mulks.Name = "txt_mulks";
            this.txt_mulks.Size = new System.Drawing.Size(100, 20);
            this.txt_mulks.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mülk Sahibi:";
            // 
            // eotbtn_temizle
            // 
            this.eotbtn_temizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eotbtn_temizle.BackgroundImage")));
            this.eotbtn_temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eotbtn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eotbtn_temizle.Location = new System.Drawing.Point(143, 152);
            this.eotbtn_temizle.Name = "eotbtn_temizle";
            this.eotbtn_temizle.Size = new System.Drawing.Size(82, 68);
            this.eotbtn_temizle.TabIndex = 4;
            this.eotbtn_temizle.UseVisualStyleBackColor = true;
            this.eotbtn_temizle.Click += new System.EventHandler(this.eotbtn_temizle_Click);
            // 
            // eotbtn_guncelle
            // 
            this.eotbtn_guncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eotbtn_guncelle.BackgroundImage")));
            this.eotbtn_guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eotbtn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eotbtn_guncelle.Location = new System.Drawing.Point(55, 152);
            this.eotbtn_guncelle.Name = "eotbtn_guncelle";
            this.eotbtn_guncelle.Size = new System.Drawing.Size(82, 68);
            this.eotbtn_guncelle.TabIndex = 3;
            this.eotbtn_guncelle.UseVisualStyleBackColor = true;
            this.eotbtn_guncelle.Click += new System.EventHandler(this.eotbtn_guncelle_Click);
            // 
            // eotbtn_sil
            // 
            this.eotbtn_sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eotbtn_sil.BackgroundImage")));
            this.eotbtn_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eotbtn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eotbtn_sil.Location = new System.Drawing.Point(143, 78);
            this.eotbtn_sil.Name = "eotbtn_sil";
            this.eotbtn_sil.Size = new System.Drawing.Size(82, 68);
            this.eotbtn_sil.TabIndex = 2;
            this.eotbtn_sil.UseVisualStyleBackColor = true;
            this.eotbtn_sil.Click += new System.EventHandler(this.eotbtn_sil_Click);
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Controls.Add(this.tabPage3);
            this.TabControl1.Location = new System.Drawing.Point(4, -1);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1359, 641);
            this.TabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage2.Controls.Add(this.lstvw_emlakDurum);
            this.tabPage2.Controls.Add(this.dbtn_ekle);
            this.tabPage2.Controls.Add(this.txt_durum);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dbtn_temizle);
            this.tabPage2.Controls.Add(this.dbtn_guncelle);
            this.tabPage2.Controls.Add(this.dbtn_sil);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1351, 615);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Emlak Durum";
            // 
            // lstvw_emlakDurum
            // 
            this.lstvw_emlakDurum.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.emlakd});
            this.lstvw_emlakDurum.FullRowSelect = true;
            this.lstvw_emlakDurum.Location = new System.Drawing.Point(234, 41);
            this.lstvw_emlakDurum.Name = "lstvw_emlakDurum";
            this.lstvw_emlakDurum.Size = new System.Drawing.Size(145, 275);
            this.lstvw_emlakDurum.TabIndex = 5;
            this.lstvw_emlakDurum.UseCompatibleStateImageBehavior = false;
            this.lstvw_emlakDurum.View = System.Windows.Forms.View.Details;
            this.lstvw_emlakDurum.SelectedIndexChanged += new System.EventHandler(this.lstvw_emlakDurum_SelectedIndexChanged);
            // 
            // emlakd
            // 
            this.emlakd.Text = "Emlak Durum";
            this.emlakd.Width = 140;
            // 
            // dbtn_ekle
            // 
            this.dbtn_ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dbtn_ekle.BackgroundImage")));
            this.dbtn_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dbtn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dbtn_ekle.Location = new System.Drawing.Point(48, 78);
            this.dbtn_ekle.Name = "dbtn_ekle";
            this.dbtn_ekle.Size = new System.Drawing.Size(82, 68);
            this.dbtn_ekle.TabIndex = 1;
            this.dbtn_ekle.UseVisualStyleBackColor = true;
            this.dbtn_ekle.Click += new System.EventHandler(this.dbtn_ekle_Click);
            // 
            // txt_durum
            // 
            this.txt_durum.Location = new System.Drawing.Point(92, 41);
            this.txt_durum.Name = "txt_durum";
            this.txt_durum.Size = new System.Drawing.Size(100, 20);
            this.txt_durum.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Durum:";
            // 
            // dbtn_temizle
            // 
            this.dbtn_temizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dbtn_temizle.BackgroundImage")));
            this.dbtn_temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dbtn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dbtn_temizle.Location = new System.Drawing.Point(136, 152);
            this.dbtn_temizle.Name = "dbtn_temizle";
            this.dbtn_temizle.Size = new System.Drawing.Size(82, 68);
            this.dbtn_temizle.TabIndex = 4;
            this.dbtn_temizle.UseVisualStyleBackColor = true;
            this.dbtn_temizle.Click += new System.EventHandler(this.dbtn_temizle_Click);
            // 
            // dbtn_guncelle
            // 
            this.dbtn_guncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dbtn_guncelle.BackgroundImage")));
            this.dbtn_guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dbtn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dbtn_guncelle.Location = new System.Drawing.Point(48, 152);
            this.dbtn_guncelle.Name = "dbtn_guncelle";
            this.dbtn_guncelle.Size = new System.Drawing.Size(82, 68);
            this.dbtn_guncelle.TabIndex = 3;
            this.dbtn_guncelle.UseVisualStyleBackColor = true;
            this.dbtn_guncelle.Click += new System.EventHandler(this.dbtn_guncelle_Click);
            // 
            // dbtn_sil
            // 
            this.dbtn_sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dbtn_sil.BackgroundImage")));
            this.dbtn_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dbtn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dbtn_sil.Location = new System.Drawing.Point(136, 78);
            this.dbtn_sil.Name = "dbtn_sil";
            this.dbtn_sil.Size = new System.Drawing.Size(82, 68);
            this.dbtn_sil.TabIndex = 2;
            this.dbtn_sil.UseVisualStyleBackColor = true;
            this.dbtn_sil.Click += new System.EventHandler(this.dbtn_sil_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage3.Controls.Add(this.lstw_emlaktur);
            this.tabPage3.Controls.Add(this.txt_emlaktür);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.etbtn_temizle);
            this.tabPage3.Controls.Add(this.etbtn_guncelle);
            this.tabPage3.Controls.Add(this.etbtn_sil);
            this.tabPage3.Controls.Add(this.etbtn_ekle);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1351, 615);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Emlak Tür";
            // 
            // lstw_emlaktur
            // 
            this.lstw_emlaktur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.emlatur});
            this.lstw_emlaktur.Location = new System.Drawing.Point(240, 42);
            this.lstw_emlaktur.Name = "lstw_emlaktur";
            this.lstw_emlaktur.Size = new System.Drawing.Size(138, 255);
            this.lstw_emlaktur.TabIndex = 5;
            this.lstw_emlaktur.UseCompatibleStateImageBehavior = false;
            this.lstw_emlaktur.View = System.Windows.Forms.View.Details;
            this.lstw_emlaktur.SelectedIndexChanged += new System.EventHandler(this.lstw_emlaktur_SelectedIndexChanged);
            // 
            // emlatur
            // 
            this.emlatur.Text = "Emlak Tür";
            this.emlatur.Width = 132;
            // 
            // txt_emlaktür
            // 
            this.txt_emlaktür.Location = new System.Drawing.Point(110, 42);
            this.txt_emlaktür.Name = "txt_emlaktür";
            this.txt_emlaktür.Size = new System.Drawing.Size(100, 20);
            this.txt_emlaktür.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Emlak Tür:";
            // 
            // etbtn_temizle
            // 
            this.etbtn_temizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("etbtn_temizle.BackgroundImage")));
            this.etbtn_temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.etbtn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.etbtn_temizle.Location = new System.Drawing.Point(143, 152);
            this.etbtn_temizle.Name = "etbtn_temizle";
            this.etbtn_temizle.Size = new System.Drawing.Size(82, 68);
            this.etbtn_temizle.TabIndex = 4;
            this.etbtn_temizle.UseVisualStyleBackColor = true;
            this.etbtn_temizle.Click += new System.EventHandler(this.etbtn_temizle_Click);
            // 
            // etbtn_guncelle
            // 
            this.etbtn_guncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("etbtn_guncelle.BackgroundImage")));
            this.etbtn_guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.etbtn_guncelle.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.etbtn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.etbtn_guncelle.Location = new System.Drawing.Point(55, 152);
            this.etbtn_guncelle.Name = "etbtn_guncelle";
            this.etbtn_guncelle.Size = new System.Drawing.Size(82, 68);
            this.etbtn_guncelle.TabIndex = 3;
            this.etbtn_guncelle.UseVisualStyleBackColor = true;
            this.etbtn_guncelle.Click += new System.EventHandler(this.etbtn_guncelle_Click);
            // 
            // etbtn_sil
            // 
            this.etbtn_sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("etbtn_sil.BackgroundImage")));
            this.etbtn_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.etbtn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.etbtn_sil.Location = new System.Drawing.Point(143, 78);
            this.etbtn_sil.Name = "etbtn_sil";
            this.etbtn_sil.Size = new System.Drawing.Size(82, 68);
            this.etbtn_sil.TabIndex = 2;
            this.etbtn_sil.UseVisualStyleBackColor = true;
            this.etbtn_sil.Click += new System.EventHandler(this.etbtn_sil_Click);
            // 
            // etbtn_ekle
            // 
            this.etbtn_ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("etbtn_ekle.BackgroundImage")));
            this.etbtn_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.etbtn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.etbtn_ekle.Location = new System.Drawing.Point(55, 78);
            this.etbtn_ekle.Name = "etbtn_ekle";
            this.etbtn_ekle.Size = new System.Drawing.Size(82, 68);
            this.etbtn_ekle.TabIndex = 1;
            this.etbtn_ekle.UseVisualStyleBackColor = true;
            this.etbtn_ekle.Click += new System.EventHandler(this.etbtn_ekle_Click);
            // 
            // EmlakTanimlamalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(889, 340);
            this.Controls.Add(this.TabControl1);
            this.Name = "EmlakTanimlamalar";
            this.Text = "Emlak Tanımlamalar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmlakTanimlamalar_FormClosed);
            this.Load += new System.EventHandler(this.EmlakTanimlamalar_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lstvw_mulks;
        private System.Windows.Forms.Button eotbtn_ekle;
        private System.Windows.Forms.TextBox txt_mulks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button eotbtn_temizle;
        private System.Windows.Forms.Button eotbtn_guncelle;
        private System.Windows.Forms.Button eotbtn_sil;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lstvw_emlakDurum;
        private System.Windows.Forms.Button dbtn_ekle;
        private System.Windows.Forms.TextBox txt_durum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dbtn_temizle;
        private System.Windows.Forms.Button dbtn_guncelle;
        private System.Windows.Forms.Button dbtn_sil;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_emlaktür;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button etbtn_temizle;
        private System.Windows.Forms.Button etbtn_guncelle;
        private System.Windows.Forms.Button etbtn_sil;
        private System.Windows.Forms.Button etbtn_ekle;
        private System.Windows.Forms.ListView lstw_emlaktur;
        private System.Windows.Forms.ColumnHeader emlaközellik;
        private System.Windows.Forms.ColumnHeader emlakd;
        private System.Windows.Forms.ColumnHeader emlatur;
    }
}