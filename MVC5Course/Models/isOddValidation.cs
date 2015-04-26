using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models
{
    public sealed class OddAttribute : ValidationAttribute
    {
        public OddAttribute()
        {
            
        }

        public override bool IsValid(object value)
        {
            if (value == null)
                return true;
            if (value is string)
            {
                return true;
            }
            return false;
        }

    }
}