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

namespace SoruBankasiUygulamasi
{
   
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        
        public Form1()
        {
            InitializeComponent();
        }
        void SoruGetir()
        {
            baglanti = new SqlConnection("Data Source=.;Initial Catalog=SoruHavuzu;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM SORULAR", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            //SoruGetir();
        }
        
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtSoruNumarasi.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //txtDersKodu.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox3.Text=dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoru.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtCevap.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                
                if(comboBox3.SelectedIndex != -1)
                {
                    string sorgu = "INSERT INTO Sorular(DersId,Soru,Cevap) VALUES (@DersId, @Soru, @Cevap)";
                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@DersId", Convert.ToInt32(comboBox3.Text));
                    komut.Parameters.AddWithValue("@Soru", txtSoru.Text);
                    komut.Parameters.AddWithValue("@Cevap", txtCevap.Text);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Ekleme işlemi başarılı");
                    baglanti.Close();
                    SoruGetir();
                }
                else
                {
                    MessageBox.Show("Ders kodu kısmı boş olamaz");
                    baglanti.Close();
                }                                                                         
            }
            catch(Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message);
                baglanti.Close();
            }           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoruNumarasi.Text != "")
                {
                    DialogResult secenek = MessageBox.Show("Kaydı veritabanından silmek istiyor musunuz?",
                    "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (secenek == DialogResult.Yes)
                    {
                        //Veritabanına kayıt ekleyen kodlar
                        string sorgu = "DELETE FROM Sorular WHERE SoruNumarasi=@SoruNumarasi";
                        komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@SoruNumarasi", Convert.ToInt32(txtSoruNumarasi.Text));
                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Silme işlemi başarılı");
                        baglanti.Close();
                        SoruGetir();
                    }
                    else if (secenek == DialogResult.No)
                    {
                        //Hayır seçeneğine tıklandığında çalıştırılacak kodlar
                        MessageBox.Show("Silme işlemi iptal edildi");
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz işlem. Silme işlemi için tablodan bir veri seçiniz.");
                }                                 
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message);
                baglanti.Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "UPDATE Sorular SET DersId=@DersId,Soru=@Soru,Cevap=@Cevap WHERE SoruNumarasi=@SoruNumarasi";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@SoruNumarasi", Convert.ToInt32(txtSoruNumarasi.Text));
                komut.Parameters.AddWithValue("@DersId", comboBox3.Text);
                komut.Parameters.AddWithValue("@Soru", txtSoru.Text);
                komut.Parameters.AddWithValue("@Cevap", txtCevap.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Güncelleme işlemi başarılı");
                baglanti.Close();
                SoruGetir();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message);
                baglanti.Close();
            }
        }

        private void pdfAktar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSoruUret_Click(object sender, EventArgs e)
        {
            try
            {
                int soru_Sayisi=Convert.ToInt32(numericUpDown1.Value);
                baglanti = new SqlConnection("Data Source=.;Initial Catalog=SoruHavuzu;Integrated Security=True");
                baglanti.Open();
                if (comboBox1.Text == "Android Programlamaya Giriş")
                {
                    da = new SqlDataAdapter("SELECT TOP " + soru_Sayisi + " * FROM SORULAR where DersId=1 Order by NEWID()", baglanti);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    /*
                    if (radioButton1.Checked == true)
                    {
                        da = new SqlDataAdapter("SELECT TOP "+ soru_Sayisi+" * FROM SORULAR where DersId=1 Order by NEWID()", baglanti);
                        DataTable tablo = new DataTable();
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                    }
                    else if (radioButton2.Checked == true)
                    {
                        da = new SqlDataAdapter("SELECT TOP 15 * FROM SORULAR where DersId=1 Order by NEWID()", baglanti);
                        DataTable tablo = new DataTable();
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                    }
                    else if (radioButton3.Checked == true)
                    {
                        da = new SqlDataAdapter("SELECT TOP 25 * FROM SORULAR where DersId=1 Order by NEWID()", baglanti);
                        DataTable tablo = new DataTable();
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                    }
                    */
                }
                else if (comboBox1.Text == "Bilgisayar Ağları ve Güvenliği")
                {
                    da = new SqlDataAdapter("SELECT TOP " + soru_Sayisi + " * FROM SORULAR where DersId=2 Order by NEWID()", baglanti);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    /*
                    if (radioButton1.Checked == true)
                    {
                        da = new SqlDataAdapter("SELECT TOP 7 * FROM SORULAR where DersId=2 Order by NEWID()", baglanti);
                        DataTable tablo = new DataTable();
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                    }
                    else if (radioButton2.Checked == true)
                    {
                        da = new SqlDataAdapter("SELECT TOP 15 * FROM SORULAR where DersId=2 Order by NEWID()", baglanti);
                        DataTable tablo = new DataTable();
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                    }
                    else if (radioButton3.Checked == true)
                    {
                        da = new SqlDataAdapter("SELECT TOP 25 * FROM SORULAR where DersId=2 Order by NEWID()", baglanti);
                        DataTable tablo = new DataTable();
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                    }
                    */
                }
                else if (comboBox1.Text == "Nesneye Dayalı Programlamaya Giriş")
                {
                    da = new SqlDataAdapter("SELECT TOP " + soru_Sayisi + " * FROM SORULAR where DersId=3 Order by NEWID()", baglanti);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    /*
                    if (radioButton1.Checked == true)
                    {
                        da = new SqlDataAdapter("SELECT TOP 7 * FROM SORULAR where DersId=3 Order by NEWID()", baglanti);
                        DataTable tablo = new DataTable();
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                    }
                    else if (radioButton2.Checked == true)
                    {
                        da = new SqlDataAdapter("SELECT TOP 15 * FROM SORULAR where DersId=3 Order by NEWID()", baglanti);
                        DataTable tablo = new DataTable();
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                    }
                    else if (radioButton3.Checked == true)
                    {
                        da = new SqlDataAdapter("SELECT TOP 25 * FROM SORULAR where DersId=3 Order by NEWID()", baglanti);
                        DataTable tablo = new DataTable();
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                    }
                    */
                }
                baglanti.Close();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message);
                baglanti.Close();
            }
            
        }

        private void btnMailGonder_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            txtSoruNumarasi.Clear();       
            txtSoru.Clear();
            txtCevap.Clear();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            SoruGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text == "Klasik")
            {

            }
        }

        private void btnClassicInsert_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}




