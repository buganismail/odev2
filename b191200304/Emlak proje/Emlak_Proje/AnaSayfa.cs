using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gorsel1_Emlak_Proje
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        private void tsbtn_personel_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            tsbtn_personel.Enabled = false;
            personel.MdiParent = this;
            personel.Show();
            //tsbtn_musteri.Enabled = true;
            //tsbtn_emlak.Enabled = true;
            //tsbtn_emlakislemleri.Enabled = true;
            //tsbtn_emlakOzellik.Enabled = true;
            //tsbtn_emlaktanimlamalar.Enabled = true;
        }
        private void tsbtn_musteri_Click(object sender, EventArgs e)
        {
            Musteri mfrm = new Musteri();
            tsbtn_musteri.Enabled = false;
            mfrm.MdiParent = this;
            mfrm.Show();
            //tsbtn_personel.Enabled = true;
            //tsbtn_emlak.Enabled = true;
            //tsbtn_emlakislemleri.Enabled = true;
            //tsbtn_emlakOzellik.Enabled = true;
            //tsbtn_emlaktanimlamalar.Enabled = true;
        }

        private void tsbtn_emlak_Click(object sender, EventArgs e)
        {
            Emlak emlak = new Emlak();
            tsbtn_emlak.Enabled = false;
            emlak.MdiParent = this;
            emlak.Show();
            //tsbtn_personel.Enabled = true;
            //tsbtn_emlakislemleri.Enabled = true;
            //tsbtn_emlakOzellik.Enabled = true;
            //tsbtn_musteri.Enabled = true;
            //tsbtn_emlaktanimlamalar.Enabled = true;
        }
        private void tsbtn_emlakislemleri_Click(object sender, EventArgs e)
        {
            Emlakİslemleri emlakislemleri = new Emlakİslemleri();
            tsbtn_emlakislemleri.Enabled = false;
            emlakislemleri.MdiParent = this;
            emlakislemleri.Show();
            //tsbtn_personel.Enabled = true;
            //tsbtn_emlak.Enabled = true;
            //tsbtn_emlakOzellik.Enabled = true;
            //tsbtn_musteri.Enabled = true;
            //tsbtn_emlaktanimlamalar.Enabled = true;
        }
        private void tsbtn_emlakOzellik_Click(object sender, EventArgs e)
        {
            EmlakOzellik emlakozellik = new EmlakOzellik();
            tsbtn_emlakOzellik.Enabled = false;
            emlakozellik.MdiParent = this;
            emlakozellik.Show();
            //tsbtn_personel.Enabled = true;
            //tsbtn_emlak.Enabled = true;
            //tsbtn_emlakislemleri.Enabled = true;
            //tsbtn_musteri.Enabled = true;
            //tsbtn_emlaktanimlamalar.Enabled = true;
        }

        private void tsbtn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtn_emlaktanimlamalar_Click(object sender, EventArgs e)
        {
            EmlakTanimlamalar emlakTanimlamalar = new EmlakTanimlamalar();
            tsbtn_emlaktanimlamalar.Enabled = false;
            emlakTanimlamalar.MdiParent = this;
            emlakTanimlamalar.Show();
            //tsbtn_musteri.Enabled = true;
            //tsbtn_emlak.Enabled = true;
            //tsbtn_emlakislemleri.Enabled = true;
            //tsbtn_emlakOzellik.Enabled = true;
            //tsbtn_personel.Enabled = true;
        }
        public KullaniciGirisi kg;
      

        private void AnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            if (KullaniciGirisi.girisYapilanKullanici[2] == "Ziyaretci" || KullaniciGirisi.girisYapilanKullanici[2] == "Personel")
            {
                Program.ButonlarEnableAyarlama(this, false);
            }
        }

      
    }
}
