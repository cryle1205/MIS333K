using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Le_Crystal_HW4.Models
{
    public enum ProductType { Hot, Cold, Packaged, Drink, Other }
    public class Product
    {
        [Display(Name = "Product ID:")]
        public Int32 ProductID { get; set; }

        [Display(Name = "Product Name:")]
        [Required(ErrorMessage ="Product Name is required.")]
        public String ProductName { get; set; }

        [Display(Name = "Product Description:")]
        public String ProductDes { get; set; }

        [Display(Name = "Product Price:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Required(ErrorMessage = "Price is required!")]
        [Range(0, 1000000, ErrorMessage = "Price must be at least $0")]
        public Decimal Price { get; set; }

        [Display(Name = "Product Type:")]
        public ProductType PType { get; set; }

        


    }
}
