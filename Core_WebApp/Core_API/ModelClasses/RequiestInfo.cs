using System.ComponentModel.DataAnnotations;

namespace Core_API.ModelClasses
{
    public class RequiestInfo
    {
        [Key]
        public int RequiestID { get; set; }
        public string? ControllerName { get; set; }
        public string? RequiestMethode { get; set; }
        public DateTime DateTime { get; set; }

    }
}


//RequestID
//ControllerName
//RequestMethodType (Get/Post/Put/Delete)
//Date
//Time


//var dateNow = DateOnly.FromDateTime(DateTime.Now);
//To get current time only:

//var timeNow = TimeOnly.FromDateTime(DateTime.Now);