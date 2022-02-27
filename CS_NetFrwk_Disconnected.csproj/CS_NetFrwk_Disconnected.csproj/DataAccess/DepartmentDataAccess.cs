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
    internal class DepartmentDataAccess : IDataAccess<Department>
    {
        SqlConnection Conn;

        /// <summary>
        /// Instantite the SqlConnection by passing ConnectionString to
        /// Constructor of the SqlConnection
        /// </summary>
        public DepartmentDataAccess()
        {
           
            Conn = new SqlConnection("Data Source=.;Initial Catalog=Enterprise1;Integrated Security=SSPI");
        }

       

        void IDataAccess<Department>.Create()
        {
            SqlDataAdapter AdDept = new SqlDataAdapter("Select * from Department", Conn);
            DataSet Ds = new DataSet();
            AdDept.Fill(Ds, "Department");
            // 1. Create a new Row in the Department DataTable in DataSet
            DataRow DrNew = Ds.Tables["Department"].NewRow();
            // 2. Set data for all columns for the row
            Console.WriteLine("Enter DeptNo");
            DrNew["DeptNo"] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter DeptName");
            DrNew["DeptName"] = Console.ReadLine();

            Console.WriteLine("Enter Location");
            DrNew["Location"] = Console.ReadLine();

            Console.WriteLine("Enter Capacity");
            DrNew["Capacity"] = Convert.ToInt32(Console.ReadLine());
            // 3. Add the Row into the Table
            Ds.Tables["Department"].Rows.Add(DrNew);

            
            
            // 4. Define a Command Builder to Ask the Adpater to Update Record in Database Table
            SqlCommandBuilder bldr1 = new SqlCommandBuilder(AdDept);

            // 5. Call Update
            AdDept.Update(Ds, "Department");

            if (DrNew != null)
            {
                Console.WriteLine("New Data added.....");
            }
        }

        void IDataAccess<Department>.Delete()
        {
            SqlDataAdapter AdDept = new SqlDataAdapter("Select * from Department", Conn);
            AdDept.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet Ds = new DataSet();
            AdDept.Fill(Ds, "Department");
            //1. Search Record BAsed on Primary Key
            Console.WriteLine("Enter DeptNo for delete");
            int delete = Convert.ToInt32(Console.ReadLine());
            DataRow DrFind = Ds.Tables["Department"].Rows.Find(delete);

            // 2. Call Delete() method on the searched record
             DrFind.Delete();
            if (DrFind == null)
            {
                Console.WriteLine("Data Deleted Successfully.....");
            }

            // 3. Command Build and Update
            SqlCommandBuilder bldr2 = new SqlCommandBuilder(AdDept);
             AdDept.Update(Ds, "Department");

            

        }

    
        void IDataAccess<Department>.GetData()
        {
           // Conn = new SqlConnection("Data Source=.;Initial Catalog=Enterprise1;Integrated Security=SSPI");
            SqlDataAdapter AdDept = new SqlDataAdapter("Select * from Department", Conn);
            DataSet Ds = new DataSet();
            AdDept.Fill(Ds, "Department");
            Console.WriteLine("List of Records from Department Table");
            DataRowCollection dataRows = Ds.Tables["Department"].Rows;
           
            foreach (DataRow row in dataRows)
            {
               
                Console.WriteLine($"{row["DeptNo"]}     {row["DeptName"]}       {row["location"]}       {row["Capacity"]}");
            }
           
        }

        void IDataAccess<Department>.Update()
        {
            SqlDataAdapter AdDept = new SqlDataAdapter("Select * from Department", Conn);
            AdDept.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet Ds = new DataSet();
            AdDept.Fill(Ds, "Department");

            //1. Search Record BAsed on Primary Key
            Console.WriteLine("Enter DeptNo for Search and Update");
            int search=Convert.ToInt32(Console.ReadLine());

            DataRow DrFind = Ds.Tables["Department"].Rows.Find(search);

            // 2. Update its Values
            Console.WriteLine("Enter DeptName");
            DrFind["DeptName"] = Console.ReadLine();

            Console.WriteLine("Enter Location");
            DrFind["Location"] = Console.ReadLine();

            Console.WriteLine("Enter Capacity");
            DrFind["Capacity"] =Convert.ToInt32(Console.ReadLine());

            // 3. Command Build and Update
            SqlCommandBuilder bldr2 = new SqlCommandBuilder(AdDept);
            AdDept.Update(Ds, "Department");

            if (DrFind != null)
            {
                Console.WriteLine("Data Updates Successfully.....");
            }

            
        }
    }
}