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
using System.Reflection;

namespace Kayıt_İşlemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KI81GQD;Initial Catalog=PersonelKayıt;Integrated Security=True");
        void temizle()
        {
            txtMeslek.Text = "";
            txtmskmaaş.Text = "";
            textBoxAd.Text = "";
            textBoxSoyad.Text = "";
            TXTŞehir.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBoxAd.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelKayıtDataSet1.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter1.Fill(this.personelKayıtDataSet1.Tbl_Personel);


        }

        private void Listele_Click(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'personelKayıtDataSet1.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter1.Fill(this.personelKayıtDataSet1.Tbl_Personel);
        }

        public void Kaydet_Click(object sender, EventArgs e)
        {
            string ad = textBoxAd.Text;
            string soyad = textBoxSoyad.Text;
            string sehir = TXTŞehir.Text;
            int maas;
            string meslek = txtMeslek.Text;
            string durum = label8.Text;
            int id = int.Parse(textid.Text);

            // Maaşın doğru bir şekilde alındığından emin olun
            if (int.TryParse(txtmskmaaş.Text, out maas))
            {
                try
                {
                    baglanti.Open();

                    SqlCommand ekle = new SqlCommand("insert into Tbl_Personel (PerAd, PerSoyad, PerŞehir, PerMaaş,PerMeslek,PerDurum) values (@p1, @p2, @p3, @p4,@p5,@p6,@p7)", baglanti);
                    ekle.Parameters.AddWithValue("@p7",id);
                    ekle.Parameters.AddWithValue("@p1", ad);
                    ekle.Parameters.AddWithValue("@p2", soyad);
                    ekle.Parameters.AddWithValue("@p3", sehir);
                    ekle.Parameters.AddWithValue("@p4", maas);
                    ekle.Parameters.AddWithValue("@p5", meslek);
                    ekle.Parameters.AddWithValue("@p6",durum);
                    ekle.ExecuteNonQuery();

                    MessageBox.Show("Personel Eklendi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir maaş girin.");
            }




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTŞehir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtmskmaaş_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (label8.Text == "False")
            {
                radioButton2.Checked = false;
            }

        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        public void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBoxAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TXTŞehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtmskmaaş.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            


        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;

            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = false;
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            object İD = textid.Text;
            baglanti.Open();
            SqlCommand sil = new SqlCommand("Delete From Tbl_Personel where PerİD=@k1",baglanti);
            sil.Parameters.AddWithValue("@k1",İD);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
        }

        public void Güncelle_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand Güncelle = new SqlCommand("Update Tbl_Personel Set PerAd=@g1,PerSoyad=@g2,PerŞehir=@g3,PerMaaş=@g4,PerDurum=@g5,PerMeslek=@g6 where PerİD=@g7");
            Güncelle.Parameters.AddWithValue("@g1",textid);
            Güncelle.Parameters.AddWithValue("@g2", textBoxSoyad.Text);
            Güncelle.Parameters.AddWithValue("@g3", TXTŞehir.Text);
            Güncelle.Parameters.AddWithValue("@g4", txtmskmaaş.Text);
            Güncelle.Parameters.AddWithValue("@g5", label8.Text);
            Güncelle.Parameters.AddWithValue("@g6", txtMeslek.Text);
            Güncelle.Parameters.AddWithValue("@g7", textid.Text);
            Güncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        private void İstatistik_Click(object sender, EventArgs e)
        {
            Formİstatistik Fr = new Formİstatistik();
            Fr.Show();
        }

        private void Grafikler_Click(object sender, EventArgs e)
        {
            FormGRafik Grafik = new FormGRafik();
            Grafik.Show();
        }
    }
}
