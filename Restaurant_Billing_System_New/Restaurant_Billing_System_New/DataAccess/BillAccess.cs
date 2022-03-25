using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Billing_System_New.Models;
using Microsoft.EntityFrameworkCore;


namespace Restaurant_Billing_System_New.DataAccess
{
    internal class BillAccess : IDataAccessBill<Bill, int>
    {
        restaurantContext ctx;
        public BillAccess()
        {
            ctx = new restaurantContext();
        }

        async Task<Bill> IDataAccessBill<Bill, int>.CreatAsync(Bill entity)
        {
            try
            {
                var Result = await ctx.Bills.AddAsync(entity);
                await ctx.SaveChangesAsync();
                return Result.Entity;   // Return newly CReated ENtity

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        Task<Bill> IDataAccessBill<Bill, int>.DeleteAsync(int ID)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<Bill>> IDataAccessBill<Bill, int>.GetAsync()
        {
            try
            {
                var result = await ctx.Bills.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        async Task<Bill> IDataAccessBill<Bill, int>.GetbyId(int ID)
        {
            try
            {
                var billID = await ctx.Bills.FindAsync(ID);
                if (billID == null)
                {
                    return null;
                }
                //await ctx.SaveChangesAsync();
                return billID;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }


        public void ShowTableDishInfo(int ID)
        {
            CustomorInfo custinfo = new CustomorInfo();
            var showTable = ctx.DishInfos.Where(x => x.CustomorId == ID);
            var showTableBill = ctx.Bills.Where(x => x.CustomorId == ID);
            Console.WriteLine("****************************************MAYUR RESTAURANT***************************************************");
            Console.WriteLine("CustomorId DishName      DishNo Quantity Rate Amount");
            foreach (var item in showTable)
            {
                Console.WriteLine($" {item.CustomorId}\t {item.DishName}\t{item.DishNo}\t {item.Quantity}\t {item.Rate}\t {item.Amount} ");
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            foreach (var item in showTableBill)
            {
                Console.WriteLine("Date                BillNo     CustomorId CustName  MobileNo    TableNo   SubTotal  Tax  TotalBill  PaymentMode");
                Console.WriteLine($"{item.Date}\t {item.BillNo}\t {item.CustomorId}\t{item.CustName}\t {item.MobileNo}\t {item.TableNo}\t {item.SubTotal}\t\t{item.Tax}\t{item.TotalBill}\t{item.PaymentMode}");

            }

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("***********WE ARE SO GRATEFUL FOR THE PLEASURE OF SERVING YOU AND HOPE WE MET YOUR  EXPECTATIONS.***********");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");


        }
        public void DailyCollection()
        {
            Console.WriteLine("Enter Date Like 2022-03-11 in this format");
            DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
            var totalCollection = ctx.Bills.Where(x => x.Date == dateTime).Sum(x => x.TotalBill);
            Console.WriteLine($"Total Collection for the day is: {totalCollection} rupees");
            Console.WriteLine("-------------------------------------------------------------------------------------------");           
        }
    }
}
