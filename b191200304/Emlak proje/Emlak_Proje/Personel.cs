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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        private void txt_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || e.KeyChar == '\b' || e.KeyChar == ' ')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_tcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Personel_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaSayfa anasayfa = (AnaSayfa)this.MdiParent;
            anasayfa.tsbtn_personel.Enabled = true;
        }
        
        private void Personel_Load(object sender, EventArgs e)
        {
            if (KullaniciGirisi.girisYapilanKullanici[2] == "Ziyaretci" || KullaniciGirisi.girisYapilanKullanici[2] == "Personel")
            {
                Program.ButonlarEnableAyarlama(this, false);
            }
            StreamReader src = new StreamReader("cinsiyet.txt");
            while (true)
            {
                string oku = src.ReadLine();
                if (oku == null)
                    break;
                cbx_cinsiyet.Items.Add(oku);
            }
            src.Close();
            cbx_cinsiyet.SelectedIndex = 0;
            StreamReader sr = new StreamReader("personel.txt",Encoding.UTF8);
            while (true)
            {
                string oku = sr.ReadLine();
                if (oku == null)
                    break;
                string[] parca = oku.Split('-');

                lstvw_personeller.Items.Add(new ListViewItem(parca));

            }
            sr.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)


        {


            bool varmi = false;
            foreach (ListViewItem item in lstvw_personeller.Items)
            {
                if (item.SubItems[2].Text == txt_tcNo.Text || item.SubItems[3].Text == txt_eposta.Text)
                {
                    varmi = true;
                    break;
                }
            }
            if (varmi == true)
            {
                //MessageBox.Show("Bu T.C. Kimlik Numarası daha önce eklenmiş tekrar eklenemez !!!");
                MessageBox.Show(" T.C. Kimlik Numarası Ya da E-posta  daha önce eklenmiş tekrar eklenemez !!!.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_ad.Text == "" || txt_soyad.Text == "" || txt_tcNo.Text == "" || txt_eposta.Text == "" || txt_telefon.Text == "" || cbx_cinsiyet.SelectedIndex == -1 || txt_adres.Text == "")
            {

                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                ListViewItem item = new ListViewItem(new string[] { txt_ad.Text, txt_soyad.Text, txt_tcNo.Text, txt_eposta.Text, txt_telefon.Text, cbx_cinsiyet.SelectedItem.ToString(),txt_adres.Text, dt_tarih.Value.ToString() });
                StreamWriter sw = new StreamWriter("personel.txt", true);
                sw.WriteLine(txt_ad.Text + "-" + txt_soyad.Text + "-" + txt_tcNo.Text + "-" + txt_eposta.Text + "-" + txt_telefon.Text + "-" + cbx_cinsiyet.SelectedItem.ToString() + "-" + txt_adres.Text + "-" + dt_tarih.Value.ToString());
                sw.Close();
                lstvw_personeller.Items.Add(item);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            if (lstvw_personeller.SelectedItems.Count == 0)
            {
                MessageBox.Show("✖✖ Silinecek Kaydı Seçinizz ✖✖ ??.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            foreach (ListViewItem item in lstvw_personeller.SelectedItems)
            {
                lstvw_personeller.Items.Remove(item);
            }
            listviewDosyayaz();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (lstvw_personeller.SelectedItems.Count == 0)
            {
                MessageBox.Show("✖✖ Güncellenecek Kaydı Seçinizz ✖✖ ??.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            lstvw_personeller.SelectedItems[0].SubItems[0].Text = txt_ad.Text;
            lstvw_personeller.SelectedItems[0].SubItems[1].Text = txt_soyad.Text;
            lstvw_personeller.SelectedItems[0].SubItems[2].Text = txt_tcNo.Text;
            lstvw_personeller.SelectedItems[0].SubItems[3].Text = txt_eposta.Text;
            lstvw_personeller.SelectedItems[0].SubItems[4].Text = txt_telefon.Text;
            lstvw_personeller.SelectedItems[0].SubItems[5].Text = cbx_cinsiyet.SelectedItem.ToString();
            lstvw_personeller.SelectedItems[0].SubItems[6].Text = txt_adres.Text;
            lstvw_personeller.SelectedItems[0].SubItems[7].Text = dt_tarih.Value.ToString();
        }
        void listviewDosyayaz()
        {
            StreamWriter sw = new StreamWriter("personel.txt");
            foreach (ListViewItem item in lstvw_personeller.Items)
            {
                sw.WriteLine(item.SubItems[0].Text + "-" + item.SubItems[1].Text + "-" + item.SubItems[2].Text + "-" + item.SubItems[3].Text + "-" + item.SubItems[4].Text + "-" + item.SubItems[5].Text + "-" + item.SubItems[6].Text + "-" + item.SubItems[7].Text);
            }
            sw.Close();
        }

        private void lstvw_personeller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvw_personeller.SelectedItems.Count == 0)
                return;
            txt_ad.Text = lstvw_personeller.SelectedItems[0].SubItems[0].Text;
            txt_soyad.Text = lstvw_personeller.SelectedItems[0].SubItems[1].Text;
            txt_tcNo.Text = lstvw_personeller.SelectedItems[0].SubItems[2].Text;
            txt_eposta.Text = lstvw_personeller.SelectedItems[0].SubItems[3].Text;
            txt_telefon.Text = lstvw_personeller.SelectedItems[0].SubItems[4].Text;
            cbx_cinsiyet.SelectedItem = lstvw_personeller.SelectedItems[0].SubItems[5].Text;
            txt_adres.Text = lstvw_personeller.SelectedItems[0].SubItems[6].Text;
            dt_tarih.Text = lstvw_personeller.SelectedItems[0].SubItems[7].Text;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_ad.Text = "";
            txt_soyad.Text = "";
            txt_tcNo.Text = "";
            txt_eposta.Text = "";
            txt_telefon.Text = "";
            cbx_cinsiyet.SelectedValue = 0;
            txt_adres.Text = "";
        }
        }
    }
