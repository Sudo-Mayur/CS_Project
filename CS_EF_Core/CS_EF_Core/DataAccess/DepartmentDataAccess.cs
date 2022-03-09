using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using CS_EF_Core.Models;

namespace CS_EF_Core.DataAccess
{
    internal class DepartmentDataAccess : IDataAccess<Department, int>
    {
        Enterprise1Context ctx;
        public DepartmentDataAccess()
        {
            ctx = new Enterprise1Context();
        }

        async Task<Department> IDataAccess<Department, int>.CreatAsync(Department entity)
        {

            try
            {
                var Result = await ctx.Departments.AddAsync(entity);
                await ctx.SaveChangesAsync();
                return Result.Entity;    // Return newly CReated ENtity

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
                return null;               
            }
            

        }

        async Task<Department> IDataAccess<Department, int>.DeleteAsync(int ID)
        {

            try
            {
                var DeptFind = await ctx.Departments.FindAsync(ID);
                if (DeptFind == null)
                {
                    return null;
                }
                ctx.Departments.Remove(DeptFind);
                await ctx.SaveChangesAsync();
                return DeptFind;
            }
            catch (Exception ex)
            {
               
                Console.WriteLine(ex.Message);
                return null;
            }
           
        }

        async Task<IEnumerable<Department>> IDataAccess<Department, int>.GetAsync()
        {

            try
            {
                var result = await ctx.Departments.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
                return null;

            }
        }


        async Task<Department> IDataAccess<Department, int>.UpdateAsync(int ID, Department entity)
        {
            try
            {
                var DeptUpdate = await ctx.Departments.FindAsync(ID);
                if (DeptUpdate == null)
                {
                    return null;
                }
                DeptUpdate.DeptNo = entity.DeptNo;
                DeptUpdate.DeptName = entity.DeptName;
                DeptUpdate.Location = entity.Location;
                DeptUpdate.Capacity = entity.Capacity;
                await ctx.SaveChangesAsync();
                return DeptUpdate;

            }
            catch (Exception ex)
            {
               
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<Department> IDataAccess<Department, int>.GetbyId(int ID)
        {
            try
            {
                var DeptFindID = await ctx.Departments.FindAsync(ID);
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
