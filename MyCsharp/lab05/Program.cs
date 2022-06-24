using System;
using System.Data.SqlClient;

namespace lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateData();
            UpdateData();
            DeleteData();
            GetData();
            
        }
        public static void GetData()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection conn = connectionDb.GetConnection();
            string query = "SELECT * From product";
            SqlCommand command = new SqlCommand(query, conn);//Tao ham SqlCommand 
            
            conn.Open();
            SqlDataReader read = command.ExecuteReader();//su dung ham EndexcuteReader de doc du lieu
            while (read.Read())// su dung vong lap while va ham .Read() de duyet du lieu
            {
                Console.WriteLine("Product Name : " + read[1] + " " + "Desc : " + read[2] + " " + "Price : " + read[3]);
            }
            conn.Close();
            
        }
        public static void CreateData()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection conn = connectionDb.GetConnection();
            string query = "INSERT INTO product VALUES('BPhone','Product 2015',500)";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            int dataCount = command.ExecuteNonQuery();
            Console.WriteLine("Da them {0} ban ghi thanh cong ", dataCount);
            conn.Close();
        }
        public static void UpdateData()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection conn = connectionDb.GetConnection();
            string query = "UPDATE product SET proName = 'CPhone' WHERE proName = 'BPhone'";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            int dataCount = command.ExecuteNonQuery();
            Console.WriteLine("Da sua {0} ban ghi thanh cong ", dataCount);
            conn.Close();
        }
        public static void DeleteData()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection conn = connectionDb.GetConnection();
            string query = "DELETE FROM product WHERE proName = 'CPhone'";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            int dataCount = command.ExecuteNonQuery();
            Console.WriteLine("Da xoa {0} ban ghi thanh cong ", dataCount);
            conn.Close();
        }
    }
}
