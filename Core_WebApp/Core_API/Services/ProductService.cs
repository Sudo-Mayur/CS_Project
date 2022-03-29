using Core_API.ModelClasses;
using Core_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Core_API.Services
{
    public class ProductService : IService<Product, int>

    {
        private readonly ApiDbContext context;
        public ProductService(ApiDbContext context)
        {
            this.context = context;

        }
        async Task<Product> IService<Product, int>.CreateAsync(Product entity)
        {
            var res=await context.Products.AddAsync(entity);
            await context.SaveChangesAsync();
            return res.Entity;
        }

        async Task<Product> IService<Product, int>.DeleteAsync(int id)
        {
            var res =await context.Products.FindAsync(id);
            if(res==null)
            {
                return null;
            }
            context.Products.Remove(res);
            await context.SaveChangesAsync();
            return res;
        }

        async Task<IEnumerable<Product>> IService<Product, int>.GetAsync()
        {
            var res = await context.Products.ToListAsync();
            return res;
        }

        async Task<Product> IService<Product, int>.GetAsync(int id)
        {
            var res=await context.Products.FindAsync(id);
            return res;
        }

        async Task<Product> IService<Product, int>.UpdateAsync(int id, Product entity)
        {
            var res = await context.Products.FindAsync(id);
            if(res!=null)
            {
                context.Entry(res).CurrentValues.SetValues(entity);
                await context.SaveChangesAsync();
                return res;
            }
            else
            {
                return null;
            }

        }
    }
}
