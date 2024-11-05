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


namespace Kayıt_İşlemi
{
    public partial class FormGRafik : Form
    {
        public FormGRafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KI81GQD;Initial Catalog=PersonelKayıt;Integrated Security=True");

        private void chart1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand Grafikler = new SqlCommand("select Perşehir,Count (*) from Tbl_Personel group by PerŞehir",baglanti);
            SqlDataReader grafik = Grafikler.ExecuteReader();
            while (grafik.Read())
            {
                chart1.Series["Şehirler"].Points.AddXY(grafik[0], grafik[1]);
            }
            baglanti.Close();

            
        }

        private void chart2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand Grafik2 = new SqlCommand("select PerMeslek,Avg(PerMaaş) from Tbl_Personel group by PerMeslek",baglanti);
            SqlDataReader g2 = Grafik2.ExecuteReader();
            while (g2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(g2[0], g2[1]);
            }
            baglanti.Close();
        }
    }
}
