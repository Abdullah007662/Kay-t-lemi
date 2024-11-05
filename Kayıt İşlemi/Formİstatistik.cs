using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kayıt_İşlemi
{
    public partial class Formİstatistik : Form
    {
        public Formİstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KI81GQD;Initial Catalog=PersonelKayıt;Integrated Security=True");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Formİstatistik_Load(object sender, EventArgs e)
        {
            #region  Toplam Personel Sayısı
            baglanti.Open();
            SqlCommand Toplam_Personel = new SqlCommand("select Count(*) From Tbl_Personel",baglanti);
            SqlDataReader Tpl = Toplam_Personel.ExecuteReader();
            while(Tpl.Read())
            {
                Toplam.Text = Tpl[0].ToString();
                
            }
            baglanti.Close();
            #endregion
            #region Evli Personel Sayısı
            baglanti.Open();
            SqlCommand Evli_Personel = new SqlCommand("select Count(*) From Tbl_Personel where PerDurum=1", baglanti);
            SqlDataReader evliper = Evli_Personel.ExecuteReader();
            while (evliper.Read())
            {
                Evli.Text = evliper[0].ToString();
            }
            baglanti.Close();
            #endregion
            #region Bekar Personel Sayısı
            baglanti.Open();
            SqlCommand Bekar_Personel = new SqlCommand("select Count(*) From Tbl_Personel where PerDurum=0",baglanti);
            SqlDataReader BekarPer = Bekar_Personel.ExecuteReader();
            while (BekarPer.Read())
            {
                Bekar.Text = BekarPer[0].ToString();
            }
            baglanti.Close();
            #endregion
            #region Şehir Sayısı
            baglanti.Open();
            SqlCommand sehir = new SqlCommand("select Count(distinct(PerŞehir)) from Tbl_Personel",baglanti);
            SqlDataReader sehirsayısı = sehir.ExecuteReader();
            while (sehirsayısı.Read())
            {
                TXeTŞehir.Text = sehirsayısı[0].ToString();
            }
            baglanti.Close();



            #endregion
            #region Toplam Maaş
            baglanti.Open();
            SqlCommand TopMaas = new SqlCommand("select Sum(PerMaaş) from Tbl_Personel",baglanti);
            SqlDataReader maas = TopMaas.ExecuteReader();
            while (maas.Read())
            {
                TplMaas.Text = maas[0].ToString();
            }
            baglanti.Close();
            #endregion
            #region Maaş Ortalaması
            baglanti.Open();
            SqlCommand ortmaas = new SqlCommand("select Avg(PerMaaş) from Tbl_Personel",baglanti);
            SqlDataReader ortalamamaas = ortmaas.ExecuteReader();
            while (ortalamamaas.Read())
            {
                Ort_Maaş.Text = ortalamamaas[0].ToString();
            }
            baglanti.Close();

            #endregion


        }
    }
}