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
    public partial class frmAraçListele : Form
    {
        Araç_Kiralama arackiralama = new Araç_Kiralama();
        public frmAraçListele()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            DataGridViewRow satır1 = dataGridView1.CurrentRow;

            string[] resimKolonlari = { "resim", "resim2", "resim3" };

            foreach (string kolon in resimKolonlari)
            {
                if (satır1.Cells[kolon].Value != DBNull.Value)
                {
                    string resimYolu = satır1.Cells[kolon].Value.ToString();
                    if (!string.IsNullOrEmpty(resimYolu) && File.Exists(resimYolu))
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

            DataGridViewRow satır = dataGridView1.CurrentRow;
            Plakatxt.Text = satır.Cells["plaka"].Value.ToString();
            Markacombo.Text = satır.Cells["marka"].Value.ToString();
            Sericombo.Text = satır.Cells["seri"].Value.ToString();
            Yiltxt.Text = satır.Cells["yil"].Value.ToString();
            Renktxt.Text = satır.Cells["renk"].Value.ToString();
            Kmtxt.Text = satır.Cells["km"].Value.ToString();
            Yakitcombo.Text = satır.Cells["yakit"].Value.ToString();
            Ücrettxt.Text = satır.Cells["kiraucreti"].Value.ToString();
            Durumcombo.Text = satır.Cells["durumu"].Value.ToString();
        }

        private void frmAraçListele_Load(object sender, EventArgs e)
        {
            YenileAraçlarListesi();
            comboAraçlar.SelectedIndex = 0;
        }

        private void YenileAraçlarListesi()
        {
            string cümle = "select *from araç";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
        }
        List<string> secilenResimler = new List<string>();
        private void btnResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                secilenResimler = ofd.FileNames.ToList();


                if (secilenResimler.Count > 0)
                    pictureBox1.ImageLocation = secilenResimler[0];
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Arac arac = new Arac()
            {
                Plaka = Plakatxt.Text,
                Marka = Markacombo.Text,
                Seri = Sericombo.Text,
                Yil = Yiltxt.Text,
                Renk = Renktxt.Text,
                Km = Kmtxt.Text,
                Yakit = Yakitcombo.Text,
                KiraUcreti = Ücrettxt.Text,
                Resim = secilenResimler.Count > 0 ? secilenResimler[0] : "",
                Resim2 = secilenResimler.Count > 1 ? secilenResimler[1] : "",
                Resim3 = secilenResimler.Count > 2 ? secilenResimler[2] : "",
                Durum = Durumcombo.Text
            };

            arackiralama.GuncelleArac(arac);
            Sericombo.Items.Clear();
            pictureBox1.ImageLocation = "";
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";


            flowLayoutPanel1.Controls.Clear();

            YenileAraçlarListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;




            string silSorgu = "DELETE FROM müşteri WHERE kiralanan_arac ='" + satır.Cells["plaka"].Value.ToString() + "'";
            SqlCommand silKomut = new SqlCommand();
            arackiralama.ekle_sil_güncelle(silKomut, silSorgu);




            string cümle = "delete from araç where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            arackiralama.ekle_sil_güncelle(komut2, cümle);
            YenileAraçlarListesi();
            flowLayoutPanel1.Controls.Clear();
            Sericombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
        }

        private void Markacombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Sericombo.Items.Clear();
                if (Markacombo.SelectedItem.ToString() == "Opel")
                {
                    Sericombo.Items.Add("Astra");
                    Sericombo.Items.Add("Vectra");
                    Sericombo.Items.Add("Corsa");
                }
                else if (Markacombo.SelectedIndex == 1)
                {
                    Sericombo.Items.Add("Megane");
                    Sericombo.Items.Add("Clio");
                }
                else if (Markacombo.SelectedIndex == 2)
                {
                    Sericombo.Items.Add("Linea");
                    Sericombo.Items.Add("Egea");
                }
                else if (Markacombo.SelectedIndex == 3)
                {
                    Sericombo.Items.Add("Fiesta");
                    Sericombo.Items.Add("Focus");
                }
            }
            catch
            {
                ;
            }

        }

        private void comboAraçlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboAraçlar.SelectedIndex == 0)
                {
                    YenileAraçlarListesi();
                }
                if (comboAraçlar.SelectedIndex == 1)
                {
                    string cümle = "select *from araç where durumu='BOŞ'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
                }
                if (comboAraçlar.SelectedIndex == 2)
                {
                    string cümle = "select *from araç where durumu='DOLU'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
                }
            }
            catch
            {
                ;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
                if (item is TextBox)
                    item.Text = "";

            
            foreach (Control item in Controls)
                if (item is ComboBox)
                    item.Text = "";

          
            Sericombo.Items.Clear();

          
            pictureBox1.Image = null;
            pictureBox1.ImageLocation = ""; 

        
            flowLayoutPanel1.Controls.Clear();

          
            secilenResimler.Clear();

           
            dataGridView1.ClearSelection();
        }
    }
}

