using Microsoft.EntityFrameworkCore;
using WebApplicationNew_Employeee.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplicationNew_Employeee.Services
{
    public class EmployeeService : IService<Employee, int>
    {
        private readonly Enterprise1Context ctx;

        public EmployeeService(Enterprise1Context ctx)
        {
            this.ctx = ctx;
        }

        async Task<Employee> IService<Employee, int>.Create(Employee entity)
        {
            try
            {
                var result = await ctx.Employees.AddAsync(entity);
                await ctx.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        async Task<Employee> IService<Employee, int>.DeleteAsync(int id)
        {
            try
            {
                var EmpFind = await ctx.Employees.FindAsync(id);
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

        async Task<IEnumerable<Employee>> IService<Employee, int>.GetAsync()
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

        async Task<Employee> IService<Employee, int>.GetAsync(int id)
        {
            try
            {
                var DeptFindID = await ctx.Employees.FindAsync(id);
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

        async Task<Employee> IService<Employee, int>.UpdateAsync(int id, Employee entity)
        {
            try
            {
                var EmpUpdate = await ctx.Employees.FindAsync(id);
                if (EmpUpdate == null)
                {
                    return null;
                }
                EmpUpdate.EmpNo = entity.EmpNo;
                EmpUpdate.EmpName = entity.EmpName;
                EmpUpdate.Salary = entity.Salary;
                EmpUpdate.Designation = entity.Designation;
                EmpUpdate.DeptNo = entity.DeptNo;
                EmpUpdate.Email = entity.Email;
                await ctx.SaveChangesAsync();
                return EmpUpdate;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
