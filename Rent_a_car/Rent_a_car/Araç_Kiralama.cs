using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Rent_a_car
{
    internal class Araç_Kiralama
    {

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Araç_Kiralama;Integrated Security=True");
        DataTable tablo;
        public void ekle_sil_güncelle(SqlCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection=baglanti;
            komut.CommandText=sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void GuncelleArac(Arac arac)
        {
            string sorgu = "update araç set durumu=@durum, marka=@marka, seri=@seri, yil=@yil, renk=@renk, km=@km, yakit=@yakit, kiraucreti=@kiraucreti, resim=@resim, resim2=@resim2, resim3=@resim3, tarih=@tarih where plaka=@plaka";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@plaka", arac.Plaka);
            komut.Parameters.AddWithValue("@marka", arac.Marka);
            komut.Parameters.AddWithValue("@seri", arac.Seri);
            komut.Parameters.AddWithValue("@yil", arac.Yil);
            komut.Parameters.AddWithValue("@renk", arac.Renk);
            komut.Parameters.AddWithValue("@km", arac.Km);
            komut.Parameters.AddWithValue("@yakit", arac.Yakit);
            komut.Parameters.AddWithValue("@kiraucreti", arac.KiraUcreti);
            komut.Parameters.AddWithValue("@resim", arac.Resim);
            komut.Parameters.AddWithValue("@resim2", arac.Resim2);
            komut.Parameters.AddWithValue("@resim3", arac.Resim3);
            komut.Parameters.AddWithValue("@tarih", arac.Tarih);
            komut.Parameters.AddWithValue("@durum", arac.Durum);
            ekle_sil_güncelle(komut, sorgu);

            if (arac.Durum == "BOŞ")
            {
                string silSorgu = "DELETE FROM müşteri WHERE kiralanan_arac = @plaka";
                SqlCommand silKomut = new SqlCommand();
                silKomut.Parameters.AddWithValue("@plaka", arac.Plaka);
                ekle_sil_güncelle(silKomut, silSorgu);
            }
        }


        public DataTable listele(SqlDataAdapter adtr, string sorgu) {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
    }
}
