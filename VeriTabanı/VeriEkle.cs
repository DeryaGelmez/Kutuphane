using Kutuphane.Sınıflar;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphane.ZorunluDegisken;

namespace Kutuphane.VeriTabanı
{
    public class VeriEkle
    {
        //Admin ekleme,üye ekleme,kitap ekleme,işlem ekleme

        Anahtarlar _anahtarlar;

        public VeriEkle(Anahtarlar anahtarlar)
        {
            _anahtarlar = anahtarlar;
        }

        public bool UyeEkle(Uye uye)
        {
            string sqlSorgusu = "INSERT INTO uye VALUES (@p_ad, @p_soyad, @p_eMail, @p_sifre, @p_telefon, @p_adres, @p_uyelikDurumu, @p_adminID)";

            using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlSorgusu, connection))
                {
                    try
                    {
                        command.Parameters.Add("@p_ad", SqlDbType.VarChar).Value = uye.ad;
                        command.Parameters.Add("@p_soyad", SqlDbType.VarChar).Value = uye.soyad;
                        command.Parameters.Add("@p_eMail", SqlDbType.VarChar).Value = uye.eMail;
                        command.Parameters.Add("@p_sifre", SqlDbType.VarChar).Value = uye.sifre;
                        command.Parameters.Add("@p_telefon", SqlDbType.VarChar).Value = uye.telefon;
                        command.Parameters.Add("@p_adres", SqlDbType.VarChar).Value = uye.adres;
                        command.Parameters.Add("@p_uyelikDurumu", SqlDbType.Int).Value = 1;
                        command.Parameters.Add("@p_adminID", SqlDbType.Int).Value = uye.adminID;

                        connection.Open();
                        int eklenenSatirSayisi = command.ExecuteNonQuery();
                        if (eklenenSatirSayisi == 1)
                        {
                            Console.WriteLine("Üye eklendi.");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Üye eklenirken hata oluştu.");
                            return false;

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
                    finally
                    {
                        connection.Close();
                    }
                    return false;
                }
            }
        }

