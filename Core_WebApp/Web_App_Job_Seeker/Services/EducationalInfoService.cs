using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web_App_Job_Seeker.Models;
namespace Web_App_Job_Seeker.Services
{
    public class EducationalInfoService : IService<EducationalInfo, int>
    {
        private readonly CompanyContext ctx;
        public EducationalInfoService(CompanyContext ctx)
        {
            this.ctx = ctx;
        }
        async Task<EducationalInfo> IService<EducationalInfo, int>.CreateAsync(EducationalInfo entity)
        {
            try
            {
                var result = await ctx.EducationalInfos.AddAsync(entity);
                await ctx.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<EducationalInfo> IService<EducationalInfo, int>.DeleteAsync(int id)
        {
            try
            {
                var result = await ctx.EducationalInfos.FindAsync(id);
                if (result == null)
                {
                    return null;
                }
                ctx.EducationalInfos.Remove(result);
                await ctx.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<IEnumerable<EducationalInfo>> IService<EducationalInfo, int>.GetAsync()
        {
            try
            {
                var result = await ctx.EducationalInfos.ToListAsync();
                await ctx.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<EducationalInfo> IService<EducationalInfo, int>.GetByIdAsync(int id)
        {
            try
            {
                var result = await ctx.EducationalInfos.FindAsync(id);
                if (result == null)
                {
                    return null;
                }
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<EducationalInfo> IService<EducationalInfo, int>.UpdateAsync(int id, EducationalInfo entity)
        {
            try
            {
                var result = await ctx.EducationalInfos.FindAsync(id);
                if (result == null)
                {
                    return null;
                }
                result.PersonId = entity.PersonId;
                result.SscschoolName = entity.SscschoolName;
                result.SscboardName = entity.SscboardName;
                result.Sscpercentage = entity.Sscpercentage;
                result.HsccollegeName = entity.HsccollegeName;
                result.HscboardName = entity.HscboardName;
                result.Hscpercentage = entity.Hscpercentage;
                result.DegreeCollegeName = entity.DegreeCollegeName;
                result.DegreeUniversityName = entity.DegreeUniversityName;
                result.DegreePercentage = entity.DegreePercentage;
                result.MastersUniversityName = entity.MastersUniversityName;
                result.MastersPercentage = entity.MastersPercentage;

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
