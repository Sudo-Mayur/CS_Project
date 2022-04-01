using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web_App_Job_Seeker.Models;

namespace Web_App_Job_Seeker.Services
{
    public class PersonalInfoService : IService<PersonalInfo, int>
    {
        private readonly CompanyContext ctx;
        public PersonalInfoService(CompanyContext ctx)
        {
            this.ctx = ctx;
        }

       
        async Task<PersonalInfo> IService<PersonalInfo, int>.CreateAsync(PersonalInfo entity)
        {
         
            try
            {
                var result = await ctx.PersonalInfos.AddAsync(entity);
                await ctx.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
           
        }

        async Task<PersonalInfo> IService<PersonalInfo, int>.DeleteAsync(int id)
        {
            try
            {
                var PersonFind = await ctx.PersonalInfos.FindAsync(id);
                if (PersonFind != null)
                {
                    return null;
                }
                ctx.PersonalInfos.Remove(PersonFind);
                await ctx.SaveChangesAsync();
                return PersonFind;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<IEnumerable<PersonalInfo>> IService<PersonalInfo, int>.GetAsync()
        {
            try
            {
                var result = await ctx.PersonalInfos.ToListAsync();
                await ctx.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<PersonalInfo> IService<PersonalInfo, int>.GetByIdAsync(int id)
        {
            try
            {
                var PersonalId = await ctx.PersonalInfos.FindAsync(id);
                if (PersonalId == null)
                {
                    return null;
                }
                return PersonalId;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<PersonalInfo> IService<PersonalInfo, int>.UpdateAsync(int id, PersonalInfo entity)
        {
            try
            {
                var result = await ctx.PersonalInfos.FindAsync(id);
                if (result == null)
                {
                    return null;
                }
                result.FullName = entity.FullName;
               // result.Address = entity.Address;
                result.ContactNo = entity.ContactNo;
                result.Email = entity.Email;
                result.ImageFilePath = entity.ImageFilePath;
                result.ProfileFilePath = entity.ProfileFilePath;
                await ctx.SaveChangesAsync();
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
