using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Billing_System_New.DataAccess
{
    internal interface IDataAccess<TEntity, in TPK> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAsync();
        Task<TEntity> CreatAsync(TEntity entity);
        Task<TEntity> GetbyId(TPK ID);
        Task<TEntity> UpdateAsync(TPK ID, TEntity entity);
        Task<TEntity> DeleteAsync(TPK ID);
    }

    internal interface IDataAccess1<TEntity, in TPK> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAsync();
        Task<TEntity> CreatAsync(TEntity entity);
        Task<TEntity> GetbyId(TPK ID);
        Task<TEntity> UpdateAsync(TPK ID, TEntity entity);
        Task<TEntity> DeleteAsync(TPK ID);
    }
    internal interface IDataAccess2<TEntity, in TPK> where TEntity : class
    {
        Task<TEntity> CreatAsync(TEntity entity);
        Task<TEntity> GetbyId(TPK ID);
    }

    internal interface IDataAccess3<TEntity, in TPK> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAsync();

    }
}
