﻿using System;
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
            if (Convert.ToInt32(value) < 0)
            {
                return false;

            }
            return true;
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
}
