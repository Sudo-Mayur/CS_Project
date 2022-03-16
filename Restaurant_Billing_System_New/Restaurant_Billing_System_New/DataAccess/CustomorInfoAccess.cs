using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Billing_System_New.Models;
using Microsoft.EntityFrameworkCore;


namespace Restaurant_Billing_System_New.DataAccess
{
    internal class CustomorInfoAccess : IDataAccessCustomorInfo<CustomorInfo, int>
    {
        restaurantContext ctx;
        public CustomorInfoAccess()
        {
            ctx = new restaurantContext();
        }

        async Task<CustomorInfo> IDataAccessCustomorInfo<CustomorInfo, int>.CreatAsync(CustomorInfo entity)
        {
            try
            {
                var Result = await ctx.CustomorInfos.AddAsync(entity);
                await ctx.SaveChangesAsync();
                return Result.Entity;   // Return newly CReated ENtit

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }


        async Task<CustomorInfo> IDataAccessCustomorInfo<CustomorInfo, int>.GetbyId(int ID)
        {
            try
            {
                var billID = await ctx.CustomorInfos.FindAsync(ID);
                if (billID == null)
                {
                    return null;
                }
                return billID;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }

        }
    }
}
