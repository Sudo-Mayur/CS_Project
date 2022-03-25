using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mayur_Clinic_Updated.Models;
using Microsoft.EntityFrameworkCore;

namespace Mayur_Clinic_Updated.DataAccess
{
    internal class PatientDataAccess : IDataAccess<PatientInfo, int>
    {
        MayurClinicContext ctx;
        public PatientDataAccess()
        {
            ctx = new MayurClinicContext();
        }

        async Task<PatientInfo> IDataAccess<PatientInfo, int>.CreatAsync(PatientInfo entity)
        {
            try
            {
                var Result = await ctx.PatientInfos.AddAsync(entity);
                await ctx.SaveChangesAsync();
                return Result.Entity;   // Return newly CReated ENtity

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<PatientInfo> IDataAccess<PatientInfo, int>.DeleteAsync(int ID)
        {
            try
            {
                var PatFind = await ctx.PatientInfos.FindAsync(ID);
                if (PatFind == null)
                {
                    return null;
                }
                ctx.PatientInfos.Remove(PatFind);
                await ctx.SaveChangesAsync();
                return PatFind;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<IEnumerable<PatientInfo>> IDataAccess<PatientInfo, int>.GetAsync()
        {
            try
            {
                var result = await ctx.PatientInfos.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;

            }
        }

        async Task<PatientInfo> IDataAccess<PatientInfo, int>.GetbyId(int ID)
        {
            try
            {
                var PatFindID = await ctx.PatientInfos.FindAsync(ID);
                if (PatFindID == null)
                {
                    return null;
                }
                //await ctx.SaveChangesAsync();
                return PatFindID;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<PatientInfo> IDataAccess<PatientInfo, int>.UpdateAsync(int ID, PatientInfo entity)
        {
            try
            {
                var PatInfUpdate = await ctx.PatientInfos.FindAsync(ID);
                if (PatInfUpdate == null)
                {
                    return null;
                }
                PatInfUpdate.PatientRegNo = entity.PatientRegNo;
                PatInfUpdate.PatName = entity.PatName;
                PatInfUpdate.PatAddress = entity.PatAddress;
                PatInfUpdate.MobileNo = entity.MobileNo;
                PatInfUpdate.Age = entity.Age;
                PatInfUpdate.Wieght = entity.Wieght;
                PatInfUpdate.PatBp = entity.PatBp;
                PatInfUpdate.CholestrolHdl = entity.CholestrolHdl;
                PatInfUpdate.CholestrolLdl = entity.CholestrolLdl;
                PatInfUpdate.Sugurfast = entity.Sugurfast;
                PatInfUpdate.SugurPotFast = entity.SugurPotFast;
                PatInfUpdate.Medicines = entity.Medicines;
                PatInfUpdate.Apdate = entity.Apdate;
                PatInfUpdate.Fees = entity.Fees;
                await ctx.SaveChangesAsync();
                return PatInfUpdate;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
