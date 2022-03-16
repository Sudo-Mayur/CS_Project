using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Billing_System_New.Models;
using Microsoft.EntityFrameworkCore;

namespace Restaurant_Billing_System_New.DataAccess
{
    internal class DishAccess : IDataAccessDish<Dish, int>
    {
        restaurantContext ctx;
        public DishAccess()
        {
            ctx = new restaurantContext();
        }

        async Task<IEnumerable<Dish>> IDataAccessDish<Dish, int>.GetAsync()
        {
            try
            {
                var result = await ctx.Dishes.ToListAsync();
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
