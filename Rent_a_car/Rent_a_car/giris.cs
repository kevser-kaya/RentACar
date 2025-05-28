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
    public partial class giris : Form
    {
        Araç_Kiralama kontrol = new Araç_Kiralama();

        public giris()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciFormu getir = new KullaniciFormu();
            this.Hide();
            getir.ShowDialog();
            this.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string TC = Microsoft.VisualBasic.Interaction.InputBox("TC:", "Yönetici Bilgisi", "");
            string sifre = Microsoft.VisualBasic.Interaction.InputBox("Şifre:", "Yönetici Bilgisi", "");
            string sorgu = "SELECT * FROM Yetkili WHERE Yetkili_TC = '" + TC + "' AND Yetkili_sifre = '" + sifre + "'";

            SqlDataAdapter adtr = new SqlDataAdapter();
            DataTable tablo = kontrol.listele(adtr, sorgu);

            if (tablo.Rows.Count > 0)
            {
                Form1 ac = new Form1();
                this.Hide();
                ac.ShowDialog();

            }
            else
            {
                MessageBox.Show("Yanlış Giriş Yaptınız", "UYARI", MessageBoxButtons.OK);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
