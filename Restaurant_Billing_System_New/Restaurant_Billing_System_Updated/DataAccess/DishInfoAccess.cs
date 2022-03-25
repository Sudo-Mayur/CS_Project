using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Billing_System_Updated.Models;
using Microsoft.EntityFrameworkCore;


namespace Restaurant_Billing_System_Updated.DataAccess
{
    internal class DishInfoAccess : IDataAccessDishInfo<DishInfo, int>
    {
        restaurantContext ctx;
        public DishInfoAccess()
        {
            ctx = new restaurantContext();
        }

        async Task<DishInfo> IDataAccessDishInfo<DishInfo, int>.CreatAsync(DishInfo entity)
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


        async Task<IEnumerable<DishInfo>> IDataAccessDishInfo<DishInfo, int>.GetAsync()
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

        async Task<DishInfo> IDataAccessDishInfo<DishInfo, int>.GetbyId(int ID)
        {
            try
            {
                var result = await ctx.DishInfos.FindAsync(ID);
                if (result == null)
                {
                    return null;
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

    }
}
