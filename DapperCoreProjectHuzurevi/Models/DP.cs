using System;
using System.Data.SqlClient;
using Dapper;

namespace DapperCoreProjectHuzurevi.Models
{
	public class DP
	{
        //dapper sınıfı, veritabanı işlemleri için
        //Execute ve Query Dapper kütüphanesine ait komutlar


        public static string connectionString = "Server=localhost;Database=HuzureviManagementDb;User Id=sa;Password=YourStrongPassword123!;TrustServerCertificate=True;";

        //ekleme, silme, güncelleme işlemlerinde kullanılacak metot
        public static void ExecuteReturn(string procAdi, DynamicParameters param = null)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute(procAdi, param, commandType: System.Data.CommandType.StoredProcedure);
            }

        }

            //listeleme, filtreleme, veri çekme için
            public static IEnumerable<T> Listeleme<T>(string procAdi, DynamicParameters param = null)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return connection.Query<T>(procAdi, param, commandType : System.Data.CommandType.StoredProcedure);
            }
        }
    }
}

