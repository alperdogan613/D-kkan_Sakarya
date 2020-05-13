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
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ndp_proje
{
    public partial class Form3 : Form
    {
       
        SqlConnection baglanti1 = new SqlConnection("Data Source=LAPTOP-GM6TJ5BJ;Initial Catalog=Dükkan_Sakarya;Integrated Security=True");
        DataSet daset = new DataSet();
        public Form3()
        {
           
          
            InitializeComponent();
        }
 
        private void Form3_Load(object sender, EventArgs e)
        {
            baglanti1.Open();
            SqlDataAdapter data = new SqlDataAdapter("select *from Siparisler", baglanti1);
            data.Fill(daset, "Siparisler");
            dataGridView1.DataSource = daset.Tables["Siparisler"];                             //siparisler kismina sqlden aldigim verileri gönderiyorum.
            baglanti1.Close();
            Enabled = true;
            timerzamanliyicim.Enabled = true;
            lblbaslikk.Text = "     Dükkan Sakarya ";

            metod();
        }

        private void metod()
        {
            baglanti1.Open();
            SqlCommand komut = baglanti1.CreateCommand();                               //bir metod daha olusturup.-
            SqlDataReader dtr;                                                           ////toplam sattigimiz ürün sayilarini burda sqlden cekip labellarima atiyorum.
            komut.CommandText = "select sum(forma) from Siparisler";
            lblForma.Text = komut.ExecuteScalar()+" adet";
            komut.CommandText = "select sum(kopek_mamasi) from Siparisler";           
            lblMama.Text = komut.ExecuteScalar() + " adet";
            komut.CommandText = "select sum(mac_bilet) from Siparisler";
            lblBilet.Text = komut.ExecuteScalar() + " adet";


           
            baglanti1.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            
        
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblbaslikk.Text = lblbaslikk.Text.Substring(1) + lblbaslikk.Text.Substring(0, 1);  
        }
    }
}
