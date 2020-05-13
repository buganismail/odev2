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
    public partial class Emlak : Form
    {
        public Emlak()
        {
            InitializeComponent();
        }
        private void txt_fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void Emlak_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaSayfa anasayfa = (AnaSayfa)this.MdiParent;
            anasayfa.tsbtn_emlak.Enabled = true;
        }
        private void Emlak_Load(object sender, EventArgs e)
        {
            if (KullaniciGirisi.girisYapilanKullanici[2] == "Ziyaretci")
            {
                Program.ButonlarEnableAyarlama(this, false);
            }
            StreamReader sr = new StreamReader("durum.txt");
            while (true)
            {
                string oku = sr.ReadLine();
                if (oku == null)
                    break;
                cbx_durum.Items.Add(oku);
            }
            sr.Close();
            cbx_durum.SelectedIndex = 0;

            StreamReader swr = new StreamReader("emlakTur.txt");
            while (true)
            {
                string oku = swr.ReadLine();
                if (oku == null)
                    break;
                cbx_emlaktürü.Items.Add(oku);
            }
            swr.Close();
            cbx_emlaktürü.SelectedIndex = 0;

            StreamReader sre = new StreamReader("emlak.txt", Encoding.UTF8);
            while (true)
            {
                string oku = sre.ReadLine();
                if (oku == null)
                    break;
                string[] parca = oku.Split('-');

                lstvw_emlak.Items.Add(new ListViewItem(parca));
            }
            sre.Close();




            StreamReader srm = new StreamReader("mulksahibi.txt", Encoding.UTF8);
            while (true)
            {
                string oku = srm.ReadLine();
                if (oku == null)
                    break;
                string[] parca = oku.Split('-');

                cbx_mulks.Items.Add(parca[0]);
            }
            srm.Close();
            cbx_mulks.SelectedIndex = 0;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //bool varmi = false;
            //foreach (ListViewItem item in lstvw_emlak.Items)
            //{
            //    if (item.SubItems[1].Text == cbx_durum.Text || item.SubItems[2].Text == cbx_emlaktürü.Text || item.SubItems[4].Text == cbx_mulks.Text)
            //    {
            //        varmi = true;
            //        break;
            //    }
            //}
            //if (varmi == true)
            //{

            //    MessageBox.Show("Durumu , Emlak türü ya da Mülk Sahibi  daha önce eklenmiş tekrar eklenemez !!!.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
         
            
            
            //else
                if (txt_slogan.Text == "" || cbx_durum.SelectedIndex == -1 || cbx_emlaktürü.SelectedIndex == -1 || txt_fiyat.Text == "" || cbx_mulks.SelectedIndex == -1||txt_adres.Text == "")
            {

                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                ListViewItem item = new ListViewItem(new string[] { txt_slogan.Text, cbx_durum.SelectedItem.ToString(), cbx_emlaktürü.SelectedItem.ToString(), txt_fiyat.Text, cbx_mulks.SelectedItem.ToString(), txt_adres.Text });
                StreamWriter sw = new StreamWriter("emlak.txt", true);
                sw.WriteLine(txt_slogan.Text + "-" + cbx_durum.SelectedItem.ToString() + "-" + cbx_emlaktürü.SelectedItem.ToString() + "-" + txt_fiyat.Text + "-" + cbx_mulks.SelectedItem.ToString() + "-" + txt_adres.Text);
                sw.Close();
                lstvw_emlak.Items.Add(item);
            }
           
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (lstvw_emlak.SelectedItems.Count == 0)
            {
                MessageBox.Show("✖✖ Silinecek Kaydı Seçinizz ✖✖ ??.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            foreach (ListViewItem item in lstvw_emlak.SelectedItems)
            {
                lstvw_emlak.Items.Remove(item);
            }

            StreamWriter sw = new StreamWriter("emlak.txt",true);
            foreach (ListViewItem item in lstvw_emlak.Items)
            {
                sw.WriteLine(item.SubItems[0].Text + "#" + item.SubItems[1].Text + "#" + item.SubItems[2].Text + "#" + item.SubItems[3].Text + "#" + item.SubItems[4].Text + "#" + item.SubItems[5].Text);
            }
            sw.Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (lstvw_emlak.SelectedItems.Count == 0)
            {
                MessageBox.Show("✖✖ Güncellenecek Kaydı Seçinizz ✖✖ ??.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            lstvw_emlak.SelectedItems[0].SubItems[0].Text = txt_slogan.Text;
            lstvw_emlak.SelectedItems[0].SubItems[1].Text = cbx_durum.SelectedItem.ToString() ;
            lstvw_emlak.SelectedItems[0].SubItems[2].Text = cbx_emlaktürü.SelectedItem.ToString(); 
            lstvw_emlak.SelectedItems[0].SubItems[3].Text = txt_fiyat.Text;
            lstvw_emlak.SelectedItems[0].SubItems[4].Text = cbx_mulks.SelectedItem.ToString();
            lstvw_emlak.SelectedItems[0].SubItems[5].Text = txt_adres.Text;
        }

        private void lstvw_emlak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvw_emlak.SelectedItems.Count == 0)
                return;
            txt_slogan.Text = lstvw_emlak.SelectedItems[0].SubItems[0].Text;

            cbx_durum.SelectedItem = lstvw_emlak.SelectedItems[0].SubItems[1].Text;
            cbx_emlaktürü.SelectedItem = lstvw_emlak.SelectedItems[0].SubItems[2].Text;
            txt_fiyat.Text = lstvw_emlak.SelectedItems[0].SubItems[3].Text;
            cbx_mulks.SelectedItem = lstvw_emlak.SelectedItems[0].SubItems[4].Text;
            txt_adres.Text = lstvw_emlak.SelectedItems[0].SubItems[5].Text;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_slogan.Text = "";
            cbx_emlaktürü.SelectedValue = -1;
            cbx_durum.SelectedValue = -1;
            cbx_mulks.SelectedValue = -1;
            txt_fiyat.Text = "";
            txt_adres.Text = "";
        }

       
    }
}
