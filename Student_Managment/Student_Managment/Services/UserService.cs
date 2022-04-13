using Microsoft.EntityFrameworkCore;
using Student_Managment.Models;

namespace Student_Managment.Services
{
    public class UserService : IService<UserInfo, int>
    {
        private readonly StudentManagmentContext context;
        public UserService(StudentManagmentContext context)
        {
            this.context = context;
        }
       async Task<UserInfo> IService<UserInfo, int>.CreateAsync(UserInfo entity)
        {
            var res=await context.UserInfos.AddAsync(entity);
            await context.SaveChangesAsync();
            return res.Entity;
         
        }

        Task<UserInfo> IService<UserInfo, int>.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<UserInfo>> IService<UserInfo, int>.GetAsync()
        {
            var res = await context.UserInfos.ToListAsync();
            return res;
        }

        async Task<UserInfo> IService<UserInfo, int>.GetAsync(int id)
        {
           var res=await context.UserInfos.FindAsync(id);
            if(res==null)
            {
                return null;
            }
            return res;
        }

        Task<UserInfo> IService<UserInfo, int>.UpdateAsync(int id, UserInfo entity)
        {
            throw new NotImplementedException();
        }
    }
}
