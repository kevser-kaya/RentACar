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

namespace Rent_a_car
{
    public partial class KullaniciFormu : Form
    {
        Araç_Kiralama Araç_Kiralama = new Araç_Kiralama();
        public KullaniciFormu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen kiralamak için bir araç seçin.");
                return;
            }

            string plaka = dataGridView1.SelectedRows[0].Cells["plaka"].Value.ToString();
            string musteriTC = Microsoft.VisualBasic.Interaction.InputBox("Lütfen TC kimlik numaranızı girin:", "Müşteri Bilgisi", "");

            if (musteriTC == "") return;
            //
            string adsoyad = Microsoft.VisualBasic.Interaction.InputBox("Ad Soyad:", "Müşteri Bilgisi", "");
            string telefon = Microsoft.VisualBasic.Interaction.InputBox("Telefon:", "Müşteri Bilgisi", "");
            string adres = Microsoft.VisualBasic.Interaction.InputBox("Adres:", "Müşteri Bilgisi", "");
            string email = Microsoft.VisualBasic.Interaction.InputBox("Email:", "Müşteri Bilgisi", "");
            string kiralamaTarihi = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string cümle = @"
           IF NOT EXISTS (SELECT * FROM müşteri WHERE TC = @TC)
            BEGIN
        INSERT INTO müşteri (TC, adsoyad, telefon, adres, email, kiralama_tarihi) 
        VALUES (@TC, @adsoyad, @telefon, @adres, @email, @kiralama_tarihi)
        END";
            SqlCommand Komut2 = new SqlCommand();
            Komut2.Parameters.AddWithValue("@TC", musteriTC);
            Komut2.Parameters.AddWithValue("@adsoyad", adsoyad);
            Komut2.Parameters.AddWithValue("@telefon", telefon);
            Komut2.Parameters.AddWithValue("@adres", adres);
            Komut2.Parameters.AddWithValue("@email", email);
            Komut2.Parameters.AddWithValue("@kiralama_tarihi", kiralamaTarihi);
            Araç_Kiralama.ekle_sil_güncelle(Komut2, cümle);



            string cümle2 = "UPDATE araç SET durumu = 'DOLU' WHERE plaka = @plaka";
            SqlCommand komut3 = new SqlCommand();
            komut3.Parameters.AddWithValue("@plaka", plaka);
            Araç_Kiralama.ekle_sil_güncelle(komut3, cümle2);

            string cümle3 = "UPDATE müşteri SET kiralanan_arac = @plaka WHERE TC = @TC";
            SqlCommand komut4 = new SqlCommand();
            komut4.Parameters.AddWithValue("@plaka", plaka);
            komut4.Parameters.AddWithValue("@TC", musteriTC);
            Araç_Kiralama.ekle_sil_güncelle(komut4, cümle3);


            MessageBox.Show("Araç başarıyla kiralandı.");



            btnListele.PerformClick();
        }

        private void KullaniciFormu_Load(object sender, EventArgs e)
        {

        }


       


        private void btnListele_Click(object sender, EventArgs e)
        {

            string cümle = "SELECT plaka, marka, seri, yil, renk, km, yakit, kiraucreti, tarih FROM araç WHERE durumu = 'BOŞ'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = Araç_Kiralama.listele(adtr2, cümle); ;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            string plaka = dataGridView1.CurrentRow.Cells["plaka"].Value.ToString();

           
            Araç_Kiralama arac_Kiralama = new Araç_Kiralama();

            string sorgu = $"SELECT resim, resim2, resim3 FROM araç WHERE plaka = '{plaka}'";

            SqlDataAdapter adapter = null;
            DataTable dt = arac_Kiralama.listele(adapter, sorgu);

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        string resimYolu = row[i].ToString();
                        if (!string.IsNullOrEmpty(resimYolu) && System.IO.File.Exists(resimYolu))
                        {
                            PictureBox pb = new PictureBox();
                            pb.Image = Image.FromFile(resimYolu);
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            pb.Width = 120;
                            pb.Height = 80;
                            pb.Margin = new Padding(5);
                            flowLayoutPanel1.Controls.Add(pb);
                        }
                    }
                }
            }
        }
    }
}
