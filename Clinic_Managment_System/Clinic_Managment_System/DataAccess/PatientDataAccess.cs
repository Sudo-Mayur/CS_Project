using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic_Managment_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinic_Managment_System.DataAccess
{
    internal class PatientDataAccess : IDataAccess<PatientInfo, int>
    {
        HospitalContext ctx;
        public PatientDataAccess()
        {
            ctx = new HospitalContext();
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
    }
}
