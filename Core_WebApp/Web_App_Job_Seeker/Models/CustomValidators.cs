using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Web_App_Job_Seeker.Models
{
    public class NonNegativeAttribute : ValidationAttribute
    {
        /// <summary>
        /// Parameter 'value' will be set by the value entered 
        /// for the property from UI where the current attribute 
        /// is applied
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>    
        public override bool IsValid(object value)
        {
            if (Convert.ToInt32(value) > 0 && Convert.ToInt32(value) <=100)
            {
                return true;
                
            }
            return false;
        }

    }

    public class NameAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Regex re = new Regex("^([a-zA-Z]+( [a-zA-Z]+)+)$");
            if (re.IsMatch(Convert.ToString(value)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
    //(@"^[0-9]{10}$");
    //"[0-9]")
    public class NumberAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Regex re = new Regex(@"^[0-9]{10}$"); 
            if (re.IsMatch(Convert.ToString(value)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
    //^(19|20)\d{2}$
    public class YearAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Regex re = new Regex(@"^(19|20)\d{2}$");
            if (re.IsMatch(Convert.ToString(value)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

    // @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"
    public class EmailAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Regex re = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (re.IsMatch(Convert.ToString(value)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

    public class PinCodeAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Regex re = new Regex(@"^[0-9]{6}$");
            if (re.IsMatch(Convert.ToString(value)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }


}


