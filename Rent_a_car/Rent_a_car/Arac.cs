using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Rent_a_car
{
    public class Arac : Tasit
    {
        public string Km { get; set; }
        public string Yakit { get; set; }
        public string KiraUcreti { get; set; }
        public string Resim { get; set; }
        public string Resim2 { get; set; }
        public string Resim3 { get; set; }
        public string Durum { get; set; }
        public DateTime Tarih { get; set; } = DateTime.Now;
    }
}
