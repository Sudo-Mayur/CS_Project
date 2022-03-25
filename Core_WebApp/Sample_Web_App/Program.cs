using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample_Web_App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}


//[Required(ErrorMessage = "EmpNo is Required")]
//public int EmpNo { get; set; }
//[Required(ErrorMessage = "EmpName is Required")]
//[Remote(action: "ValidateEmpName", controller: "Employee", ErrorMessage = "EmpName is not in correct format")]
//[Name(ErrorMessage = " EmpName MUST start from Upper Case character and does not have Digit and Special character")]
//public string EmpName { get; set; }
//[Required(ErrorMessage = "Salary is Required")]
//[NonNegative(ErrorMessage = "Salary must be Positive value")]
//public int Salary { get; set; }
//[Required(ErrorMessage = "Designation is Required")]
//public string Designation { get; set; }
//[Required(ErrorMessage = "DeptNo is Required")]
//public int DeptNo { get; set; }
//[Required(ErrorMessage = "Email is Required")]
//public string Email { get; set; }
//public double Tax { get; set; }


//public Department()
//{
//    Employees = new HashSet<Employee>();
//}
//[Required(ErrorMessage = "DeptNo is Required")]
//public int DeptNo { get; set; }
//[Required(ErrorMessage = "DeptName is Required")]

//public string DeptName { get; set; }
//[Required(ErrorMessage = "Location is Required")]

//public string Location { get; set; }
//[Required(ErrorMessage = "Capacity is Required")]
//[NonNegative]
//public int Capacity { get; set; }

//public virtual ICollection<Employee> Employees { get; set; }
