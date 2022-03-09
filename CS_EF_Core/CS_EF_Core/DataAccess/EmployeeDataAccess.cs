using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_EF_Core.Models;
using Microsoft.EntityFrameworkCore;


namespace CS_EF_Core.DataAccess
{
    internal class EmployeeDataAccess : IDataAccess1<Employee, int>
    {
        Enterprise1Context ctx;
        public EmployeeDataAccess()
        {
            ctx = new Enterprise1Context();
        }

       async Task<Employee?> IDataAccess1<Employee, int>.CreatAsync(Employee entity)
        {
            try
            {
                var Result = await ctx.Employees.AddAsync(entity);
                await ctx.SaveChangesAsync();
                return Result.Entity;    // Return newly CReated ENtity

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<Employee?> IDataAccess1<Employee, int>.DeleteAsync(int ID)
        {
            try
            {
                var EmpFind = await ctx.Employees.FindAsync(ID);
                if (EmpFind == null)
                {
                    return null;
                }
                ctx.Employees.Remove(EmpFind);
                await ctx.SaveChangesAsync();
                return EmpFind;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

       async Task<IEnumerable<Employee>> IDataAccess1<Employee, int>.GetAsync()
        {
            try
            {
                var result = await ctx.Employees.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;

            }
        }

       

        async Task<Employee?> IDataAccess1<Employee, int>.UpdateAsync(int ID, Employee entity)
        {
            try
            {
                var EmpUpdate = await ctx.Employees.FindAsync(ID);
                if (EmpUpdate == null)
                {
                    return null;
                }
                EmpUpdate.EmpNo = entity.EmpNo;
                EmpUpdate.EmpName = entity.EmpName;
                EmpUpdate.Salary = entity.Salary;
                EmpUpdate.Designation = entity.Designation;
                EmpUpdate.DeptNo= entity.DeptNo;
                EmpUpdate.Email= entity.Email;
                await ctx.SaveChangesAsync();
                return EmpUpdate;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }
        async Task<Employee> IDataAccess1<Employee, int>.GetbyId(int ID)
        {
            try
            {
                var DeptFindID = await ctx.Employees.FindAsync(ID);
                if (DeptFindID == null)
                {
                    return null;
                }
                //await ctx.SaveChangesAsync();
                return DeptFindID;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
