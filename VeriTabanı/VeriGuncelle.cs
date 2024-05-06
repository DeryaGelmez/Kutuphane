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
    internal class VeriGuncelle
    {

        //Admin güncelleme,üye güncelleme,kitap güncelleme,kitap süresini uzatma

        Anahtarlar _anahtarlar;

        public VeriGuncelle(Anahtarlar anahtarlar)
        {
            _anahtarlar = anahtarlar;
        }

        public bool UyeGuncelle(Uye uye)
        {
            string sqlSorgusu = $"UPDATE uye SET ad = '{uye.ad}', soyad = '{uye.soyad}',sifre='{uye.sifre}', eMail = '{uye.eMail}', telefon = '{uye.telefon}', adres = '{uye.adres}' WHERE uyeID = {uye.uyeID}";

            try
            {
                using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlSorgusu, connection))
                    {

                        connection.Open();
                        int guncellenenSatirSayisi = command.ExecuteNonQuery();
                        if (guncellenenSatirSayisi == 1)
                        {
                            Console.WriteLine("Üye güncellendi.");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Üye güncellenemedi.");
                            return false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Veritabanı Hatası: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
            return false;
        }

        public void AdminGuncelle(Admin admin)
        {
            string sqlSorgusu = $"UPDATE admin SET ad = '{admin.ad}', soyad = '{admin.soyad}',sifre='{admin.sifre}', eMail = '{admin.eMail}', telefon = '{admin.telefon}', adres = '{admin.adres}' WHERE adminID = {admin.adminID}";

            try
            {
                using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlSorgusu, connection))
                    {

                        connection.Open();
                        int guncellenenSatirSayisi = command.ExecuteNonQuery();
                        if (guncellenenSatirSayisi == 1)
                        {
                            Console.WriteLine("Admin güncellendi.");
                        }
                        else
                        {
                            Console.WriteLine("Admin güncellenemedi.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Veritabanı Hatası: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }

        public bool KitapGuncelle(Kitap kitap)
        {
            string sqlSorgusu = @"UPDATE kitap SET ad = @p_ad, yazar = @p_yazar, baskiYili = @p_baskiYili, yayinEvi = @p_yayinEvi, sayfaSayisi = @p_sayfaSayisi, aciklama = @p_aciklama, kitapDurumu = @kitapDurumu, kategoriID=@kategoriID WHERE ISBN = @p_ISBN";

            try
            {
                using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlSorgusu, connection))
                    {
                        command.Parameters.Add("@p_ad", SqlDbType.VarChar).Value = kitap.ad;
                        command.Parameters.Add("@p_yazar", SqlDbType.VarChar).Value = kitap.yazar;
                        command.Parameters.Add("@p_baskiYili", SqlDbType.VarChar).Value = kitap.baskiYili;
                        command.Parameters.Add("@p_yayinEvi", SqlDbType.VarChar).Value = kitap.yayinEvi;
                        command.Parameters.Add("@p_sayfaSayisi", SqlDbType.VarChar).Value = kitap.sayfaSayisi;
                        command.Parameters.Add("@p_aciklama", SqlDbType.NVarChar).Value = kitap.aciklama;
                        command.Parameters.Add("@kitapDurumu", SqlDbType.TinyInt).Value = kitap.kitapDurumu;
                        command.Parameters.Add("@kategoriID", SqlDbType.Int).Value = kitap.kategoriID;
                        command.Parameters.Add("@p_ISBN", SqlDbType.VarChar).Value = kitap.ISBN;
                        connection.Open();
                        int guncellenenSatirSayisi = command.ExecuteNonQuery();

                        if (guncellenenSatirSayisi == 1)
                        {
                            Console.WriteLine("Kitap güncellendi.");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Kitap güncellenemedi.");
                            return false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Veritabanı Hatası: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                return false;
            }
        }


        public void SureUzat(Islem islem)
        {
            if (islem == null)
            {
                Console.WriteLine("İşlem bilgileri boş.");
                return;
            }

            string sqlSorgusu = "UPDATE islem SET iadeTarihi = @p_iadeTarihi WHERE islemID = @p_islemID";

            try
            {
                using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlSorgusu, connection))
                    {
                        command.Parameters.Add("@p_islemID", SqlDbType.Int).Value = islem.islemID;
                        command.Parameters.Add("@p_iadeTarihi", SqlDbType.DateTime).Value = islem.iadeTarihi;

                        connection.Open();
                        int etkilenenSatirSayisi = command.ExecuteNonQuery();

                        if (etkilenenSatirSayisi == 1)
                        {
                            Console.WriteLine("İşlem süresi uzatıldı.");
                        }
                        else
                        {
                            Console.WriteLine("İşlem süresi uzatılamadı veya işlem bulunamadı.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Veritabanı Hatası: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }

        public bool IslemGuncelle(Islem islem)
        {
            string qry = $@"UPDATE islem set islemDurumu={islem.islemDurumu} WHERE kitapID={islem.kitapID} and uyeID={islem.uyeID}";
            try
            {
                using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(qry, connection))
                    {

                        connection.Open();
                        int guncellenenSatirSayisi = command.ExecuteNonQuery();
                        if (guncellenenSatirSayisi == 1)
                        {
                            Console.WriteLine("İslem güncellendi.");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("İslem güncellenemedi.");
                            return false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Veritabanı Hatası: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
            return false;
        }
    }
}
