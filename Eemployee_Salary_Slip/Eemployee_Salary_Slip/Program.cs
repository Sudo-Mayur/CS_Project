using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Employee_Salary_Slip
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            Employees emp = new Employees();

            calculateTax(emp);


        }

        static void calculateTax(IEnumerable<Employee> emps)
        {
            FileOperations file = new FileOperations();
            var taxGroup = from e in emps
                           group e by e.Designation into desig
                           select new
                           {
                               Designation = desig.Key,
                               Records = desig.ToList()
                           };

            foreach (var item in taxGroup)
            {
                foreach (var record in item.Records)
                {
                    double HRA = 0;
                    double TS = 0;
                    double DA = 0;
                    double gross = 0;
                    double anualGrossSalary = 0;
                    double tax = 0;
                    int monthlyNetSalary = 0;
                    if (record.Designation == "Manager")
                    {
                        HRA = (record.Salary * 10) / 100;
                        TS = (record.Salary * 15) / 100;
                        DA = (record.Salary * 20) / 100;

                    }
                    else if (record.Designation == "Director")
                    {
                        HRA = (record.Salary * 20) / 100;
                        TS = (record.Salary * 30) / 100;
                        DA = (record.Salary * 40) / 100;
                    }

                    gross = record.Salary + HRA + TS + DA;
                    anualGrossSalary = gross * 12;


                    if (anualGrossSalary >= 500000 && anualGrossSalary <= 1000000)
                    {
                        tax = (gross * 20) / 100;
                    }
                    else if (anualGrossSalary >= 1000000 && anualGrossSalary <= 2000000)
                    {
                        tax = (gross * 25) / 100;
                    }
                    else if (anualGrossSalary > 2000000)
                    {
                        tax = (gross * 30) / 100;
                    }

                    monthlyNetSalary = (int)(gross - tax);

                    file.fileCreate(record, HRA, TS, DA, gross, anualGrossSalary, tax, monthlyNetSalary);
                }
            }
        }



    }
}