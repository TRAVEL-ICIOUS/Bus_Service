using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bus_Service.Classes
{
    public class CustomDOJ :ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime D = Convert.ToDateTime(value);
            DateTime TD = DateTime.Now;
            int count = (int)(D.Subtract(TD).TotalDays);
            if (D < TD)
                return new ValidationResult("Date cannot be lesser than today's date");
            else if (count > 2)
                return new ValidationResult("Next two days can be booked");
            else
                return ValidationResult.Success;
        }
    }
}