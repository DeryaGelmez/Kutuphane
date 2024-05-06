using Kutuphane.Sınıflar;
using Kutuphane.Sınıflar.Enums;
using Kutuphane.ZorunluDegisken;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.VeriTabanı
{
    public class VeriGetir
    {
        Anahtarlar _anahtarlar;
        public VeriGetir(Anahtarlar anahtarlar)
        {
            _anahtarlar = anahtarlar;
        }




        public static string girisYapID; //sisteme kim giriş yaparsa ID'si burada tutulur ve gerekli yerlere gönderilir.
        public static string secim;






        //-----------------------------------------------------------------------------

        //Kategorileri, kategoriler listesi şeklinde döndürme
        public List<Kategori> KategorileriGetir()
        {
            List<Kategori> kategoriler = new List<Kategori>();
            Kategori kategoriBir = new Kategori
            {
                ad = "Herhangi",
                kategoriID = 1,
            };
            try
            {
                using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
                {
                    //Kategori tablosunun tüm sütunlarını çekerek dataTable nesnesine doldurma
                    SqlDataAdapter da = new SqlDataAdapter($"Select * From kategori", connection);
                    DataTable dataTable = new DataTable();
                    connection.Open();
                    da.Fill(dataTable);

                    //DataTable'daki tüm veriler satır satır alınır ve bu satırlardan kategori nesnesi oluşturulur.
                    foreach (DataRow row in dataTable.Rows)
                    {
                        Kategori kategori = new Kategori
                        {
                            ad = row["kategoriAdi"].ToString(),
                            kategoriID = Convert.ToInt32(row["kategoriID"]),
                        };
                        kategoriler.Add(kategori);
                    }

                    connection.Close();
                    return kategoriler;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası..." + ex.Message);
                return null;
            }
        }

        //-----------------------------------------------------------------------------


        //Arama kriterlerine göre kitapları listeleme
        public List<Kitap> KitapAra(string aranacakKelime, string kategori)
        {
            List<Kitap> kitaplar = new List<Kitap>();
            try
            {
                using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
                {
                    string qry = "";
                    if (!String.IsNullOrEmpty(aranacakKelime) && kategori != "Herhangi")
                    {
                        qry = $@"SELECT * FROM kitap k
                                LEFT JOIN kitap_kategori kk on kk.kitapID=k.kitapID
                                WHERE  (k.ad LIKE '%{aranacakKelime}%' OR k.yazar LIKE '%{aranacakKelime}%' OR k.ISBN LIKE '%{aranacakKelime}%') 
                                and kk.kategoriID=(Select kategoriID from kategori where kategoriAdi='{kategori}')";
                    }
                    else if (!String.IsNullOrEmpty(aranacakKelime) && kategori == "Herhangi")
                    {
                        qry = $@"SELECT * FROM kitap k
                                WHERE  (ad LIKE '%{aranacakKelime}%' OR yazar LIKE '%{aranacakKelime}%' OR ISBN LIKE '%{aranacakKelime}%')";
                    }
                    else if (String.IsNullOrEmpty(aranacakKelime) && kategori != "Herhangi")
                    {
                        qry = $@"SELECT * FROM kitap k
                                LEFT JOIN kitap_kategori kk on kk.kitapID=k.kitapID
                               where  kk.kategoriID=(Select kategoriID from kategori where kategoriAdi='{kategori}')";
                    }
                    else if (String.IsNullOrEmpty(aranacakKelime) && kategori == "Herhangi")
                    {
                        qry = "SELECT * FROM kitap";
                    }
                    SqlDataAdapter da = new SqlDataAdapter(qry, connection);
                    DataTable dataTable = new DataTable();
                    connection.Open();
                    da.Fill(dataTable);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        Kitap kitap = new Kitap
                        {
                            kitapID = Convert.ToInt32(row["kitapID"]),
                            ISBN = row["ISBN"] != DBNull.Value ? row["ISBN"].ToString() : "",
                            ad = row["ad"] != DBNull.Value ? row["ad"].ToString() : "",
                            yazar = row["yazar"] != DBNull.Value ? row["yazar"].ToString() : "",
                            baskiYili = row["baskiYili"] != DBNull.Value ? row["baskiYili"].ToString() : "",
                            yayinEvi = row["yayinEvi"] != DBNull.Value ? row["yayinEvi"].ToString() : "",
                            sayfaSayisi = row["sayfaSayisi"] != DBNull.Value ? row["sayfaSayisi"].ToString() : "",
                            aciklama = row["aciklama"] != DBNull.Value ? row["aciklama"].ToString() : "",
                            kitapDurumu = Convert.ToBoolean(row["kitapDurumu"]) == true ? Enum_KitapDurumu.Mevcut : Enum_KitapDurumu.MevcutDegil,
                            islemSayisi = Convert.ToInt32(row["islemSayisi"]),
                            adminID = row["adminID"] != DBNull.Value ? Convert.ToInt32(row["adminID"]) : 0,
                            kategoriID = Convert.ToInt32(row["kategoriID"]),
                        };
                        kitaplar.Add(kitap);
                    }
                    connection.Close();
                    return kitaplar;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
                return null;
            }

        }

        //-----------------------------------------------------------------------------

        public bool KitapDurumSorgula(int kitapId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
                {
                    string sorgu = $"SELECT * FROM kitap WHERE kitapID={kitapId} AND kitapDurumu=1";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, connection);
                    DataTable dataTable = new DataTable();
                    connection.Open();
                    da.Fill(dataTable);
                    connection.Close();
                    if (dataTable.Rows.Count > 0)
                    {
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
                return false;
            }

        }

        public bool IslemSorgulama(Islem islem)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
                {
                    string sorgu = $"SELECT * FROM islem WHERE uyeID={islem.uyeID} AND kitapID={islem.kitapID}";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, connection);
                    DataTable dataTable = new DataTable();
                    connection.Open();
                    da.Fill(dataTable);
                    connection.Close();
                    if (dataTable.Rows.Count > 0)
                    {
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
                return false;
            }

        }

        public List<Uye> UyeAra(string aranacakKelime)
        {
            List<Uye> uyeler = new List<Uye>();
            try
            {
                using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
                {
                    string sorgu = $"SELECT * FROM uye WHERE " +
                           $"Ad LIKE '%{aranacakKelime}%' OR " +
                           $"Soyad LIKE '%{aranacakKelime}%' OR " +
                           $"Email LIKE '%{aranacakKelime}%'";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, connection);
                    DataTable dataTable = new DataTable();
                    connection.Open();
                    da.Fill(dataTable);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        Uye uye = new Uye
                        {
                            uyeID = row["uyeID"] != DBNull.Value ? Convert.ToInt32(row["uyeID"]) : 0,
                            ad = row["ad"] != DBNull.Value ? row["ad"].ToString() : "",
                            soyad = row["soyad"] != DBNull.Value ? row["soyad"].ToString() : "",
                            eMail = row["eMail"] != DBNull.Value ? row["eMail"].ToString() : "",
                            adres = row["adres"] != DBNull.Value ? row["adres"].ToString() : "",
                            telefon = row["telefon"] != DBNull.Value ? row["telefon"].ToString() : "",

                        };
                        uyeler.Add(uye);
                    }
                    connection.Close();
                    return uyeler;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
                return null;
            }

        }

        //-----------------------------------------------------------------------------


        public void Aktiflik(string sorgu, string v, DataGridView dataGridView1)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
                {
                    connection.Open();

                    // Bir üye kitabı geç getirdiğinde ceza tarihi verilir. Bu ceza süresi bitmişse üyeyi aktif yapar.
                    SqlCommand command1 = new SqlCommand("UPDATE uye SET uyelikDurumu = 1 WHERE cezaTarihi < GETDATE() AND uyelikDurumu = 0", connection);
                    // Bir üye kitabı geç getirdiğinde ceza tarihi verilir. Bu ceza süresi bitmişse üyeyi pasif yapar.
                    SqlCommand command2 = new SqlCommand("UPDATE uye SET uyelikDurumu = 0 WHERE uyelikDurumu = 1 AND uyeID IN (SELECT uyeID FROM islem WHERE iadeTarihi < GETDATE())", connection);

                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();

                    SqlDataAdapter da = new SqlDataAdapter($"SELECT {sorgu} FROM {v}", connection);
                    DataSet ds = new DataSet();
                    da.Fill(ds, v);
                    dataGridView1.DataSource = ds.Tables[v];

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
        }



        public List<Islem> IslemGetir(string arananKelime)
        {
            List<Islem> islemler = new List<Islem>();
            try
            {
                using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
                {
                    //Kategori tablosunun tüm sütunlarını çekerek dataTable nesnesine doldurma
                    string qry = $@"SELECT isl.islemID,isl.uyeID,uye.ad 'uyeAdi', isl.kitapID, kit.ad 'kitapAdi',isl.iadeTarihi,isl.islemTarihi,isl.islemDurumu,isl.adminID FROM islem isl
                      LEFT JOIN kitap kit on kit.kitapID=isl.kitapID
                      LEFT JOIN uye uye on uye.uyeID=isl.uyeID
                      WHERE (uye.ad LIKE '%{arananKelime}%' OR kit.ad LIKE '%{arananKelime}%') AND isl.islemDurumu=1";

                    SqlDataAdapter da = new SqlDataAdapter(qry, connection);
                    DataTable dataTable = new DataTable();
                    connection.Open();
                    da.Fill(dataTable);

                    //DataTable'daki tüm veriler satır satır alınır ve bu satırlardan kategori nesnesi oluşturulur.
                    foreach (DataRow row in dataTable.Rows)
                    {
                        Islem islem = new Islem
                        {
                            islemID = row["islemID"] != DBNull.Value ? Convert.ToInt32(row["islemID"].ToString()) : 0,
                            uyeID = row["uyeID"] != DBNull.Value ? Convert.ToInt32(row["uyeID"].ToString()) : 0,
                            uyeAdi = row["uyeAdi"].ToString(),
                            kitapID = row["kitapID"] != DBNull.Value ? Convert.ToInt32(row["kitapID"].ToString()) : 0,
                            kitapAdi = row["kitapAdi"].ToString(),
                            iadeTarihi = row["kitapAdi"] != DBNull.Value ? row["kitapAdi"].ToString() : "",
                            islemTarihi = row["islemTarihi"] != DBNull.Value ? row["islemTarihi"].ToString() : "",
                            islemDurumu = row["islemDurumu"] != DBNull.Value ? Convert.ToInt32(row["islemDurumu"].ToString()) : 0,
                            adminID = row["adminID"] != DBNull.Value ? Convert.ToInt32(row["adminID"].ToString()) : 0,

                        };
                        islemler.Add(islem);
                    }
                    connection.Close();
                    return islemler;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası..." + ex.Message);
                return null;
            }

        }

        public Uye UyeGetir(string email)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter($"Select * From uye WHERE eMail='{email}'", connection);

                    DataTable dataTable = new DataTable();
                    connection.Open();
                    da.Fill(dataTable);

                    Uye uye = new Uye
                    {
                        uyeID = Convert.ToInt32(dataTable.Rows[0]["uyeID"]),
                        ad = dataTable.Rows[0]["ad"].ToString(),
                        soyad = dataTable.Rows[0]["soyad"].ToString(),
                        eMail = dataTable.Rows[0]["eMail"].ToString(),
                        sifre = dataTable.Rows[0]["sifre"].ToString(),
                        telefon = dataTable.Rows[0]["telefon"].ToString(),
                        adres = dataTable.Rows[0]["adres"].ToString()
                    };
                    connection.Close();
                    return uye;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanı hatası...");
                return null;
            }
        }

        public Admin AdminGetir(string email)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_anahtarlar.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter($"Select * From admin WHERE eMail='{email}'", connection);

                    DataTable dataTable = new DataTable();
                    connection.Open();
                    da.Fill(dataTable);

                    Admin admin = new Admin
                    {
                        adminID = Convert.ToInt32(dataTable.Rows[0]["adminID"]),
                        ad = dataTable.Rows[0]["ad"].ToString(),
                        soyad = dataTable.Rows[0]["soyad"].ToString(),
                        eMail = dataTable.Rows[0]["eMail"].ToString(),
                        sifre = dataTable.Rows[0]["sifre"].ToString(),
                        telefon = dataTable.Rows[0]["telefon"].ToString(),
                        adres = dataTable.Rows[0]["adres"].ToString()
                    };
                    connection.Close();
                    return admin;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanı hatası...");
                return null;
            }
        }




    }
}
