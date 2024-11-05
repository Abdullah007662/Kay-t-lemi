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
    public partial class YöneticiGiriş : Form
    {
        public YöneticiGiriş()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KI81GQD;Initial Catalog=PersonelKayıt;Integrated Security=True");
        private void GirişYap_Click(object sender, EventArgs e)
        {
            string KullanıcıAdı = Kullanıcıad.Text;
            string Şifre = kullanıcıŞifre.Text;
            baglanti.Open();
            SqlCommand Yönetici = new SqlCommand("select * from Tbl_Yönetici where  KullanıcıAdı=@s1 and Şifre=@s2",baglanti);
            Yönetici.Parameters.AddWithValue("@s1",KullanıcıAdı);
            Yönetici.Parameters.AddWithValue("@s2", Şifre);
            SqlDataReader Giriş = Yönetici.ExecuteReader();
            if (Giriş.Read())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifresi Hatalı");
            }

            baglanti.Close();

        }
    }
}
