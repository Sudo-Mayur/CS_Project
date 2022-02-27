using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization.Formatters.Binary;
using CS_Thread_24_FEb.Model;
namespace CS_Thread_24_FEb
{
    internal class StoreData
    {
        public  void WriteDataToDB()
        {
            try
            {
                SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Enterprise1;Integrated Security=SSPI");
                SqlDataAdapter AdEmp = new SqlDataAdapter("Select * from Employee", Conn);
                AdEmp.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                DataSet Ds = new DataSet();
                AdEmp.Fill(Ds, "Employee");

                // 1. Create a new Row in the Department DataTable in DataSet
                DataRow DrNew = Ds.Tables["Employee"].NewRow();
                // 2. Set data for all columns for the row
                Console.WriteLine("Enter EmpNo");
                DrNew["EmpNo"] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter EmpName");
                DrNew["EmpName"] = Console.ReadLine();

                Console.WriteLine("Enter salary");
                DrNew["salary"] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Designation");
                DrNew["Designation"] = Console.ReadLine();

                Console.WriteLine("Enter DeptNo");
                DrNew["DeptNo"] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Email");
                DrNew["Email"] = Console.ReadLine();
                // 3. Add the Row into the Table
                Ds.Tables["Employee"].Rows.Add(DrNew);
                // 4. Define a Command Builder to Ask the Adpater to Update Record in Database Table
                SqlCommandBuilder bldr1 = new SqlCommandBuilder(AdEmp);
                // 5. Call Update
                AdEmp.Update(Ds, "Employee");

                if (DrNew != null)
                {
                    Console.WriteLine("New Data added.....");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

        }

        //public void WriteDataToFile()
        //{
        //    Employee emp=new Employee();
        //    Console.WriteLine("Enter EmpNo");
        //    emp.EmpNo = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Your Name ");
        //    emp.EmpName=Console.ReadLine();
        //    Console.WriteLine("Enter Salary");
        //    emp.salary=Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Designation");
        //    emp.Designation=Console.ReadLine();
        //    Console.WriteLine("Enter DeptNo");
        //    emp.DeptNo = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Email");
        //    emp.Email=Console.ReadLine();

        //    //Console.WriteLine("DEMO Serialization");
        //    string path = @"C:\Users\Coditas\source\repos\CS_Thread_Basic\CS_Thread_24_FEb\MyFile.txt";

        //    // 1. Create a FileStream
        //    FileStream fs = new FileStream(path, FileMode.CreateNew);

        //    //if (File.Exists(path))
        //    //{
        //    //    Console.WriteLine("File created");
        //    //}
        //    //else
        //    //{
        //    //    Console.WriteLine("File is alredy");
        //    //}


        //    // 2. Define a Formatter
        //    // This will provide a format conversion for the Object that is to be serialized
        //    BinaryFormatter formatter = new BinaryFormatter();
        //    // 4. Serialize
        //    formatter.Serialize(fs, emp);

        //    // 5. Close the Stream
        //    fs.Close();

        //    // 6. Deserialize
        //    // 6.a. Open the Stream for Read
        //    fs = new FileStream(@"C:\Users\Coditas\source\repos\CS_Thread_Basic\CS_Thread_24_FEb\MyFile.txt", FileMode.Open, FileAccess.Read);
        //    Employee emp1 = (Employee)formatter.Deserialize(fs);

        //    Console.WriteLine($"EmpNo: {emp1.EmpNo}, EmpName: {emp1.EmpName}, " +
        //       $"salary: {emp1.salary}," +
        //       $"Designation: {emp1.Designation}, DeptNo: {emp1.DeptNo}"
        //       +$"Email: {emp1.Email}");

        //    // 6.c. Closing the Stream
        //    fs.Close();


        public void WriteDataToFile()
        {
            Employee emp = new Employee();
            Console.WriteLine("Enter EmpNo");
            emp.EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Name ");
            emp.EmpName = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            emp.salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Designation");
            emp.Designation = Console.ReadLine();
            Console.WriteLine("Enter DeptNo");
            emp.DeptNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email");
            emp.Email = Console.ReadLine();

            string path = @"C:\Users\Coditas\Desktop\Dotnet Training Assignments and mini projects\Employee_Salary_Slip_6";
            string filePath = $"{path}\\{emp.EmpName}.txt";
            if(File.Exists(filePath))
            {
                Console.WriteLine($"Specified File {filePath} is Already exists");
            }
            else
            {
                FileStream F = File.Create(filePath);
                byte[] content = new UTF8Encoding(true).GetBytes($" Empno :{emp.EmpNo}, Name:{ emp.EmpName}, Salary:{emp.salary}, Designation:{emp.Designation}, DeptNo:{emp.DeptNo}, Email:{emp.Email}");
                F.Write(content, 0, content.Length);
                F.Close();
                if (content!=null)
                {
                    Console.WriteLine("Data Added");
                   
                }
               

            }
          
        }



    }
}
