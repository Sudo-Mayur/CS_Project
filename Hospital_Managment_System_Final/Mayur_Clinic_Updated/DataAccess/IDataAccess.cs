using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayur_Clinic_Updated.DataAccess
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

        Task<TEntity> UpdateAsync(TPK ID, TEntity entity);
        Task<TEntity> CreatAsync(TEntity entity);

        // Task<TEntity> GetbyId(TPK ID);
        //Task<TEntity> UpdateAsync(TPK ID, TEntity entity);
        Task<TEntity> DeleteAsync(TPK ID);
    }

    internal interface IDataAccessPatient<TEntity, in TPK> where TEntity : class
    {
      
        Task<TEntity> GetbyId(TPK ID);
       
    }
}
