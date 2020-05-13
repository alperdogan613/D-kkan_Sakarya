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
using System.Windows.Forms;
using System.Data.SqlClient;                                              //sql kütüphanemi ekleyerek devam ediyorum
namespace Ndp_proje
{
    public partial class Form1 : Form
    {

        public Form2 frm2;                                                 //formlar arasında veri tasimak icin baglantilarimi yapiyorum.
        public Form3 frm3;



        public Form1()
        {
            
            InitializeComponent();                                                                

        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GM6TJ5BJ;Initial Catalog=Dükkan_Sakarya;Integrated Security=True");
        
        int SepetTutari;                                        //sepet kismimi kodluyorum.Sayaclar ve sepet tutari
        public int frmsayac = 0;
        public int mamasayac = 0;
        public int biltsayac = 0;                              //ilk degerleri sifir olacagindan global alanda islemlerimi yapiyorum.

        private void Form1_Load(object sender, EventArgs e)
        {
            Enabled = true;                                   //"Dükkan_Sakarya" yazisini döndürme islemi burda gerceklesiyor.(devami timer click de )
            timerzamanlayici.Enabled = true;
            LblBaslik.Text = "     Dükkan Sakarya ";
        }

        public void Hesapla()
        {
            Urunler urn = new Urunler();

            urn.formasayisi =Convert.ToInt32(comboBoxforma.Text);                    // kod fazlalaligi olmamasi icin hesapla diye bir metod olusturuyorum.
            urn.biletsayisi = Convert.ToInt32(comboboxbilet.Text);
            urn.mamasayisi = Convert.ToInt32(comboBoxmama.Text);

            Sayi_urunler syi = new Sayi_urunler();                                   //sayaclarimi saydirip string e dönüstürüp sepetteki yerlerine atiyorum.
            syi.formasayac += urn.formasayisi;
            frmsayac += syi.formasayac;
            syi.biletsayac += urn.biletsayisi;
            biltsayac += syi.biletsayac;
            syi.mamasayac += urn.mamasayisi;
            mamasayac += syi.mamasayac;

            
            lblForma.Text = urn.formasayisi.ToString();
            lblBilet.Text = urn.biletsayisi.ToString();
            lblMama.Text = urn.mamasayisi.ToString();


            if (urn.formasayisi >= 0 && urn.biletsayisi >= 0 && urn.mamasayisi >= 0)
            {
                SepetTutari = (urn.formasayisi * 54) + (urn.biletsayisi * 10) + (urn.mamasayisi * 5);
                lbltutar.Text = SepetTutari.ToString()+" TL";
            }
            else
            {
                MessageBox.Show("Pozitif Değer Girmelisiniz.");        // kapsülleme kullanip negatif girilirse 
            }                                                          //math.abs den direk potife cevirecektim ama bu daha kısa ve yararli oldu.
        }

        public string x;
        
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = baglanti.CreateCommand();
            komut.CommandText = "UPDATE Siparisler SET forma='" + comboBoxforma.Text + "'  , kopek_mamasi='" + comboBoxmama.Text + "' , mac_bilet='" + comboboxbilet.Text + "' where ad='" + frm2.ad+ "' ";
            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Siparişiniz alındı,siparişler bölümünden kontrol edebilirsiniz.");     // satilan ürün sayimi burda saydiriyorum ve kullaniciyi devamındaki forma yönlendiriyorum.

            
        }       
        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();         // kullanici siparisler sayfasina yönlendiriliyor.



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxforma_FormatStringChanged(object sender, EventArgs e)
        {
            
        }

                                                                                          //hesapla metodumu cagirip islemlerimi yaptiriyorum.
        private void comboBoxmama_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void comboBoxforma_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void comboboxbilet_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void timerzamanlayici_Tick(object sender, EventArgs e)
        {
            LblBaslik.Text = LblBaslik.Text.Substring(1) + LblBaslik.Text.Substring(0, 1);

        }
    }
}
