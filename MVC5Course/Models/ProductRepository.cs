using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
	
namespace MVC5Course.Models
{   
	public  class ProductRepository : EFRepository<Product>, IProductRepository
	{

	}

    public partial class Product : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.Price<2000)
            {
                yield return new ValidationResult("價格不能小於2000", new []{ "Price" });
            }
        }
    }


    public partial class ProductMetaData
    {

        //[StringLength(80, ErrorMessage = "欄位長度不得大於 80 個字元")]
        //public string ProductName { get; set; }

        //[OddNumber]
        //[Required]
        //public Nullable<decimal> Price { get; set; }
        //public Nullable<bool> Active { get; set; }
        //public Nullable<decimal> Stock { get; set; }


    }

	public  interface IProductRepository : IRepository<Product>
	{

	}
}