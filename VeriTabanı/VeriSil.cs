using Kutuphane.Sınıflar;
using Kutuphane.ZorunluDegisken;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.VeriTabanı
{
    internal class VeriSil
    {
        //Admin silme,üye silme,kitap silme,işlem silme

        Anahtarlar _anahtarlar;
        public VeriSil(Anahtarlar anahtarlar)
        {
            _anahtarlar = anahtarlar;
        }

        public bool UyeSil(Uye uye)
        {
            string sqlSorgusu = "DELETE FROM uye WHERE uyeID = @p_uyeID";

            using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlSorgusu, connection))
                {
                    command.Parameters.Add("@p_uyeID", SqlDbType.Int).Value = uye.uyeID;
                    if (Execute(command, "uye"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }

        public void AdminSil(Admin admin)
        {
            if (admin == null)
            {
                Console.WriteLine("Admin bilgileri boş.");
                return;
            }
            string sqlSorgusu = "DELETE FROM admin WHERE adminID = @p_adminID";

            using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlSorgusu, connection))
                {
                    command.Parameters.Add("@p_adminID", SqlDbType.Int).Value = admin.adminID;
                    Execute(command, "Admin");
                }
            }
        }

        public bool KitapSil(Kitap kitap)
        {
            string sqlSorgusu = "DELETE FROM kitap WHERE ISBN = @p_ISBN";

            using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlSorgusu, connection))
                {
                    command.Parameters.Add("@p_ISBN", SqlDbType.VarChar).Value = kitap.ISBN;
                    if (Execute(command, "Kitap"))
                        return true;

                    else
                        return false;
                }
            }
        }

        public void IslemSil(Islem islem)
        {
            if (islem == null)
            {
                Console.WriteLine("İşlem bilgileri boş.");
                return;
            }
            string sqlSorgusu = "DELETE FROM islem WHERE islemID = @p_islemID";

            using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlSorgusu, connection))
                {
                    command.Parameters.Add("@islemID", SqlDbType.Int).Value = islem.islemID;
                    Execute(command, "İşlem");
                }
            }

        }
        private bool Execute(SqlCommand command, string tableName)
        {
            try
            {
                command.Connection.Open();
                int etkilenenSatirSayisi = command.ExecuteNonQuery();

                if (etkilenenSatirSayisi == 1)
                {
                    Console.WriteLine($"{tableName} silindi.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"{tableName} silinemedi veya kayıt bulunamadı.");
                    return false;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Veritabanı hatası: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                return false;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}
