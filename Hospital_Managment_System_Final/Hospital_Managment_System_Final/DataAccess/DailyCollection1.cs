using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Managment_System_Final.Models;
using Microsoft.EntityFrameworkCore;


namespace Hospital_Managment_System_Final.DataAccess
{
    internal class DailyCollection1 : IDataAccess1<DailyCollection, int>
    {
        NewHospitalContext ctx;
        public DailyCollection1()
        {
            ctx = new NewHospitalContext();
        }

        async Task<DailyCollection> IDataAccess1<DailyCollection, int>.CreatAsync(DailyCollection entity)
        {
            try
            {
                var Result = await ctx.DailyCollections.AddAsync(entity);
                await ctx.SaveChangesAsync();
                return Result.Entity;   // Return newly CReated ENtity

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<IEnumerable<DailyCollection>> IDataAccess1<DailyCollection, int>.GetAsync()
        {
            try
            {
                var result = await ctx.DailyCollections.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;

            }
        }

        public void dailyCollection()
        {
            Console.WriteLine("Enter Date Like 2022-03-11 in this format");
            DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
            var totalCollection = ctx.DailyCollections.Where(x => x.Apdate == dateTime).Sum(x => x.Fees);
            Console.WriteLine($"Total Collection for the day is: {totalCollection} rupees");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
        }

        async Task<DailyCollection> IDataAccess1<DailyCollection, int>.UpdateAsync(int ID, DailyCollection entity)
        {
            try
            {
                var PatInfUpdate = await ctx.DailyCollections.FindAsync(ID);
                if (PatInfUpdate == null)
                {
                    return null;
                }
                PatInfUpdate.PatientRegNo = entity.PatientRegNo;
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

        async Task<DailyCollection> IDataAccess1<DailyCollection, int>.DeleteAsync(int ID)
        {
            try
            {
                var Record = await ctx.DailyCollections.FindAsync(ID);
                if (Record == null)
                {
                    return null;
                }
                ctx.DailyCollections.Remove(Record);
                await ctx.SaveChangesAsync();
                return Record;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
