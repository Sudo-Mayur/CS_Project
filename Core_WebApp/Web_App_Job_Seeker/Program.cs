using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_App_Job_Seeker
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


//User@21gmail.com==JobSeeker

//public int PersonId { get; set; }
//[Name(ErrorMessage = "Enter Candidate Name in Proper Formate Like Mayur Mahadev Chavan")]
//[Required(ErrorMessage = "Candidate Name is Required")]
////[Remote(action: "ValidateName", controller: "PersonalInfo", ErrorMessage = "Enter Candidate Name in Proper Formate Like Mayur Mahadev Chavan")]
//public string FullName { get; set; }
//[Required(ErrorMessage = "Candidate AddressLine1 is Required")]
//public string AddressLine1 { get; set; }
//[Required(ErrorMessage = "Candidate City is Required")]
//public string City { get; set; }
//[Required(ErrorMessage = "PinCode is Required")]
//[PinCode(ErrorMessage = "Please Enter The Pin Code in Proper Format")]
//public string PinCode { get; set; }

//[Number(ErrorMessage = "Please Enter Correct Contact Number")]
//public string ContactNo { get; set; }
//[Email(ErrorMessage = "Please Enter  Email in Correct Format")]
//public string Email { get; set; }
//public string ImageFilePath { get; set; }
//public string ProfileFilePath { get; set; }


//public int EducationId { get; set; }
//public int PersonId { get; set; }
//[Required(ErrorMessage = "SSC Board name is Required")]
//public string SscboardName { get; set; }
//[Required(ErrorMessage = "SSC Percentage is Required")]
//[NonNegative(ErrorMessage = "Percentage must be Positive value")]
//public double? Sscpercentage { get; set; }
//[Required(ErrorMessage = "SSC Passing Year is Required")]
//[Year(ErrorMessage = "SSC Passing Year is Required")]
//public int SscpassingDate { get; set; }
//public string HscboardName { get; set; }
//public double? Hscpercentage { get; set; }
//public int HscpassingDate { get; set; }
//public string DiplomaBoardName { get; set; }
//public double? DiplomaPercentage { get; set; }
//public int DiplomaPassingDate { get; set; }
//public string DegreeUniversityName { get; set; }
//public double? DegreePercentage { get; set; }
//public string DegreeType { get; set; }
//public int DegreePassingDate { get; set; }
//public string MastersUniversityName { get; set; }
//public double? MastersPercentage { get; set; }
//public int MastersPassingDate { get; set; }
//public string HighestQuaification { get; set; }




//dotnet ef migrations add SecurityMigration -c  Web_App_Job_Seeker.Data.Web_App_Job_SeekerContext 
//dotnet ef database update -c  Web_App_Job_Seeker.Data.Web_App_Job_SeekerContext 

//dotnet ef dbcontext scaffold "Data Source=.;Initial Catalog=Company;Integrated Security=SSPI" Microsoft.EntityFrameworkCore.SqlServer -o Models 