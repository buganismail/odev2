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
    public partial class EmlakOzellik : Form
    {
        public EmlakOzellik()
        {
            InitializeComponent();
        }
        private void EmlakOzellik_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaSayfa anasayfa = (AnaSayfa)this.MdiParent;
            anasayfa.tsbtn_emlakOzellik.Enabled = true;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            bool varmi = false;
            foreach (ListViewItem item in lstvw_kullanici.Items)
            {
                if (item.SubItems[0].Text == tx_kad.Text)
                {
                    varmi = true;
                    break;
                }
            }
            if (varmi == true)
            {
                //MessageBox.Show("Bu T.C. Kimlik Numarası daha önce eklenmiş tekrar eklenemez !!!");
                MessageBox.Show(" Kullanıcı Adı  daha önce eklenmiş tekrar eklenemez !!!.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (cbx_yetki.SelectedIndex == -1 ||tx_kad.Text == "" || tx_sifre.Text == "")
            {

                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                ListViewItem item = new ListViewItem(new string[] { tx_kad.Text, tx_sifre.Text, cbx_yetki.SelectedItem.ToString() });
                StreamWriter sw = new StreamWriter("kullanici.txt", true);
                sw.WriteLine(tx_kad.Text+"-"+ tx_sifre.Text+"-"+ cbx_yetki.SelectedItem.ToString());
                sw.Close();
                lstvw_kullanici.Items.Add(item);
            }

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            if (lstvw_kullanici.SelectedItems.Count == 0)
            {
                MessageBox.Show("✖✖ Silinecek Kaydı Seçinizz ✖✖ ??.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            foreach (ListViewItem item in lstvw_kullanici.SelectedItems)
            {
                lstvw_kullanici.Items.Remove(item);
            }

            StreamWriter sw = new StreamWriter("kullanici.txt");
            foreach (ListViewItem item in lstvw_kullanici.Items)
            {
                sw.WriteLine(item.SubItems[0].Text + "-" + item.SubItems[1].Text + "-" + item.SubItems[2].Text );
            }
            sw.Close();
        }

        private void EmlakOzellik_Load(object sender, EventArgs e)
        {
            if (KullaniciGirisi.girisYapilanKullanici[2] == "Ziyaretci")
            {
                Program.ButonlarEnableAyarlama(this, false);

            }

            StreamReader sr = new StreamReader("kullanici.txt", Encoding.UTF8);
            while (true)
            {
                string oku = sr.ReadLine();
                if (oku == null)
                    break;
                string[] parca = oku.Split('-');

                lstvw_kullanici.Items.Add(new ListViewItem(new string []{parca[0], "****", parca[2]}));

         
           }
            sr.Close();

            StreamReader src = new StreamReader("yetki.txt");
            while (true)
            {
                string oku = src.ReadLine();
                if (oku == null)
                    break;
                cbx_yetki.Items.Add(oku);
            }
            src.Close();
            cbx_yetki.SelectedIndex = 0;
        
        
        
        }

        private void lstvw_kullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvw_kullanici.SelectedItems.Count == 0)
                return;
            tx_kad.Text = lstvw_kullanici.SelectedItems[0].SubItems[0].Text;
            tx_sifre.Text = lstvw_kullanici.SelectedItems[0].SubItems[1].Text;
            cbx_yetki.SelectedItem = lstvw_kullanici.SelectedItems[0].SubItems[2].Text;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (lstvw_kullanici.SelectedItems.Count == 0)
            {
                MessageBox.Show("✖✖ Güncellenecek Kaydı Seçinizz ✖✖ ??.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            lstvw_kullanici.SelectedItems[0].SubItems[0].Text = tx_kad.Text;
            lstvw_kullanici.SelectedItems[0].SubItems[1].Text = tx_sifre.Text;
            lstvw_kullanici.SelectedItems[0].SubItems[2].Text = cbx_yetki.SelectedItem.ToString();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_kad.Text = "";
            tx_sifre.Text = "";
            cbx_yetki.SelectedValue = 0;
        }


    }
}
