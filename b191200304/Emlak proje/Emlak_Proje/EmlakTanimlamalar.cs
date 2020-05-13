using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Gorsel1_Emlak_Proje
{
    public partial class EmlakTanimlamalar : Form
    {
        public EmlakTanimlamalar()
        {
            InitializeComponent();
        }
        private void EmlakTanimlamalar_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaSayfa anasayfa = (AnaSayfa)this.MdiParent;
            anasayfa.tsbtn_emlaktanimlamalar.Enabled = true;
        }
        private void eotbtn_ekle_Click(object sender, EventArgs e)


        {
            bool varmi = false;
            foreach (ListViewItem item in lstvw_mulks.Items)
            {
                if (item.SubItems[0].Text == txt_mulks.Text )
                {
                    varmi = true;
                    break;
                }
            }
            if (varmi == true)
            {
               
                MessageBox.Show(" Mülk Sahibi  daha önce eklenmiş tekrar eklenemez !!!.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            
            else if (txt_mulks.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           else
            {
                ListViewItem item = new ListViewItem(new string[] { txt_mulks.Text });
                StreamWriter sw = new StreamWriter("mulksahibi.txt", true);
                sw.WriteLine(txt_mulks.Text);
                sw.Close();
                lstvw_mulks.Items.Add(item);
            }
        }
        private void eotbtn_sil_Click(object sender, EventArgs e)
        {
            if (lstvw_mulks.SelectedItems.Count == 0)
            {
                MessageBox.Show("✖✖ Silinecek Kaydı Seçinizz ✖✖ ??.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            foreach (ListViewItem item in lstvw_mulks.SelectedItems)
            {
                lstvw_mulks.Items.Remove(item);
            }
            StreamWriter sw = new StreamWriter("mulksahibi.txt");
            foreach (ListViewItem item in lstvw_mulks.Items)
            {
                sw.WriteLine(item.SubItems[0].Text);
            }
            sw.Close();
        }
        private void eotbtn_guncelle_Click(object sender, EventArgs e)
        {
            if (lstvw_mulks.SelectedItems.Count == 0)
            {
                MessageBox.Show("✖✖ Güncellenecek Kaydı Seçinizz ✖✖ ??.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            lstvw_mulks.SelectedItems[0].SubItems[0].Text = txt_mulks.Text;
        }
        private void lstvw_emlakOzellikTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvw_mulks.SelectedItems.Count == 0)
                return;
            txt_mulks.Text = lstvw_mulks.SelectedItems[0].SubItems[0].Text;
        }
        private void eotbtn_temizle_Click(object sender, EventArgs e)
        {
            txt_mulks.Text = "";
        }
        private void dbtn_ekle_Click(object sender, EventArgs e)
        {
            bool varmi = false;
            foreach (ListViewItem item in lstvw_emlakDurum.Items)
            {
                if (item.SubItems[0].Text == txt_durum.Text)
                {
                    varmi = true;
                    break;
                }
            }
            if (varmi == true)
            {

                MessageBox.Show(" Bu Kayıt Durumu  daha önce eklenmiş tekrar eklenemez !!!.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_durum.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                ListViewItem item = new ListViewItem(new string[] { txt_durum.Text });
                StreamWriter sw = new StreamWriter("emlakDurum.txt", true);
                sw.WriteLine(txt_durum.Text);
                sw.Close();
                lstvw_emlakDurum.Items.Add(item);
            }
        }
        private void dbtn_sil_Click(object sender, EventArgs e)
        {
            if (lstvw_emlakDurum.SelectedItems.Count == 0)
            {
                MessageBox.Show("✖✖ Silinecek Kaydı Seçinizz ✖✖ ??.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            foreach (ListViewItem item in lstvw_emlakDurum.SelectedItems)
            {
                lstvw_emlakDurum.Items.Remove(item);
            }
            StreamWriter sw = new StreamWriter("emlakDurum.txt");
            foreach (ListViewItem item in lstvw_emlakDurum.Items)
            {
                sw.WriteLine(item.SubItems[0].Text);
            }
            sw.Close();
        }
        private void dbtn_guncelle_Click(object sender, EventArgs e)
        {
            if (lstvw_emlakDurum.SelectedItems.Count == 0)
            {
                MessageBox.Show("✖✖ Güncellenecek Kaydı Seçinizz ✖✖ ??.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            lstvw_emlakDurum.SelectedItems[0].SubItems[0].Text = txt_durum.Text;

        }
        private void lstvw_emlakDurum_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstvw_emlakDurum.SelectedItems.Count == 0)
                return;
            txt_durum.Text = lstvw_emlakDurum.SelectedItems[0].SubItems[0].Text;
        }
        private void dbtn_temizle_Click(object sender, EventArgs e)
        {
            txt_durum.Text = "";
        }
        private void etbtn_ekle_Click(object sender, EventArgs e)
        {
            bool varmi = false;
            foreach (ListViewItem item in lstw_emlaktur.Items)
            {
                if (item.SubItems[0].Text == txt_emlaktür.Text)
                {
                    varmi = true;
                    break;
                }
            }
            if (varmi == true)
            {

                MessageBox.Show(" Emlak türü daha önce eklenmiş tekrar eklenemez !!!.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            else if (txt_emlaktür.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                ListViewItem item = new ListViewItem(new string[] { txt_emlaktür.Text });
                StreamWriter sw = new StreamWriter("emlakTur.txt", true);
                sw.WriteLine(txt_emlaktür.Text);
                sw.Close();
                lstw_emlaktur.Items.Add(item);
            }
        }
        private void etbtn_sil_Click(object sender, EventArgs e)
        {

            if (lstw_emlaktur.SelectedItems.Count == 0)
            {
                MessageBox.Show("✖✖ Silinecek Kaydı Seçinizz ✖✖ ??.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            foreach (ListViewItem item in lstw_emlaktur.SelectedItems)
            {
                lstw_emlaktur.Items.Remove(item);
            }
            StreamWriter sw = new StreamWriter("emlakTur.txt");
            foreach (ListViewItem item in lstw_emlaktur.Items)
            {
                sw.WriteLine(item.SubItems[0].Text);
            }
            sw.Close();
        }
        private void etbtn_guncelle_Click(object sender, EventArgs e)
        {
            if (lstw_emlaktur.SelectedItems.Count == 0)
            {
                MessageBox.Show("✖✖ Güncellenecek Kaydı Seçinizz ✖✖ ??.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            lstw_emlaktur.SelectedItems[0].SubItems[0].Text = txt_emlaktür.Text;
        }

        private void lstw_emlaktur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstw_emlaktur.SelectedItems.Count == 0)
                return;
            txt_emlaktür.Text = lstw_emlaktur.SelectedItems[0].SubItems[0].Text;
        }
        private void etbtn_temizle_Click(object sender, EventArgs e)
        {
            txt_emlaktür.Text = "";
        }
        private void EmlakTanimlamalar_Load(object sender, EventArgs e)
        {
            if (KullaniciGirisi.girisYapilanKullanici[2] == "Ziyaretci")
            {
                Program.ButonlarEnableAyarlama(this, false);
            }
            emlakOzellikTur();
            emlakDurum();
            emlakTur();

        }
        private void emlakTur()
        {
            StreamReader src = new StreamReader("emlakTur.txt");
            while (true)
            {
                string oku = src.ReadLine();
                if (oku == null)
                    break;
                lstw_emlaktur.Items.Add(oku);
            }
            src.Close();
        }
        private void emlakDurum()
        {
            StreamReader src = new StreamReader("emlakDurum.txt");
            while (true)
            {
                string oku = src.ReadLine();
                if (oku == null)
                    break;
                lstvw_emlakDurum.Items.Add(oku);
            }
            src.Close();
        }
        private void emlakOzellikTur()
        {
            StreamReader src = new StreamReader("mulksahibi.txt");
            while (true)
            {
                string oku = src.ReadLine();
                if (oku == null)
                    break;
                lstvw_mulks.Items.Add(oku);
            }
            src.Close();
        }

       
       

        

        

      

       

   
        

       

        

        

        

       
    
    }

}