        public void AdminEkle(Admin admin)
        {
            if (admin == null)
            {
                Console.WriteLine("Admin bilgileri boş.");
                return;
            }
            string sqlSorgusu = "INSERT INTO admin (ad, soyad, eMail, telefon, adres) VALUES (@p_ad, @p_soyad, @p_eMail, @p_telefon, @p_adres)";

            using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlSorgusu, connection))
                {
                    try
                    {
                        command.Parameters.Add("@p_ad", SqlDbType.VarChar).Value = admin.ad;
                        command.Parameters.Add("@p_soyad", SqlDbType.VarChar).Value = admin.soyad;
                        command.Parameters.Add("@p_eMail", SqlDbType.VarChar).Value = admin.eMail;
                        command.Parameters.Add("@p_telefon", SqlDbType.VarChar).Value = admin.telefon;
                        command.Parameters.Add("@p_adres", SqlDbType.VarChar).Value = admin.adres;

                        connection.Open();
                        int eklenenSatirSayisi = command.ExecuteNonQuery();

                        if (eklenenSatirSayisi == 1)
                        {
                            Console.WriteLine("Admin eklendi.");
                        }
                        else
                        {
                            Console.WriteLine("Admin eklenirken hata oluştu.");
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
            }
        }

        public bool KitapEkle(Kitap kitap)
        {
            if (kitap == null)
            {
                Console.WriteLine("Kitap bilgileri boş.");
                return false;
            }

            string sqlSorgusu = @"INSERT INTO kitap VALUES (@p_ISBN, @p_ad, @p_yazar, @p_baskiYili, @p_yayinEvi, @p_sayfaSayisi, @p_aciklama, @p_kitapDurumu, @p_islemSayisi, @p_adminID, @p_kategoriID)";

            try
            {
                using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlSorgusu, connection))
                    {
                        command.Parameters.Add("@p_ISBN", SqlDbType.VarChar).Value = kitap.ISBN;
                        command.Parameters.Add("@p_ad", SqlDbType.VarChar).Value = kitap.ad;
                        command.Parameters.Add("@p_yazar", SqlDbType.VarChar).Value = kitap.yazar;
                        command.Parameters.Add("@p_baskiYili", SqlDbType.Int).Value = kitap.baskiYili;
                        command.Parameters.Add("@p_yayinEvi", SqlDbType.VarChar).Value = kitap.yayinEvi;
                        command.Parameters.Add("@p_sayfaSayisi", SqlDbType.Int).Value = kitap.sayfaSayisi;
                        command.Parameters.Add("@p_aciklama", SqlDbType.VarChar).Value = kitap.aciklama;
                        command.Parameters.Add("@p_kitapDurumu", SqlDbType.Int).Value = 1;
                        command.Parameters.Add("@p_islemSayisi", SqlDbType.Int).Value = 0;
                        command.Parameters.Add("@p_adminID", SqlDbType.Int).Value = 1;
                        command.Parameters.Add("@p_kategoriID", SqlDbType.Int).Value = kitap.kategoriID;

                        connection.Open();
                        int eklenenSatirSayisi = command.ExecuteNonQuery();
                        if (eklenenSatirSayisi == 1)
                        {
                            Console.WriteLine("Kitap eklendi.");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Kitap eklenirken hata oluştu.");
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


        public bool KategoriEkle(Kategori kategori)
        {
            return true;
           
        }

        public bool KitapVer(Islem islem)
        {
            string sqlSorgusu = @"INSERT INTO islem (uyeID, kitapID, islemTarihi, iadeTarihi,islemDurumu, adminID)
                                VALUES (@p_uyeID, @p_kitapID, @p_islemTarihi, @p_iadeTarihi,@p_islemDurumu, @p_adminID)";

            try
            {
                using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlSorgusu, connection))
                    {
                        command.Parameters.Add("@p_uyeID", SqlDbType.Int).Value = islem.uyeID;
                        command.Parameters.Add("@p_kitapID", SqlDbType.Int).Value = islem.kitapID;
                        command.Parameters.Add("@p_islemTarihi", SqlDbType.Date).Value = islem.islemTarihi;
                        command.Parameters.Add("@p_iadeTarihi", SqlDbType.Date).Value = islem.iadeTarihi;
                        command.Parameters.Add("@p_islemDurumu", SqlDbType.Int).Value = 1;
                        command.Parameters.Add("@p_adminID", SqlDbType.Int).Value = islem.adminID;
                        connection.Open();
                        int eklenenSatirSayisi = command.ExecuteNonQuery();
                        if (eklenenSatirSayisi == 1)
                        {
                            Console.WriteLine("Emanet işlemi oluşturuldu.");

                            VeriGuncelle veriGuncelle = new VeriGuncelle(new Anahtarlar());
                            veriGuncelle.KitapGuncelle(new Kitap
                            {
                                kitapID = islem.kitapID,
                                kitapDurumu = Sınıflar.Enums.Enum_KitapDurumu.MevcutDegil
                            });
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Emanet işlemi oluşturulamadı.");
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

        public bool TeslimAl(Islem islem)
        {
            string sqlSorgusu = @"INSERT INTO islem (uyeID, kitapID, islemTarihi, iadeTarihi,islemDurumu, adminID)
                                VALUES (@p_uyeID, @p_kitapID, @p_islemTarihi, @p_iadeTarihi,@p_islemDurumu, @p_adminID)";

            try
            {
                using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlSorgusu, connection))
                    {
                        command.Parameters.Add("@p_uyeID", SqlDbType.Int).Value = islem.uyeID;
                        command.Parameters.Add("@p_kitapID", SqlDbType.Int).Value = islem.kitapID;
                        command.Parameters.Add("@p_islemTarihi", SqlDbType.Date).Value = islem.islemTarihi;
                        command.Parameters.Add("@p_iadeTarihi", SqlDbType.Date).Value = islem.iadeTarihi;
                        command.Parameters.Add("@p_islemDurumu", SqlDbType.Int).Value = 1;
                        command.Parameters.Add("@p_adminID", SqlDbType.Int).Value = islem.adminID;
                        connection.Open();
                        int eklenenSatirSayisi = command.ExecuteNonQuery();
                        if (eklenenSatirSayisi == 1)
                        {
                            Console.WriteLine("Emanet işlemi oluşturuldu.");

                            VeriGuncelle veriGuncelle = new VeriGuncelle(new Anahtarlar());
                            veriGuncelle.KitapGuncelle(new Kitap
                            {
                                kitapID = islem.kitapID,
                                kitapDurumu = Sınıflar.Enums.Enum_KitapDurumu.Mevcut
                            });
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Emanet işlemi oluşturulamadı.");
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
