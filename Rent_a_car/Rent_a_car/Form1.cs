
using System.Data.SqlClient;

namespace Rent_a_car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            frmMusteriEkleme ekle = new frmMusteriEkleme();
            ekle.ShowDialog(); 
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMusteriListele listele = new frmMusteriListele();
            listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAra�Kay�t kay�t = new frmAra�Kay�t();
            kay�t.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAra�Listele listele = new frmAra�Listele();
            listele.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        
        }
    }
}
