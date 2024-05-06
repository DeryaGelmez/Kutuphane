using Kutuphane.Sınıflar;
using Kutuphane.ZorunluDegisken;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.VeriTabanı
{
    public class VeriKontrol
    {
        Anahtarlar _anahtarlar;
        public VeriKontrol(Anahtarlar anahtarlar)
        {
            _anahtarlar = anahtarlar;

        }

        //-------------------------------------------------------------------------------------------------

        //Sisteme girişi kontrol etme

        public bool GirisYap(Giris giris, string secim)
        {
            using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
            {
                SqlCommand command = new SqlCommand();
                //SQL sorgusunun sonuçlarını okumak için
                SqlDataReader rd;

                string qry = "";
                if (secim == "uye")
                    qry = $"SELECT uyeID, ad, soyad FROM uye WHERE eMail = @Email AND sifre = @Sifre";

                else if (secim == "admin")
                    qry = $"SELECT adminID, ad, soyad FROM admin WHERE eMail = @Email AND sifre = @Sifre";

                command.Connection = connection;              
                command.CommandText = qry;
                command.Parameters.AddWithValue("@Email", giris.eMail);
                command.Parameters.AddWithValue("@Sifre", giris.sifre);

                connection.Open();
                rd = command.ExecuteReader();
                if (rd.Read())
                {
                    giris.girisYapID = rd.GetValue(0).ToString();
                    giris.adSoyad = rd.GetValue(1).ToString() + " " + rd.GetValue(2).ToString();
                    connection.Close();
                    return true;
                }
                else
                {
                    connection.Close();
                    return false;
                }
            }
        }
    }


    //-------------------------------------------------------------------------------------------------



}
