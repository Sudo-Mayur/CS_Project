using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic_Managment_System.Models;
using Microsoft.EntityFrameworkCore;


namespace Clinic_Managment_System.DataAccess
{
    internal class PatientNextAp : IDataAccess1<PatientInfo1, int>
    {
        HospitalContext ctx;
        public PatientNextAp()
        {
            ctx = new HospitalContext();
        }

        async Task<PatientInfo1> IDataAccess1<PatientInfo1, int>.CreatAsync(PatientInfo1 entity)
        {
            try
            {
                var Result = await ctx.PatientInfo1s.AddAsync(entity);
                await ctx.SaveChangesAsync();
                return Result.Entity;   // Return newly CReated ENtity

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<IEnumerable<PatientInfo1>> IDataAccess1<PatientInfo1, int>.GetAsync()
        {
            try
            {
                var result = await ctx.PatientInfo1s.ToListAsync();
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
