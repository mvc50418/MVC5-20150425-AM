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
                yield return new ValidationResult("���椣��p��2000", new []{ "Price" });
            }
        }
    }


    public partial class ProductMetaData
    {

        //[StringLength(80, ErrorMessage = "�����פ��o�j�� 80 �Ӧr��")]
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