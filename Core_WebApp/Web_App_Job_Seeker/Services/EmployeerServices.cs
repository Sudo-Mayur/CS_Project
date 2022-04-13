using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web_App_Job_Seeker.Models;
namespace Web_App_Job_Seeker.Services
{
    public class EmployeerServices : IService<Employeer, int>
    {
        private readonly CompanyContext ctx;
        public EmployeerServices(CompanyContext ctx)
        {
            this.ctx = ctx;
        }
        async Task<Employeer> IService<Employeer, int>.CreateAsync(Employeer entity)
        {
            try
            {
                var result = await ctx.Employeers.AddAsync(entity);
                await ctx.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<Employeer> IService<Employeer, int>.DeleteAsync(int id)
        {
            try
            {
                var result = await ctx.Employeers.FindAsync(id);
                if (result == null)
                {
                    return null;
                }
                ctx.Employeers.Remove(result);
                await ctx.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<IEnumerable<Employeer>> IService<Employeer, int>.GetAsync()
        {
            try
            {
                var result = await ctx.Employeers.ToListAsync();
                await ctx.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<Employeer> IService<Employeer, int>.GetByIdAsync(int id)
        {
            try
            {
                var result = await ctx.Employeers.FindAsync(id);
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

        async Task<Employeer> IService<Employeer, int>.UpdateAsync(int id, Employeer entity)
        {
            try
            {
                var result = await ctx.Employeers.FindAsync(id);
                if (result == null)
                {
                    return null;
                }
                result.EmployeerId = entity.EmployeerId;
                result.EmployeerName = entity.EmployeerName;
                result.ContactNo = entity.ContactNo;
                result.Email = entity.Email;
                result.ImagePath = entity.ImagePath;
                result.OrgName = entity.OrgName;
                result.OrgType = entity.OrgType;
                result.OrganizationInfo = entity.OrganizationInfo;
                result.OrgAddress = entity.OrgAddress;
                result.District = entity.District;
                result.OrgState = entity.OrgState;
                result.OrgContact = entity.OrgContact;
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

    //public int EmployeerId { get; set; }
    //public string EmployeerName { get; set; }
    //public string ContactNo { get; set; }
    //public string Email { get; set; }
    //public string ImagePath { get; set; }
    //public string OrgName { get; set; }
    //public string OrgType { get; set; }
    //public string OrgAddress { get; set; }
    //public string District { get; set; }
    //public string OrgState { get; set; }
    //public string OrgContact { get; set; }

