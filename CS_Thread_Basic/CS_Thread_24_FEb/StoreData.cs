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
      
        public void WriteDataToDB(Employee emp)
        {
            try
            {
                SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Enterprise1;Integrated Security=SSPI");
                SqlDataAdapter AdEmp = new SqlDataAdapter("Select * from Employee", Conn);
                AdEmp.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                DataSet Ds = new DataSet();
                AdEmp.Fill(Ds, "Employee");

                // 1. Create a new Row in the Employee DataTable in DataSet
                DataRow DrNew = Ds.Tables["Employee"].NewRow();
                // 2. Set data for all columns for the row
               
                DrNew["EmpNo"] = emp.EmpNo;               
                DrNew["EmpName"] = emp.EmpName;            
                DrNew["salary"] = emp.salary; 
                DrNew["Designation"] = emp.Designation;
                DrNew["DeptNo"] = emp.DeptNo;
                DrNew["Email"] = emp.Email;

                // 3. Add the Row into the Table
                Ds.Tables["Employee"].Rows.Add(DrNew);

                // 4. Define a Command Builder to Ask the Adpater to Update Record in Database Table
                SqlCommandBuilder bldr1 = new SqlCommandBuilder(AdEmp);

                // 5. Call Update
                AdEmp.Update(Ds, "Employee");

                //if (DrNew != null)
                //{
                //    Console.WriteLine("New Data added.....");
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Thread.CurrentThread.Abort();
            }

        }

      
        public void WriteDataToFile(Employee emp)
        {
           
                string path = @"C:\Users\Coditas\Desktop\Dotnet Training Assignments and mini projects\Employee_Salary_Slip_6";
                string filePath = $"{path}\\{emp.EmpNo}.txt";
                if (File.Exists(filePath))
                {
                    Console.WriteLine($"Specified File {filePath} is Already exists");
                   Thread.CurrentThread.Abort();

                }
                else
                {
                    FileStream f = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(f);
                    writer.WriteLine($" Empno :{emp.EmpNo}, Name:{ emp.EmpName}, Salary:{emp.salary}, Designation:{emp.Designation}, DeptNo:{emp.DeptNo}, Email:{emp.Email}");
                    writer.Close();
                    f.Close();
                    Console.WriteLine("------------------------------------------------------------------------------");

                }
            
        }
        
        public Employee GetData()
        {
           
            Employee emp = new Employee();
            Console.WriteLine("Enter EmpNo");
            emp.EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Name");
            emp.EmpName = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            emp.salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Designation");
            emp.Designation = Console.ReadLine();
            Console.WriteLine("Enter DeptNo");
            emp.DeptNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email");
            emp.Email = Console.ReadLine();
            Thread T1 = new Thread(() => WriteDataToFile(emp));
            Thread T2 = new Thread(() => WriteDataToDB(emp));
            T1.Start();
            T2.Start();

            return emp;
            

        }
        public void ReadDataFromFile(int EmpNo)
        {
            string path = @"C:\Users\Coditas\Desktop\Dotnet Training Assignments and mini projects\Employee_Salary_Slip_6";
            string filePath = $"{path}\\{EmpNo}.txt";
            if (File.Exists(filePath))
            {
                FileStream fs1 = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fs1);
                string data = reader.ReadToEnd();
                reader.Close();
                Console.WriteLine($"Data from file = \n {data}");
                fs1.Close();
                Console.WriteLine("------------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("File Not Exists");
                Thread.CurrentThread.Abort();
            }




        }

        public void ReadDataFromDB(int Id)
        {            
            try
            {
                SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Enterprise1;Integrated Security=SSPI");
                SqlDataAdapter AdEmp = new SqlDataAdapter("Select * from Employee", Conn);
                AdEmp.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                DataSet Ds = new DataSet();
                AdEmp.Fill(Ds, "Employee");
                Console.WriteLine("List of Records from Employee Table");
                DataRow row = Ds.Tables["Employee"].Rows.Find(Id);
                Console.WriteLine($"{row?["EmpNo"]}     {row?["EmpName"]}       {row?["salary"]}       {row?["Designation"]}    {row?["DeptNo"]}    {row?["Email"]}");

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public int UserInput()
        {
            Console.WriteLine("enter Empno for reading the data");
            int EmpNo=Convert.ToInt32(Console.ReadLine());

            Thread T3 = new Thread(() => ReadDataFromFile(EmpNo));
            Thread T4 = new Thread(() => ReadDataFromDB(EmpNo));
            T3.Start();
            T4.Start();
            return EmpNo;
        }
     
        }

    }

