using Microsoft.EntityFrameworkCore;
using Sample_Web_App.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample_Web_App.Services
{
    public class UserService:IService<UserInfo,int>
    {
        private readonly Enterprise1Context ctx;
        /// <summary>
        ///
        /// </summary>
        public UserService(Enterprise1Context ctx)
        {
            this.ctx = ctx;
        }

        async Task<UserInfo> IService<UserInfo, int>.Create(UserInfo entity)
        {
            try
            {
                var Result = await ctx.UserInfos.AddAsync(entity);
                await ctx.SaveChangesAsync();
                return Result.Entity;    // Return newly CReated ENtity

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<UserInfo> IService<UserInfo, int>.DeleteAsync(int id)
        {
            try
            {
                var UserFind = await ctx.UserInfos.FindAsync(id);
                if (UserFind == null)
                {
                    return null;
                }
                ctx.UserInfos.Remove(UserFind);
                await ctx.SaveChangesAsync();
                return UserFind;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<IEnumerable<UserInfo>> IService<UserInfo, int>.GetAsync()
        {
            try
            {
                var result = await ctx.UserInfos.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;

            }
        }

        async Task<UserInfo> IService<UserInfo, int>.GetAsync(int id)
        {
            try
            {
                var UserIDFind = await ctx.UserInfos.FindAsync(id);
                if (UserIDFind == null)
                {
                    return null;
                }
                //await ctx.SaveChangesAsync();
                return UserIDFind;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<UserInfo> IService<UserInfo, int>.UpdateAsync(int id, UserInfo entity)
        {
            try
            {
                var UpdateUser = await ctx.UserInfos.FindAsync(id);
                if (UpdateUser == null)
                {
                    return null;
                }
                UpdateUser.UserId = entity.UserId;
                UpdateUser.UserName = entity.UserName;
                UpdateUser.Password = entity.Password;
                
                await ctx.SaveChangesAsync();
                return UpdateUser;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
