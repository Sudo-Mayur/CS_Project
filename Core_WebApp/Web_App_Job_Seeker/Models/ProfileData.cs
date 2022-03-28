using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Web_App_Job_Seeker.Models
{
    public class ProfileData
    {
       [Display(Name = "Image")]
        public IFormFile ProfilePicture { get; set; }
        public string ProfileUploadStatus { get; set; }
        public string ProfileFileName { get; set; }

        public IFormFile Resume { get; set; }
        public string ResumeUploadStatus { get; set; }
        public string ResumeFileName { get; set; }


    }
}
