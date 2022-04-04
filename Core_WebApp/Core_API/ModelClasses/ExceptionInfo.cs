using System.ComponentModel.DataAnnotations;

namespace Core_API.ModelClasses
{
    public class ExceptionInfo
    {
        [Key]
        public int RequestID { get; set; }
        public string? ControllerName { get; set; }
        public string? RequestMethodType { get; set; }
        public DateTime DateTime { get; set; }
        public string? ErrorMessage { get; set; }
        public string? StatckTrace { get; set; }

    }
}

//RequestID
//ControllerName
//RequestMethodType (Get/Post/Put/Delete)
//Date
//Time
//ErrorMessage
//StatckTrace