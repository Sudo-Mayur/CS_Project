using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mayur_Clinic_Updated.Models;
using Microsoft.EntityFrameworkCore;

namespace Mayur_Clinic_Updated.DataAccess
{
    internal class PatientInfoNew : IDataAccessPatient<Patient, int>
    {
        MayurClinicContext ctx;
        public PatientInfoNew()
        {
            ctx = new MayurClinicContext();
        }

        async Task<Patient> IDataAccessPatient<Patient, int>.GetbyId(int ID)
        {
            try
            {
                var PatientFindID = await ctx.Patients.FindAsync(ID);
                if (PatientFindID == null)
                {
                    return null;
                }
                //await ctx.SaveChangesAsync();
                return PatientFindID;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
