using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Using Models and Database Namespaces
using System.Data;
using System.Data.SqlClient;
using CS_NetFrwk_ConnectedApp.Models;

namespace CS_NetFrwk_ConnectedApp.DataAccess
{
    internal class EmplyeeDataAccess : IDataAccess<Employee, int>
    {
        SqlConnection Conn;
        SqlCommand Cmd;
        /// <summary>
        /// Instantite the SqlConnection by passing ConnectionString to
        /// Constructor of the SqlConnection
        /// </summary>
        public EmplyeeDataAccess()
        {
            Conn = new SqlConnection("Data Source=.;Initial Catalog=Enterprise1;Integrated Security=SSPI");
        }

        /// <summary>
        /// Create a new Department Record 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Employee IDataAccess<Employee, int>.Create(Employee entity)
        {
            Employee employee = null;
            try
            {
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = $"Insert into Employee Values({entity.EmpNo}, '{entity.EmpName}', '{entity.salary}',{entity.Designation},'{entity.DeptNo}','{entity.Email}')";
                // Execute the Command Object
                int res = Cmd.ExecuteNonQuery();
                if (res == 0) // Some Error Occured
                {
                    employee = null;
                }
                else
                {
                    // if successful store the entity into the department
                    employee = new Employee();
                    employee = entity;
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally // this will be executed irrespective of try or catch block
            {
                // if the Connection is still open the close it
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            return employee;
        }

        Employee IDataAccess<Employee, int>.Delete(int id)
        {
           
                Employee employee = new Employee();
                try
                {
               
                    Conn.Open();
                    // Create paramerized query
                    Cmd.CommandText = "Delete From Employee where EmpNo=@EmpNo";

                    SqlParameter pEmpNo = new SqlParameter();
                    pEmpNo.ParameterName = "@EmpNo";
                    pEmpNo.SqlDbType = SqlDbType.Int;
                    pEmpNo.Direction = ParameterDirection.Input;
                    pEmpNo.Value = id;



                    // Add parameters into the Parameters Collection of the Command object
                    Cmd.Parameters.Add(pEmpNo);

                    // Call the execute method
                    int res = Cmd.ExecuteNonQuery();

                    if (res == 0)
                    {
                        employee = null;
                    }
               
            }
        
            // for one try there can be multiple catch
            // make sure that the specific catch appears before 
            // the general catch (i.e. Exception class)
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            return employee;
        }

        IEnumerable<Employee> IDataAccess<Employee, int>.GetData()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                // Open
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = "Select * from Employee";
                SqlDataReader Reader = Cmd.ExecuteReader();

                // Iterate over the Reader for Employee Rows
                while (Reader.Read())
                {
                    // Read each row using the Reader
                    // and add it into the employees list by storing
                    // each column value of the record into the Employee object
                    employees.Add(
                          new Employee()
                          {
                              EmpNo = Convert.ToInt32(Reader["EmpNo"]),
                              EmpName = Reader["EmpName"].ToString(),
                              salary = Convert.ToInt32(Reader["salary"]),
                              Designation = Reader["Designation"].ToString(),
                              DeptNo = Convert.ToInt32(Reader["DeptNo"]),
                              Email = Reader["Email"].ToString()


                          }
                        );
                }
                Reader.Close();
                // Close
                Conn.Close();
            }
            catch (SqlException ex)
            {


                throw ex;
            }
            finally // this will be executed irrespective of try or catch block
            {
                // if the Connection is still open the close it
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            return employees;
        }
        /// <summary>
        /// Return a Single Record based on id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Employee IDataAccess<Employee, int>.GetData(int id)
        {
            Employee employee = new Employee();
            try
            {
                Conn.Open();
                // We can also pass the Command Tetx and Commection Object to the Constrctor
                Cmd = new SqlCommand($"Select * from Employee where EmpNo = {id}", Conn);
                SqlDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    employee.EmpNo = Convert.ToInt32(Reader["EmpNo"]);
                    employee.EmpName = Reader["EmpName"].ToString();
                    employee.salary = Convert.ToInt32(Reader["salary"]);
                    employee.Designation = Reader["Designation"].ToString();
                    employee.DeptNo = Convert.ToInt32(Reader["DeptNo"]);
                    employee.Email = Reader["Email"].ToString();
                }
                Reader.Close();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            return employee;
        }

        /// <summary>
        /// Using the Parameterized Query
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        Employee IDataAccess<Employee, int>.Update(int id, Employee entity)
        {
            Employee employee = new Employee();
            try
            {
                // check if id and the EmpNo value of the entity is same
               // id=Convert.ToInt32(Console.ReadLine());
                if (id == entity.EmpNo)
                {
                    Conn.Open();
                    // Create paramerized query
                    Cmd.CommandText = "Update Employee Set  EmpName=@EmpName, salary=@salary, Designation=@Designation, DeptNo=@DeptNo, Email=@Email where EmpNo=@EmpNo";

                    SqlParameter pEmpNo = new SqlParameter();
                    pEmpNo.ParameterName = "@EmpNo";
                    pEmpNo.SqlDbType = SqlDbType.Int;
                    pEmpNo.Direction = ParameterDirection.Input;
                    pEmpNo.Value = id;


                    SqlParameter pEmpName = new SqlParameter();
                    pEmpName.ParameterName = "@EmpName";
                    pEmpName.SqlDbType = SqlDbType.VarChar;
                    pEmpName.Size = 200;
                    pEmpName.Direction = ParameterDirection.Input;
                    pEmpName.Value = entity.EmpName;

                    SqlParameter psalary = new SqlParameter();
                    psalary.ParameterName = "@salary";
                    psalary.SqlDbType = SqlDbType.Int;
                    psalary.Direction = ParameterDirection.Input;
                    psalary.Value = entity.salary;

                    SqlParameter pDesignation = new SqlParameter();
                    pDesignation.ParameterName = "@Designation";
                    pDesignation.SqlDbType = SqlDbType.VarChar;
                    pDesignation.Size = 200;
                    pDesignation.Direction = ParameterDirection.Input;
                    pDesignation.Value = entity.Designation;

                    SqlParameter pDeptNo = new SqlParameter();
                    pDeptNo.ParameterName = "@DeptNo";
                    pDeptNo.SqlDbType = SqlDbType.Int;
                    pDeptNo.Direction = ParameterDirection.Input;
                    pDeptNo.Value = entity.DeptNo;

                    SqlParameter pEmail = new SqlParameter();
                    pEmail.ParameterName = "@Email";
                    pEmail.SqlDbType = SqlDbType.VarChar;
                    pEmail.Size = 200;
                    pEmail.Direction = ParameterDirection.Input;
                    pEmail.Value = entity.Email;


                    // Add parameters into the Parameters Collection of the Command object
                    Cmd.Parameters.Add(pEmpNo);
                    Cmd.Parameters.Add(pEmpName);
                    Cmd.Parameters.Add(psalary);
                    Cmd.Parameters.Add(pDesignation);
                    Cmd.Parameters.Add(pDeptNo);
                    Cmd.Parameters.Add(pEmail);



                    // Call the execute method
                    int res = Cmd.ExecuteNonQuery();

                    if (res == 0)
                    {
                        employee = null;
                    }
                    else
                    {
                        employee = entity;
                    }
                }
                else
                {
                    throw new Exception($"the {id} and {entity.EmpNo} does not match");
                }
            }
            // for one try there can be multiple catch
            // make sure that the specific catch appears before 
            // the general catch (i.e. Exception class)
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            return employee;
        }
    }
}