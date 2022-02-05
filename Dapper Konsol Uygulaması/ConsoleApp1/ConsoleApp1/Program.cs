using System;
using System.Collections.Generic;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {

            var connection = new SqlConnection();
            connection.ConnectionString = "server=BERKAY_MONSTER; database=DapperDb ; integrated security = true";

            //connection.Execute("delete from Products"); // Her Bir Çalıştırma sonrasında içerisini sifirlamak için yapıyorum

            #region KLASİK ADO.NET CONNECTED MİMARİ 


            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = "server=BERKAY_MONSTER; database=DapperDb ; integrated security = true";
            //conn.Open();
            //SqlCommand cmd = conn.CreateCommand();
            //cmd.CommandText = "insert into Products values ('samsung',1,1)";
            //cmd.ExecuteNonQuery();
            //conn.Close();


            #endregion

            #region DAHA KISA KODLAR İLE DAPPER 

            /* İşlemler ADo NET içerisinde de mümkün. Örnek vermek gerekirse connection nesnesinin içerisinde sorgu direk parametrik şekilde yollanabilemktedir. */

            //var connection = new SqlConnection();
            //connection.ConnectionString = "server=BERKAY_MONSTER; database=DapperDb ; integrated security = true";
            //var a  = connection.Execute("insert into Products values('Dapper Geldi Hoş Geldi ',20,20)" +

            //"insert into Products values('Dapper Geldi Hoş Geldi ',20,20)" 
            //);
            //Console.WriteLine(a);

            #endregion

            #region Execute Parametreli İnsert Methodu 
            /* İçerisindeki price name dizideki , objedeki ile string ifadedekiler ile aynı olmalıdır.*/




            //connection.Execute("insert into Products values(@name,@price,@stock)", new
            //{
            //    name = "Laptop",
            //    price = 4500,
            //    stock = 50
            //});


            //connection.Execute("insert into Products values(@name,@price,@stock)", new[]
            //{
            //    new {name="Moitör", price=4500, stock=30},
            //    new {name="Mouse", price=500, stock=25}
            //});


            #endregion

            #region Update İşlemi : 

            // Küçük Çaplı Bir uygulama yazacagım


            //basa2:


            //    var degisken = connection.Query("select * from Products");
            //    Console.WriteLine("ÜRÜNLER : ");
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    basa:
            //    foreach (var item in degisken)
            //    {
            //        Console.WriteLine(item.Id + " - " + item.Name + " - " + item.Price + " - " + item.Stock );
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine();

            //    Console.WriteLine("Değişiklik Yapılacak Ürünün İD numarasını Seçiniz ");
            //    Console.WriteLine();
            //    Console.Write("İD:");
            //     if ( int.TryParse(Console.ReadLine(), out int result))
            //    {
            //        bool durum = false;
            //        foreach (var item in degisken)
            //        {
            //            if (item.Id == result)
            //            {
            //                durum = true;
            //                break;
            //            }
            //        }
            //        if (durum)
            //        {
            //            Console.WriteLine("Yapmak istediğiniz değişikliği seçiniz ");
            //            Console.WriteLine();
            //            Console.Write("STOCK :");

            //            int a = Convert.ToInt32(Console.ReadLine());

            //            connection.Execute("update Products set Stock = @stock where Id = @id", new
            //            {
            //                Stock = a,

            //                id = result

            //            });

            //            Console.Clear();

            //            Console.WriteLine("Güncellenme Sağlanmıştır");
            //            goto basa2;


            //        }
            //        else
            //        {
            //            Console.WriteLine("Böyle Bir ürün mevcut değil ");
            //            goto basa;

            //        }



            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı işlem Lütfen Tekrar deneyiniz");
            //        bitis:
            //        goto basa;
            //    }
            #endregion

            #region Update İşlemi : 

            //connection.Execute("update Products set Stock = @stock where Id = @id", new
            //{
            //    Stock = 50,
            //    id = 50
            //});


            //connection.Execute("update Products set Stock = @stock where Id = @id", new[]

            //{
            //    new {Stock = 64,  id = 64},
            //    new {Stock = 65,  id = 65},
            //    new {Stock = 66,  id = 66},

            //});



            //Console.WriteLine("Güncellenme Sağlanmıştır");


            #endregion


            #region Delete 

            //            connection.Execute("DELETE FROM Products where Id=@id", new[]
            //{ new { id = 1 }, new { id = 2 } });


            //            connection.Execute("DELETE FROM Products where Id=@id", new[]
            //            { new { id = 24 }, new { id = 23 }, new { id = 22 }, new { id = 21 } });



            #endregion

            #region ExecuteScalar Methodu 


            //var value = connection.ExecuteScalar("select * from Products");

            //Console.WriteLine(value);

            #endregion

            #region Execute Scalar 2. Önrek


            //var value = connection.ExecuteScalar("select Name from Products where Id = 65 ");

            //Console.WriteLine(value);


            #endregion


            // 7 : 00 
            #region Verable - Dynamic data type

            var a = 5;
            a = 10;

                Console.WriteLine( a );

            #endregion
            Console.ReadLine();






        }
    }
}
