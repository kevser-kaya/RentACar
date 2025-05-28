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

    public partial class frmAraçKayıt : Form
    {
        Araç_Kiralama arackiralama= new Araç_Kiralama();
        public frmAraçKayıt()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string cümle = "insert into araç(plaka,marka,seri,yil,renk,km,yakit,kiraucreti,resim,resim2,resim3,tarih,durumu) values(@plaka,@marka,@seri,@yil,@renk,@km,@yakit,@kiraucreti,@resim,@resim2,@resim3,@tarih,@durumu)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka", Plakatxt.Text);
            komut2.Parameters.AddWithValue("@marka" , Markacombo.Text);
            komut2.Parameters.AddWithValue("@seri", Sericombo.Text);
            komut2.Parameters.AddWithValue("@yil", Yiltxt.Text);
            komut2.Parameters.AddWithValue("@renk", Renktxt.Text);
            komut2.Parameters.AddWithValue("@km", Kmtxt.Text);
            komut2.Parameters.AddWithValue("@yakit", Yakitcombo.Text); 
            komut2.Parameters.AddWithValue("@kiraucreti", Ücrettxt.Text);
            komut2.Parameters.AddWithValue("@resim", secilenResimler.Count > 0 ? secilenResimler[0] : (object)DBNull.Value);
            komut2.Parameters.AddWithValue("@resim2", secilenResimler.Count > 1 ? secilenResimler[1] : (object)DBNull.Value);
            komut2.Parameters.AddWithValue("@resim3", secilenResimler.Count > 2 ? secilenResimler[2] : (object)DBNull.Value);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut2.Parameters.AddWithValue("@durumu", "BOŞ");
            arackiralama.ekle_sil_güncelle(komut2,cümle);
            Sericombo.Items.Clear();
            foreach (Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
                if (item is ComboBox) item.Text = "";
            }

            pictureBox1.ImageLocation = "";
            secilenResimler.Clear(); 

            MessageBox.Show("Araç başarıyla eklendi.");
        }
    }
}
