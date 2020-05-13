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
    public partial class KullaniciGirisi : Form
    {
        public KullaniciGirisi()
        {
            InitializeComponent();
        }
        public static string[] girisYapilanKullanici; 
        private void btn_giris_Click(object sender, EventArgs e)
        {
            bool giris = false;
            string yetki = "";
            StreamReader sr = new StreamReader("kullanici.txt");
            while (true)
            {
                string oku = sr.ReadLine();
                if (oku == null)
                    break;
                string[] parca = oku.Split('-');
                if (parca[0] == txt_kullaniciadi.Text && parca[1] == txt_sifre.Text)
                {
                    yetki = parca[2];
                    giris = true;
                    girisYapilanKullanici = oku.Split('-');
                    break;
                }
            }
            sr.Close();

            if (giris == true)
            {
                if (yetki == "Yonetici" || yetki == "Personel" || yetki == "Ziyaretci")
                {
                    AnaSayfa AnaSayfa = new AnaSayfa();
                    this.Hide();
                    AnaSayfa.kg = this;
                    AnaSayfa.Show();
                }
                else if (yetki == "Personel")
                {
                    AnaSayfa pfrm = new AnaSayfa();
                    this.Hide();
                    pfrm.kg = this;
                    pfrm.Show();
                }
                else
                    MessageBox.Show("Bilinmeyen bir yetki ile giriş yaptınız.");
            }
            else
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
        }

        private void KullaniciGirisi_Load(object sender, EventArgs e)
        {

        }
    }
}
