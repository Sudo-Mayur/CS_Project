using System;
using System.Collections.Generic;

namespace Student_Managment.Models
{
    public partial class UserInfo
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public double? Mathematics { get; set; }
        public double? Science { get; set; }
        public double? Geography { get; set; }
        public double? History { get; set; }
        public DateTime? Enterdate { get; set; }
    }

    public partial class StudentMarks
    {
        public int UserID { get; set; }
        public string? MailID { get; set; }
        public double MathsScore { get; set; }
        public double SciScore { get; set; }
        public double HistScore { get; set; }
        public double GeoScore { get; set; }
        public DateTime EntryDate { get; set; }
    }

}
