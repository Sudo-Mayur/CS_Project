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


//public int PersonId { get; set; }
//[Name(ErrorMessage = "Enter Candidate Name in Proper Formate Like Mayur Mahadev Chavan")]
//[Required(ErrorMessage = "Candidate Name is Required")]
//public string FullName { get; set; }
//[Required(ErrorMessage = "Candidate Address is Required")]
//public string Address { get; set; }
//[Number(ErrorMessage = "Please Enter Correct Contact Number")]
//public string ContactNo { get; set; }
//public string Email { get; set; }
//public string ImageFilePath { get; set; }
//public string ProfileFilePath { get; set; }

//public int EducationId { get; set; }
//public int PersonId { get; set; }
//[Required(ErrorMessage = "SSC Board name is Required")]
//public string SscboardName { get; set; }
//[Required(ErrorMessage = "SSC Percentage is Required")]
//[NonNegative(ErrorMessage = "Percentage must be Positive value")]
//public double Sscpercentage { get; set; }
//[Required(ErrorMessage = "SSC Passing Year is Required")]
//public int SscpassingYear { get; set; }
//public string HscboardName { get; set; }
//[NonNegative(ErrorMessage = "Percentage must be Positive value")]
//public double? Hscpercentage { get; set; }
//public int? HscpassingYear { get; set; }
//public string DiplomaBoardName { get; set; }
//[NonNegative(ErrorMessage = "Percentage must be Positive value")]
//public double? DiplomaPercentage { get; set; }
//public int? DiplomaPassingYear { get; set; }
//public string DegreeUniversityName { get; set; }
//[NonNegative(ErrorMessage = "Percentage must be Positive value")]
//public double? DegreePercentage { get; set; }
//public int? DegreePassingYear { get; set; }
//public string MastersUniversityName { get; set; }
//[NonNegative(ErrorMessage = "Percentage must be Positive value")]
//public double? MastersPercentage { get; set; }
//public int? MastersPassingYear { get; set; }
//public string HighestQuaification { get; set; }

//public virtual PersonalInfo Person { get; set; }


//public int EducationId { get; set; }
//public int PersonId { get; set; }
//[Required(ErrorMessage = "SSC Board name is Required")]
//public string SscboardName { get; set; }
//[Required(ErrorMessage = "SSC Percentage is Required")]
//[NonNegative(ErrorMessage = "Percentage must be Positive value")]
//public double? Sscpercentage { get; set; }
//[Required(ErrorMessage = "SSC Passing Year is Required")]
//public int SscpassingDate { get; set; }
//public string HscboardName { get; set; }
//[NonNegative(ErrorMessage = "Percentage must be Positive value")]
//public double? Hscpercentage { get; set; }
//public int HscpassingDate { get; set; }
//public string DiplomaBoardName { get; set; }
//[NonNegative(ErrorMessage = "Percentage must be Positive value")]
//public double? DiplomaPercentage { get; set; }
//public int DiplomaPassingDate { get; set; }
//public string DegreeUniversityName { get; set; }
//[NonNegative(ErrorMessage = "Percentage must be Positive value")]
//public double? DegreePercentage { get; set; }
//public string DegreeType { get; set; }
//public int DegreePassingDate { get; set; }
//public string MastersUniversityName { get; set; }
//[NonNegative(ErrorMessage = "Percentage must be Positive value")]
//public double? MastersPercentage { get; set; }
//public int MastersPassingDate { get; set; }
//public string HighestQuaification { get; set; }


//public int PersonId { get; set; }
//[Name(ErrorMessage = "Enter Candidate Name in Proper Formate Like Mayur Mahadev Chavan")]
//[Required(ErrorMessage = "Candidate Name is Required")]
////[Remote(action: "ValidateName", controller: "PersonalInfo", ErrorMessage = "Enter Candidate Name in Proper Formate Like Mayur Mahadev Chavan")]
//public string FullName { get; set; }
//[Required(ErrorMessage = "Candidate Address is Required")]
//public string Address { get; set; }
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
//[Year(ErrorMessage = "Add Year in Proper Format Like 2016")]
//public int SscpassingDate { get; set; }
//public string HscboardName { get; set; }
//[NonNegative(ErrorMessage = "Percentage must be Positive value")]
//public double? Hscpercentage { get; set; }
//public int HscpassingDate { get; set; }
//public string DiplomaBoardName { get; set; }
//[NonNegative(ErrorMessage = "Percentage must be Positive value")]
//public double? DiplomaPercentage { get; set; }
//public int DiplomaPassingDate { get; set; }
//public string DegreeUniversityName { get; set; }
//[NonNegative(ErrorMessage = "Percentage must be Positive value")]
//public double? DegreePercentage { get; set; }
//public string DegreeType { get; set; }
//public int DegreePassingDate { get; set; }
//public string MastersUniversityName { get; set; }
//[NonNegative(ErrorMessage = "Percentage must be Positive value")]
//public double? MastersPercentage { get; set; }
//public int MastersPassingDate { get; set; }
//public string HighestQuaification { get; set; }
