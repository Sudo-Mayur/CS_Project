using Microsoft.EntityFrameworkCore;
using Sample_Web_App.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample_Web_App.Services
{
    public class DepartmentService : IService<Department, int>
    {
        private readonly Enterprise1Context ctx;
        /// <summary>
        ///
        /// </summary>
        public DepartmentService(Enterprise1Context ctx)
        {
            this.ctx = ctx;
        }

        async Task<Department> IService<Department, int>.Create(Department entity)
        {
            try
            {
                var Result = await ctx.Departments.AddAsync(entity);
                await ctx.SaveChangesAsync();
                return Result.Entity;    // Return newly CReated ENtity

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<Department> IService<Department, int>.DeleteAsync(int id)
        {
            try
            {
                var DeptFind = await ctx.Departments.FindAsync(id);
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

        async Task<IEnumerable<Department>> IService<Department, int>.GetAsync()
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

        async Task<Department> IService<Department, int>.GetAsync(int id)
        {
            try
            {
                var DeptFindID = await ctx.Departments.FindAsync(id);
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

        async Task<Department> IService<Department, int>.UpdateAsync( int id,Department entity)
        {
            try
            {
                var DeptUpdate = await ctx.Departments.FindAsync(id);
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
    }
}
