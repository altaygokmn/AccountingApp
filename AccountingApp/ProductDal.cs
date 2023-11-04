using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Data.Entity.Infrastructure.Design.Executor;
using System.Windows.Forms;

namespace AccountingApp
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;Initial Catalog=Dbo_Muhasebe;Integrated Security=True");
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public List<Product1> GetAllPurchasing()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("SELECT * FROM ProductsPurchasing", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Product1> dataTable = new List<Product1>();

            while (reader.Read())
            {
                Product1 product1 = new Product1
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Urun_Turu = reader["Urun_Turu"].ToString(),
                    Alis_Fiyati = Convert.ToInt32(reader["Alis_Fiyati"]),
                    Urunun_Satin_Alindigi_Bolge = reader["Urunun_Satin_Alindigi_Bolge"].ToString(),
                    Satin_Alinan_Miktar = Convert.ToInt32(reader["Satin_Alinan_Miktar"]),
                    Satin_Alma_Tarihi = Convert.ToDateTime(reader["Satin_Alma_Tarihi"])
                };

                dataTable.Add(product1);
            }
            reader.Close();
            _connection.Close();

            return dataTable;
        }
        public List<ProductResults> GetAllResults()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("SELECT * FROM ResultsTable", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<ProductResults> dataTable = new List<ProductResults>();

            while (reader.Read())
            {
                ProductResults productResults = new ProductResults
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Urun_Turu = reader["Urun_Turu"].ToString(),
                    Alis_Fiyati_Toplam = reader["Alis_Fiyati_Toplam"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Alis_Fiyati_Toplam"]),
                    Satin_Alinan_Miktar_Toplam = reader["Satin_Alinan_Miktar_Toplam"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Satin_Alinan_Miktar_Toplam"]),
                    Satis_Fiyati_Toplam = reader["Satis_Fiyati_Toplam"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Satis_Fiyati_Toplam"]),
                    Satilan_Miktar_Toplam = reader["Satilan_Miktar_Toplam"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Satilan_Miktar_Toplam"]),
                    Satis_Nakliye_Maliyeti = reader["Satis_Nakliye_Maliyeti"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Satis_Nakliye_Maliyeti"]),
                    Satin_Alma_Nakliye_Maliyeti = reader["Satin_Alma_Nakliye_Maliyeti"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Satin_Alma_Nakliye_Maliyeti"]),
                    Nakliye_Maliyeti_Toplam = reader["Nakliye_Maliyeti_Toplam"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Nakliye_Maliyeti_Toplam"]),
                    Kar_veya_Zarar = reader["Kar_veya_Zarar"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Kar_veya_Zarar"])
                };


                dataTable.Add(productResults);
            }
            reader.Close();
            _connection.Close();

            return dataTable;
        }
        public void AddPurchasing(Product1 product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into ProductsPurchasing " +
                "(Urun_Turu, Alis_Fiyati, Urunun_Satin_Alindigi_Bolge, Satin_Alinan_Miktar, Satin_Alma_Tarihi) " +
                "values(@Urun_Turu, @Alis_Fiyati, @Urunun_Satin_Alindigi_Bolge, @Satin_Alinan_Miktar, @Satin_Alma_Tarihi)", _connection);
            ConnectionControl();


            command.Parameters.AddWithValue("@Urun_Turu", product.Urun_Turu);
            command.Parameters.AddWithValue("@Alis_Fiyati", product.Alis_Fiyati);
            command.Parameters.AddWithValue("@Urunun_Satin_Alindigi_Bolge", product.Urunun_Satin_Alindigi_Bolge);
            command.Parameters.AddWithValue("@Satin_Alinan_Miktar", product.Satin_Alinan_Miktar);
            command.Parameters.AddWithValue("@Satin_Alma_Tarihi", product.Satin_Alma_Tarihi);
            command.ExecuteNonQuery();
            UpdateNakliyeMaliyeti("Satin_Alma_Nakliye_Maliyeti", product.Urunun_Satin_Alindigi_Bolge);

            string calculateTotalsQuery = "UPDATE ResultsTable " +
                                          "SET Alis_Fiyati_Toplam = (SELECT SUM(Alis_Fiyati * Satin_Alinan_Miktar) FROM ProductsPurchasing WHERE Urun_Turu = ResultsTable.Urun_Turu), " +
                                          "Satis_Fiyati_Toplam = (SELECT SUM(Satis_Fiyati * Satilan_Miktar) FROM ProductsSale WHERE Urun_Turu = ResultsTable.Urun_Turu)";
            SqlCommand calculateTotalsCommand = new SqlCommand(calculateTotalsQuery, _connection);
            calculateTotalsCommand.ExecuteNonQuery();

            _connection.Close();
        }

        public List<Product2> GetAllSale()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("SELECT * FROM ProductsSale", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Product2> dataTable = new List<Product2>();

            while (reader.Read())
            {
                Product2 product2 = new Product2
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Urun_Turu = reader["Urun_Turu"].ToString(),
                    Satis_Fiyati = Convert.ToInt32(reader["Satis_Fiyati"]),
                    Urunun_Satildigi_Bolge = reader["Urunun_Satildigi_Bolge"].ToString(),
                    Satilan_Miktar = Convert.ToInt32(reader["Satilan_Miktar"]),
                    Satis_Tarihi = Convert.ToDateTime(reader["Satis_Tarihi"]),
                };

                dataTable.Add(product2);
            }

            reader.Close();
            _connection.Close();

            return dataTable;
        }




        public void AddSale(Product2 product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into ProductsSale " +
                "(Urun_Turu, Satis_Fiyati, Urunun_Satildigi_Bolge, Satilan_Miktar, Satis_Tarihi) " +
                "values(@Urun_Turu, @Satis_Fiyati, @Urunun_Satildigi_Bolge, @Satilan_Miktar, @Satis_Tarihi)", _connection);

            command.Parameters.AddWithValue("@Urun_Turu", product.Urun_Turu);
            command.Parameters.AddWithValue("@Satis_Fiyati", product.Satis_Fiyati);
            command.Parameters.AddWithValue("@Urunun_Satildigi_Bolge", product.Urunun_Satildigi_Bolge);
            command.Parameters.AddWithValue("@Satilan_Miktar", product.Satilan_Miktar);
            command.Parameters.AddWithValue("@Satis_Tarihi", product.Satis_Tarihi);
            command.ExecuteNonQuery();

            UpdateNakliyeMaliyeti("Satis_Nakliye_Maliyeti", product.Urunun_Satildigi_Bolge);

            string calculateTotalsQuery = "UPDATE ResultsTable " +
                                          "SET Alis_Fiyati_Toplam = (SELECT SUM(Alis_Fiyati * Satin_Alinan_Miktar) FROM ProductsPurchasing WHERE Urun_Turu = ResultsTable.Urun_Turu), " +
                                          "Satis_Fiyati_Toplam = (SELECT SUM(Satis_Fiyati * Satilan_Miktar) FROM ProductsSale WHERE Urun_Turu = ResultsTable.Urun_Turu)";
            SqlCommand calculateTotalsCommand = new SqlCommand(calculateTotalsQuery, _connection);
            calculateTotalsCommand.ExecuteNonQuery();

            _connection.Close();
        }
        private int ConvertRegionToCost(string region)
        {
            ConnectionControl();
            switch (region)
            {
                case "Akdeniz Bölgesi":
                    return 5000;
                case "Doğu Anadolu Bölgesi":
                    return 12500;
                case "Ege Bölgesi":
                    return 4750;
                case "Güney Doğu Anadolu Bölgesi":
                    return 9600;
                case "Karadeniz Bölgesi":
                    return 4250;
                case "Marmara Bölgesi":
                    return 1250;
                case "İç Anadolu Bölgesi":
                    return 6525;
                default:
                    return 0;
            }
        }
        private void UpdateNakliyeMaliyeti(string columnName, string region)

        {
            int nakliyeMaliyeti = ConvertRegionToCost(region);

            ConnectionControl();
            SqlCommand updateCommand = new SqlCommand($"UPDATE ResultsTable SET {columnName} = @NakliyeMaliyeti WHERE Urun_Turu = @UrunTuru", _connection);
            updateCommand.Parameters.AddWithValue("@NakliyeMaliyeti", nakliyeMaliyeti);
            updateCommand.Parameters.AddWithValue("@UrunTuru", columnName == "Satin_Alma_Nakliye_Maliyeti" ? GetLastPurchasingProduct().Urun_Turu : GetLastSaleProduct().Urun_Turu);
            _connection.Open();
            updateCommand.ExecuteNonQuery();

            UpdateNakliyeMaliyetiToplam();
        }

        private Product1 GetLastPurchasingProduct()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM ProductsPurchasing ORDER BY Id DESC", _connection);
            SqlDataReader reader = command.ExecuteReader();

            Product1 product1 = null;

            if (reader.Read())
            {
                product1 = new Product1
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Urun_Turu = reader["Urun_Turu"].ToString(),
                    Alis_Fiyati = Convert.ToInt32(reader["Alis_Fiyati"]),
                    Urunun_Satin_Alindigi_Bolge = reader["Urunun_Satin_Alindigi_Bolge"].ToString(),
                    Satin_Alinan_Miktar = Convert.ToInt32(reader["Satin_Alinan_Miktar"]),
                    Satin_Alma_Tarihi = Convert.ToDateTime(reader["Satin_Alma_Tarihi"])
                };
            }

            reader.Close();
            _connection.Close();

            return product1;
        }

        private Product2 GetLastSaleProduct()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM ProductsSale ORDER BY Id DESC", _connection);
            SqlDataReader reader = command.ExecuteReader();

            Product2 product2 = null;

            if (reader.Read())
            {
                product2 = new Product2
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Urun_Turu = reader["Urun_Turu"].ToString(),
                    Satis_Fiyati = Convert.ToInt32(reader["Satis_Fiyati"]),
                    Urunun_Satildigi_Bolge = reader["Urunun_Satildigi_Bolge"].ToString(),
                    Satilan_Miktar = Convert.ToInt32(reader["Satilan_Miktar"]),
                    Satis_Tarihi = Convert.ToDateTime(reader["Satis_Tarihi"]),
                };
            }

            reader.Close();
            _connection.Close();

            return product2;
        }
        private void UpdateNakliyeMaliyetiToplam()
        {
            ConnectionControl();
            SqlCommand updateCommand = new SqlCommand("UPDATE ResultsTable " +
                                                        "SET Nakliye_Maliyeti_Toplam = Satin_Alma_Nakliye_Maliyeti + Satis_Nakliye_Maliyeti", _connection);
            updateCommand.ExecuteNonQuery();
        }
    }
}
