using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

            //var res = await ctx.EducationalInfos.ToListAsync();
            //var edu = res.Where(x => x.PersonId == id).FirstOrDefault();
            //return edu;

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
                result.SscboardName = entity.SscboardName;
                result.Sscpercentage = entity.Sscpercentage;
                result.SscpassingDate=entity.SscpassingDate;
                result.HscboardName = entity.HscboardName;
                result.Hscpercentage = entity.Hscpercentage;
                result.HscpassingDate= entity.HscpassingDate;
                result.DegreeUniversityName = entity.DegreeUniversityName;
                result.DegreePercentage = entity.DegreePercentage;
                result.DegreeType= entity.DegreeType;
                result.DegreePassingDate= entity.DegreePassingDate;
                result.MastersUniversityName = entity.MastersUniversityName;
                result.MastersPercentage = entity.MastersPercentage;
                result.MastersPassingDate=entity.MastersPassingDate;

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
