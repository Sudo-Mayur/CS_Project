using System.Collections.Generic;
using System.Threading.Tasks;
using Web_App_Job_Seeker.Models;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Web_App_Job_Seeker.Services
{
    public class ProfessionalInfoService : IService<ProfessionalInfo, int>
    {
        private readonly CompanyContext ctx;
        public ProfessionalInfoService(CompanyContext ctx)
        {
            this.ctx = ctx;
        }

       

        async Task<ProfessionalInfo> IService<ProfessionalInfo, int>.CreateAsync(ProfessionalInfo entity)
        {
            try
            {
                var result = await ctx.ProfessionalInfos.AddAsync(entity);
                await ctx.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); 
                return null;
            }

        }

        async Task<ProfessionalInfo> IService<ProfessionalInfo, int>.DeleteAsync(int id)
        {
            try
            {
                var result = await ctx.ProfessionalInfos.FindAsync(id);
                if (result == null)
                {
                    return null;
                }
                ctx.ProfessionalInfos.Remove(result);
                await ctx.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<IEnumerable<ProfessionalInfo>> IService<ProfessionalInfo, int>.GetAsync()
        {
            try
            {
                var result = await ctx.ProfessionalInfos.ToListAsync();
                await ctx.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<ProfessionalInfo> IService<ProfessionalInfo, int>.GetByIdAsync(int id)
        {
            //var res = await ctx.ProfessionalInfos.ToListAsync();
            //var edu = res.Where(x => x.PersonId == id).FirstOrDefault();
            //return edu;

            try
            {
                var result = await ctx.ProfessionalInfos.FindAsync(id);
                if (result == null)
                {
                    return null;
                }
                // await ctx.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<ProfessionalInfo> IService<ProfessionalInfo, int>.UpdateAsync(int id, ProfessionalInfo entity)
        {
            try
            {
                var result = await ctx.ProfessionalInfos.FindAsync(id);
                if (result == null)
                {
                    return null;
                }
                result.PersonId = entity.PersonId;
                result.WorkExperience = entity.WorkExperience;
                result.Companies = entity.Companies;
                result.ProjectInfo = entity.ProjectInfo;
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
