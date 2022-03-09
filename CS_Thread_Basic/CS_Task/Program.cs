using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("handling multiple task");
            Task task = Task.Run(() =>
            {
                Runtask();
            });
            Console.WriteLine("Back to Main");
            Console.ReadLine();
        }
        static void Runtask()
        {
            Task T1 = new Task(() =>
              {
                  Console.WriteLine("Task T1");
              });
            Task T2 = new Task(() =>
            {
                Console.WriteLine("task T2");
            });
            Task T3 = new Task(() =>
             {
                 Console.WriteLine("Task T3");
             });

            T1.Start();
            T2.Start();
            T3.Start();

            Task T4 = new Task(() =>
              {
                  SqlConnection Conn = new SqlConnection("Data Source=.; Initial Catalog=Enterprise1;Integrated Security=SSPI");
                  Conn.Open();
                  SqlCommand sqlCommand = new SqlCommand();
                  sqlCommand.Connection = Conn;
                  sqlCommand.CommandText = "select *from Department";
                  SqlDataReader reader = sqlCommand.ExecuteReader();
                  while (reader.Read())
                  {
                      Console.WriteLine($"DeptNo: {reader["DeptNo"]} DeptNo: {reader["DeptName"]}");
                  }
                  reader.Close();
                  Conn.Close();
                  Conn.Dispose();
              });
            T4.Start();
        }
    }
}




