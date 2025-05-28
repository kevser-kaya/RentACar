using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_a_car
{
    public partial class frmMusteriListele : Form
    {
        Araç_Kiralama arackiralama = new Araç_Kiralama();
        public frmMusteriListele()
        {
            InitializeComponent();
        }

        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            YenileListele();
        }

        private void YenileListele()
        {
            string cümle = "select *from müşteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "AD SOYAD";
            dataGridView1.Columns[2].HeaderText = "TELEFON";
            dataGridView1.Columns[3].HeaderText = "ADRES";
            dataGridView1.Columns[4].HeaderText = "E-MAIL";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select *from müşteri where TC like '%" + textBox1.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update müşteri set adsoyad=@adsoyad, telefon=@telefon, adres=@adres, email=@email where TC=@TC";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@TC", txtTc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@email", txtEmail.Text);
            arackiralama.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTc.Text = satır.Cells[0].Value.ToString();
            txtAdSoyad.Text = satır.Cells[1].Value.ToString();
            txtTelefon.Text = satır.Cells[2].Value.ToString();
            txtAdres.Text = satır.Cells[3].Value.ToString();
            txtEmail.Text = satır.Cells[4].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            DataGridViewRow satır = dataGridView1.CurrentRow;


            string plaka = "";
            string sorgu = "SELECT kiralanan_arac FROM müşteri WHERE TC='" + satır.Cells["TC"].Value.ToString() + "'";
            SqlDataAdapter adtr = new SqlDataAdapter();
            DataTable dt = arackiralama.listele(adtr, sorgu);

            if (dt.Rows.Count > 0)
            {
                plaka = dt.Rows[0]["kiralanan_arac"].ToString();
            }


            if (plaka != "")
            {
                string sorgu2 = "UPDATE araç SET durumu='BOŞ' WHERE plaka='" + plaka + "'";
                SqlCommand komut2 = new SqlCommand();
                arackiralama.ekle_sil_güncelle(komut2, sorgu2);
            }




            string cümle = "delete from müşteri where TC='" + satır.Cells["TC"].Value.ToString() + "'";
            SqlCommand komut3 = new SqlCommand();
            arackiralama.ekle_sil_güncelle(komut3, cümle);
            YenileListele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
