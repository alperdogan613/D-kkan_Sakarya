/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI:
** ÖĞRENCİ ADI: Ali Alper Doğan
** ÖĞRENCİ NUMARASI: B191200051
** DERSİN ALINDIĞI GRUP: A
****************************************************************************/

using System;
using System.Collections.Generic;                 
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;                  // Öncelikle sql kütüphanesini ekledim.
using System.Data.SqlClient;

namespace Ndp_proje
{
    public partial class Form2 : Form
    {
        public Form1 frm1;                   
        public string ad;
        public Form2()
        {
            frm1 = new Form1();
            InitializeComponent();           
            frm1.frm2 = this;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GM6TJ5BJ;Initial Catalog=Dükkan_Sakarya;Integrated Security=True");

                                                    // sql baglantimi yapiyorum.


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                long tel = Convert.ToInt64(textBoxTel.Text);                //siparis listesini olusturmak icin giris bilgilerini aliyorum.
                baglanti.Open();
                SqlCommand komut = baglanti.CreateCommand();
                komut.CommandText = "insert Siparisler (ad,soyad,telefon,adres) values  ('" + textBoxAd.Text + "','" + textBoxSoyad.Text + "','" + textBoxTel.Text + "','" + richTextBoxAdres.Text + "')  ";

                komut.ExecuteNonQuery();

                baglanti.Close();
                ad = textBoxAd.Text;

                frm1.ShowDialog();                                 // aynı zaman da try catch mekanizmalirini kurdum bos girildigin de uyari veriyor.
                this.Hide();                                       //hata yoksa devam formuna geciyorum.                


            }
            catch
            {
                MessageBox.Show("Bos alan birakmayiniz.");
            }

        }

    }
}
