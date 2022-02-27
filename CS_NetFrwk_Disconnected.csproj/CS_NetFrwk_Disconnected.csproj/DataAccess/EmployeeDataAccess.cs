using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Using Models and Database Namespaces
using System.Data;
using System.Data.SqlClient;
using CS_NetFrwk_Disconnected;

namespace CS_NetFrwk_Disconnected.DataAccess
{
    internal class EmployeeDataAccess : IDataAccess<Employee>
    {
        SqlConnection Conn;

        /// <summary>
        /// Instantite the SqlConnection by passing ConnectionString to
        /// Constructor of the SqlConnection
        /// </summary>
        public EmployeeDataAccess()
        {

            Conn = new SqlConnection("Data Source=.;Initial Catalog=Enterprise1;Integrated Security=SSPI");
        }



        void IDataAccess<Employee>.Create()
        {
            SqlDataAdapter AdDept = new SqlDataAdapter("Select * from Employee", Conn);
            DataSet Ds = new DataSet();
            AdDept.Fill(Ds, "Employee");
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
            SqlCommandBuilder bldr1 = new SqlCommandBuilder(AdDept);

            // 5. Call Update
            AdDept.Update(Ds, "Employee");

            if (DrNew != null)
            {
                Console.WriteLine("New Data added.....");
            }
        }

      

        void IDataAccess<Employee>.Delete()
        {
            SqlDataAdapter AdDept = new SqlDataAdapter("Select * from Employee", Conn);
            AdDept.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet Ds = new DataSet();
            AdDept.Fill(Ds, "Employee");
            //1. Search Record BAsed on Primary Key
            Console.WriteLine("Enter EmpNo for delete");
            int delete = Convert.ToInt32(Console.ReadLine());
            DataRow DrFind = Ds.Tables["Employee"].Rows.Find(delete);

            // 2. Call Delete() method on the searched record
            DrFind.Delete();
            if (DrFind == null)
            {
                Console.WriteLine("Data Deleted Successfully.....");
            }

            // 3. Command Build and Update
            SqlCommandBuilder bldr2 = new SqlCommandBuilder(AdDept);
            AdDept.Update(Ds, "Employee");



        }

       

        void IDataAccess<Employee>.GetData()
        {
            // Conn = new SqlConnection("Data Source=.;Initial Catalog=Enterprise1;Integrated Security=SSPI");
            SqlDataAdapter AdDept = new SqlDataAdapter("Select * from Employee", Conn);
            DataSet Ds = new DataSet();
            AdDept.Fill(Ds, "Employee");
            Console.WriteLine("List of Records from Employee Table");
            DataRowCollection dataRows = Ds.Tables["Employee"].Rows;

            foreach (DataRow row in dataRows)
            {

                Console.WriteLine($"{row["EmpNo"]}     {row["EmpName"]}       {row["salary"]}       {row["Designation"]}    {row["DeptNo"]}    {row["Email"]}");
            }

        }

     

        void IDataAccess<Employee>.Update()
        {
            SqlDataAdapter AdDept = new SqlDataAdapter("Select * from Employee", Conn);
            AdDept.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet Ds = new DataSet();
            AdDept.Fill(Ds, "Employee");

            //1. Search Record BAsed on Primary Key
            Console.WriteLine("Enter EmpNO for Search and Update");
            int search = Convert.ToInt32(Console.ReadLine());

            DataRow DrFind = Ds.Tables["Employee"].Rows.Find(search);

            // 2. Update its Values
            Console.WriteLine("Enter EmpName");
            DrFind["EmpName"] = Console.ReadLine();

            Console.WriteLine("Enter salary");
            DrFind["salary"] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Designation");
            DrFind["Designation"] = Console.ReadLine();

            Console.WriteLine("Enter DeptNo");
            DrFind["DeptNo"] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Email");
            DrFind["Email"] = Console.ReadLine();

            // 3. Command Build and Update
            SqlCommandBuilder bldr2 = new SqlCommandBuilder(AdDept);
            AdDept.Update(Ds, "Employee");

            if (DrFind != null)
            {
                Console.WriteLine("Data Updates Successfully.....");
            }


        }

      
    }
}

