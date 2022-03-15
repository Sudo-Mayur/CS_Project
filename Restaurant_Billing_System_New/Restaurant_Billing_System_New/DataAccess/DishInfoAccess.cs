using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Billing_System_New.Models;
using Microsoft.EntityFrameworkCore;


namespace Restaurant_Billing_System_New.DataAccess
{
    internal class DishInfoAccess : IDataAccess<DishInfo, int>
    {
        restaurantContext ctx;
        public DishInfoAccess()
        {
            ctx = new restaurantContext();
        }

        async Task<DishInfo> IDataAccess<DishInfo, int>.CreatAsync(DishInfo entity)
        {
            try
            {
                var Result = await ctx.DishInfos.AddAsync(entity);
                await ctx.SaveChangesAsync();
                return Result.Entity;   // Return newly CReated ENtity

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        Task<DishInfo> IDataAccess<DishInfo, int>.DeleteAsync(int ID)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<DishInfo>> IDataAccess<DishInfo, int>.GetAsync()
        {
            try
            {
                var result = await ctx.DishInfos.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<DishInfo> IDataAccess<DishInfo, int>.GetbyId(int ID)
        {
            try
            {
                var result = await ctx.DishInfos.FindAsync(ID);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        Task<DishInfo> IDataAccess<DishInfo, int>.UpdateAsync(int ID, DishInfo entity)
        {
            throw new NotImplementedException();
        }
    }
}
