/****************************************************************************
**                      SAKARYA ÜNİVERSİTESİ
**             BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**               BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                  NESNEYE DAYALI PROGRAMLAMA DERSİ
**                      2019-2020 BAHAR DÖNEMİ
**
**               ÖDEV NUMARASI..........: 1
**               ÖĞRENCİ ADI............: İsmail Buğan
**               ÖĞRENCİ NUMARASI.......: B191200304
**               DERSİN ALINDIĞI GRUP...: 
****************************************************************************/

using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox1_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }  // TextBox'a sadece sayı girişi yapılması için dışarıdan alınmış kod parçacığı
          //  NOT: Bu kod uyku-yemek-diger parametrelerindeki tüm textBox'lar için yapılmıştır.
         //   Tümü seçilip KeyPress ten açılan sadece 1 parametre içerisine yazılmıştır.
            
        // Uyku Düzeni TextBox'ları
        private void textBox1_Leave(object sender, EventArgs e)   // Saat TextBox'ı
        {
            try
            {   // Sadece Saat aralığını (0-23) kabul ediyor 
                if (Convert.ToInt32(textBox1.Text) < 0 || Convert.ToInt32(textBox1.Text) > 23)
                {
                    MessageBox.Show("Değer 0-23 arasında olmalı");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
            }
            catch
            {   // Boş değer girilmesi durumunda uyarı veriliyor.
                MessageBox.Show("Sayısal bir değer girin");
                textBox1.Text = "";
                textBox1.Focus();
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)  // Dakika TextBox'ı
        {
            try
            {   // Sadece Dakika aralığını (0-59) kabul ediyor 
                if (Convert.ToInt32(textBox2.Text) < 0 || Convert.ToInt32(textBox2.Text) > 59)
                {
                    MessageBox.Show("Değer 0-59 arasında olmalı");
                    textBox2.Text = "";
                    textBox2.Focus();
                }
            }
            catch
            {   // Boş değer girilmesi durumunda uyarı veriliyor.
                MessageBox.Show("Sayısal bir değer girin");
                textBox2.Text = "";
                textBox2.Focus();
            }
        }

        // Yemek Saati TextBox'ları
        private void textBox5_Leave(object sender, EventArgs e)  // Saat TextBox'ı
        {
            try
            {   // Sadece Saat aralığını (0-23) kabul ediyor
                if (Convert.ToInt32(textBox5.Text) < 0 || Convert.ToInt32(textBox5.Text) > 23)
                {
                    MessageBox.Show("Değer 0-23 arasında olmalı");
                    textBox5.Text = "";
                    textBox5.Focus();
                }
            }
            catch
            {   // Boş değer girilmesi durumunda uyarı veriliyor.
                MessageBox.Show("Sayısal bir değer girin");
                textBox5.Text = "";
                textBox5.Focus();
            }
        }
        private void textBox6_Leave(object sender, EventArgs e)  // Dakika TextBox'ı
        {
            try
            {   // Sadece Dakika aralığını (0-59) kabul ediyor 
                if (Convert.ToInt32(textBox6.Text) < 0 || Convert.ToInt32(textBox6.Text) > 59)
                {
                    MessageBox.Show("Değer 0-59 arasında olmalı");
                    textBox6.Text = "";
                    textBox6.Focus();
                }
            }
            catch
            {   // Boş değer girilmesi durumunda uyarı veriliyor.
                MessageBox.Show("Sayısal bir değer girin");
                textBox6.Text = "";
                textBox6.Focus();
            }
        }

        // Diğer (eğlence vb.) TextBox'ları
        private void textBox7_Leave(object sender, EventArgs e)  // Saat TextBox'ı
        {
            try
            {   // Sadece Saat aralığını (0-23) kabul ediyor
                if (Convert.ToInt32(textBox7.Text) < 0 || Convert.ToInt32(textBox7.Text) > 23)
                {
                    MessageBox.Show("Değer 0-23 arasında olmalı");
                    textBox7.Text = "";
                    textBox7.Focus();
                }
            }
            catch
            {   // Boş değer girilmesi durumunda uyarı veriliyor.
                MessageBox.Show("Sayısal bir değer girin");
                textBox7.Text = "";
                textBox7.Focus();
            }
        }
        private void textBox8_Leave(object sender, EventArgs e)  // Dakika TextBox'ı
        {
            try
            {   // Sadece Dakika aralığını (0-59) kabul ediyor 
                if (Convert.ToInt32(textBox8.Text) < 0 || Convert.ToInt32(textBox8.Text) > 59)
                {
                    MessageBox.Show("Değer 0-59 arasında olmalı");
                    textBox8.Text = "";
                    textBox8.Focus();
                }
            }
            catch
            {   // Boş değer girilmesi durumunda uyarı veriliyor.
                MessageBox.Show("Sayısal bir değer girin");
                textBox8.Text = "";
                textBox8.Focus();
            }
        }
        

        private void button1_Click_1(object sender, EventArgs e)    // Hesapla Butonu
        {
            

            Form2 f2 = new Form2(); //Butona tıklayınca Form2'nin açılmasını sağlayan kod
            f2.ShowDialog();

            
           
            // Toplam harcanan vakitler dakikaya çevirilerek int değerlere atanıyor.
            int uyku = (Convert.ToInt32(textBox1.Text) * 60) + Convert.ToInt32(textBox2.Text);  
            
            int yemek = (Convert.ToInt32(textBox5.Text) * 60) + Convert.ToInt32(textBox6.Text); 
            int diger = (Convert.ToInt32(textBox7.Text) * 60) + Convert.ToInt32(textBox8.Text);

            int harcanan_vakit = uyku + yemek + diger;  // Toplam harcanan süreyi hesaplıyor.
            int bos_vakit = 1440 - harcanan_vakit;     //  Kalan boş vakit hesaplanıyor.

            if (bos_vakit < 0)  // Kullanıcının girdiği değerler 24 saatten fazla olursa uyarı verecek kısım
            {
                MessageBox.Show("Değerleriniz 24 saati geçmektedir.Lütfen değerleri düzgün giriniz");
                
            }
            else if(bos_vakit % 50 != 0)  
            {
                MessageBox.Show(bos_vakit % 50 + " dakikada benden sana izin olsun.Hadi yine iyisin ;)");   
                // Boş vakitte ders saatini ayırdıktan sonra kalan sayıyı hediye olarak teneffüs ilan eden kısım. Mizahı unutmamak lazım :)

                textBox3.Text = (bos_vakit/60).ToString();    // Boş vaktin saatini,
                textBox4.Text = (bos_vakit % 60).ToString();  // Boş vaktin dakikasını gösteren kısım

            }
                
            int ders_sayisi = bos_vakit / 50;           // Boş saatin içinde 40 dk lık ders sayısını bulma
            textBox9.Text = ders_sayisi.ToString();     // Ders sayısını yazıyor.
            
        }
    }
}
