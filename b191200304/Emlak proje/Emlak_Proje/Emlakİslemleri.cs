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
    public partial class Emlakİslemleri : Form
    {
        public Emlakİslemleri()
        {
            InitializeComponent();
        }
        private void cbx_musteri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || e.KeyChar == '\b' || e.KeyChar == ' ')
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void cbx_personel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || e.KeyChar == '\b' || e.KeyChar == ' ')
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void txt_fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void Emlakİslemleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaSayfa anasayfa = (AnaSayfa)this.MdiParent;
            anasayfa.tsbtn_emlakislemleri.Enabled = true;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            //bool varmi = false;
            //foreach (ListViewItem item in lstvw_emlakislemleri.Items)
            //{
            //    if (item.SubItems[0].Text == cbx_emlakozellik.Text)
            //    {
            //        varmi = true;
            //        break;
            //    }
            //}
            //if (varmi == true)
            //{
            //    //MessageBox.Show("Bu T.C. Kimlik Numarası daha önce eklenmiş tekrar eklenemez !!!");
            //    MessageBox.Show(" Emlak Özellik Türü daha önce eklenmiş tekrar eklenemez !!!.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            if (cbx_emlakozellik.SelectedIndex == -1 ||  cbx_musteri.SelectedIndex == -1 || cbx_personel.SelectedIndex == -1 || txt_fiyat.Text == "")
            {

                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                ListViewItem item = new ListViewItem(new string[] { cbx_emlakozellik.SelectedItem.ToString() ,cbx_musteri.SelectedItem.ToString() , cbx_personel.SelectedItem.ToString(), txt_fiyat.Text , dt_tarih.Value.ToString() });
                StreamWriter sw = new StreamWriter("emlakislemleri.txt", true);
                sw.WriteLine(cbx_emlakozellik.SelectedItem.ToString() + "/" + cbx_musteri.SelectedItem.ToString() + "/" + cbx_personel.SelectedItem.ToString() + "/" + txt_fiyat.Text + "/" + dt_tarih.Value.ToString());
                sw.Close();
                lstvw_emlakislemleri.Items.Add(item);
            }
        }

        private void Emlakİslemleri_Load(object sender, EventArgs e)
        {
            if (KullaniciGirisi.girisYapilanKullanici[2] == "Ziyaretci")
            {
                Program.ButonlarEnableAyarlama(this, false);
            }
            StreamReader srm = new StreamReader("emlak.txt", Encoding.UTF8);
            while (true)
            {
                string oku = srm.ReadLine();
                if (oku == null)
                    break;
                string[] parca = oku.Split('-');

                cbx_emlakozellik.Items.Add(parca[0] + "#" + parca[1] + "#" + parca[2] + "#" + parca[3] );
            }
            srm.Close();
            cbx_emlakozellik.SelectedIndex = 0;
            StreamReader srmm = new StreamReader("musteri.txt", Encoding.UTF8);
            while (true)
            {
                string oku = srmm.ReadLine();
                if (oku == null)
                    break;
                string[] parca = oku.Split('-');

                cbx_musteri.Items.Add(parca[0]);
            }
            srmm.Close();
            cbx_musteri.SelectedIndex = 0;

            StreamReader sr = new StreamReader("personel.txt", Encoding.UTF8);
            while (true)
            {
                string oku = sr.ReadLine();
                if (oku == null)
                    break;
                string[] parca = oku.Split('-');

                cbx_personel.Items.Add(parca[0]);

            }
            sr.Close();
            cbx_personel.SelectedIndex = 0;

            StreamReader srme = new StreamReader("emlakislemleri.txt", Encoding.UTF8);
            while (true)
            {
                string oku = srme.ReadLine();
                if (oku == null)
                    break;
                string[] parca = oku.Split('/');

                lstvw_emlakislemleri.Items.Add(new ListViewItem(parca));
            }
            srme.Close();





        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            if (lstvw_emlakislemleri.SelectedItems.Count == 0)
            {
                MessageBox.Show("✖✖ Silinecek Kaydı Seçinizz ✖✖ ??.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            foreach (ListViewItem item in lstvw_emlakislemleri.SelectedItems)
            {
                lstvw_emlakislemleri.Items.Remove(item);
            }
            StreamWriter sw = new StreamWriter("emlakislemleri.txt");
            foreach (ListViewItem item in lstvw_emlakislemleri.Items)
            {
                sw.WriteLine(item.SubItems[0].Text + "/" + item.SubItems[1].Text + "/" + item.SubItems[2].Text + "/" + item.SubItems[3].Text + "/" + item.SubItems[4].Text );
            }
            sw.Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (lstvw_emlakislemleri.SelectedItems.Count == 0)
            {
                MessageBox.Show("✖✖ Güncellenecek  Kaydı Seçinizz ✖✖ ??.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                return;
            }


            lstvw_emlakislemleri.SelectedItems[0].SubItems[0].Text = cbx_emlakozellik.SelectedItem.ToString();

            lstvw_emlakislemleri.SelectedItems[0].SubItems[1].Text = cbx_musteri.SelectedItem.ToString();
            lstvw_emlakislemleri.SelectedItems[0].SubItems[2].Text = cbx_personel.SelectedItem.ToString();
            lstvw_emlakislemleri.SelectedItems[0].SubItems[3].Text = txt_fiyat.Text ;
            lstvw_emlakislemleri.SelectedItems[0].SubItems[4].Text =  dt_tarih.Value.ToString();
        }

        private void lstvw_emlakislemleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvw_emlakislemleri.SelectedItems.Count == 0)
                return;
            cbx_emlakozellik.SelectedItem = lstvw_emlakislemleri.SelectedItems[0].SubItems[0].Text;

            cbx_musteri.SelectedItem = lstvw_emlakislemleri.SelectedItems[0].SubItems[1].Text;
            cbx_personel.SelectedItem = lstvw_emlakislemleri.SelectedItems[0].SubItems[2].Text;
            txt_fiyat.Text = lstvw_emlakislemleri.SelectedItems[0].SubItems[3].Text;
            dt_tarih.Text = lstvw_emlakislemleri.SelectedItems[0].SubItems[4].Text;
        }

       

       
        
    }
}