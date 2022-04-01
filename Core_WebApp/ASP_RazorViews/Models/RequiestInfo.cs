using System;
using System.Collections.Generic;

namespace ASP_RazorViews.Models
{
    public partial class RequiestInfo
    {
        public int RequiestId { get; set; }
        public string ControllerName { get; set; } = null!;
        public string RequiestMethode { get; set; } = null!;
        public DateTime DateTime { get; set; }
    }
}
