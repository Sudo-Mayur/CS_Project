using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Billing_System_New.DataAccess
{
    internal interface IDataAccessDishInfo<TEntity, in TPK> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAsync();
        Task<TEntity> CreatAsync(TEntity entity);
        Task<TEntity> GetbyId(TPK ID);       
    }

    internal interface IDataAccessBill<TEntity, in TPK> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAsync();
        Task<TEntity> CreatAsync(TEntity entity);
        Task<TEntity> GetbyId(TPK ID);       
        Task<TEntity> DeleteAsync(TPK ID);
    }
    internal interface IDataAccessCustomorInfo<TEntity, in TPK> where TEntity : class
    {
        Task<TEntity> CreatAsync(TEntity entity);
        Task<TEntity> GetbyId(TPK ID);
    }

    internal interface IDataAccessDish<TEntity, in TPK> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAsync();
       
    }
}
