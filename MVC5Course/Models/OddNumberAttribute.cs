using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models
{
public class OddNumberAttribute : DataTypeAttribute
    {
        public OddNumberAttribute()
            : base("OddNumber")
        {
            this.ErrorMessage = "此欄位必須為偶數";
        }

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }

            int num = 0;

            if (Int32.TryParse(value.ToString(), out num))
            {
                if (num % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}