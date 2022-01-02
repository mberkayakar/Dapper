using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperConsoleApp
{
     class Program
    {
        static void Main(string[] args)
        {
            #region ADO.NET (Connection mimari Klasik)

            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = "server=BERKAY_MONSTER; database=UdemyDapperDb; integrated security = true";
            //conn.Open();

            //SqlCommand cmd = conn.CreateCommand();
            //cmd.CommandText = "insert into Products values ('samsung',4000,30)";

            //cmd.ExecuteNonQuery();

            //conn.Close();

            //Console.WriteLine("İşlem Tamamlandı . Komut : "+cmd.CommandText);
            //Console.ReadLine();

            #endregion

            #region Dapper kısmı


            //var conn = new SqlConnection();
            //conn.ConnectionString = "server=BERKAY_MONSTER; database=UdemyDapperDb; integrated security = true";

            //string sql = "insert into Products values ('samsung',4000,30)";


            //conn.Execute(sql);


            //Console.WriteLine("İşlem Tamamlandı . Komut : "+sql);
            //Console.ReadLine();

            // Görüldüğü üzere bir benzerlik mevcuttur .

            #endregion

            #region Parametreli bir sql srogusu çalıştırmak 

            //var conn = new SqlConnection();
            //conn.ConnectionString = "server=BERKAY_MONSTER; database=UdemyDapperDb; integrated security = true";



            //string sql = "insert into Products values (@name,@fiyat,@stok)";

            //conn.Execute(sql,new  { name = "Laptop",fiyat=4500, stok=50});

            //Console.WriteLine("İşlem Tamamlandı . Komut : ");
            //Console.ReadLine();

            #endregion

            #region Çoklu parametre ile yollamak (bir dizi içerisinde )



            //var conn = new SqlConnection();
            //conn.ConnectionString = "server=BERKAY_MONSTER; database=UdemyDapperDb; integrated security = true";


            //conn.Execute("insert into Products values (@name,@fiyat,@stok)", new [] {

            //new {name="Monitör",fiyat=500,stok=300 },
            //new {name="Telefon",fiyat=500,stok=300 }
            
            //});

            //Console.WriteLine("İşlem Tamamlandı . Komut : ");
            //Console.ReadLine();



            #endregion




        }
    }
}
