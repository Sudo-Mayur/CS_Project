namespace Student_Managment.Services
{
    public interface IService<TEntity, in TPK> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAsync();
        Task<TEntity> GetAsync(TPK id);
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TPK id, TEntity entity);
        Task<TEntity> DeleteAsync(TPK id);
    }
}
