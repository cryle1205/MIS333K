using System.ComponentModel.DataAnnotations;
using System;

namespace Le_Crystal_HW2.Models
{
    //inheriting from the Order class
    public class WalkupOrder : Order
    {
        //all walkup orders have a sales tax added
        public const Decimal SALES_TAX_RATE = 0.0825m;

        [Display(Name = "Customer Name:")]
        [Required(ErrorMessage = "Please enter a name for this order")]
        public String CustomerName { get; set; }


        //private setter unless set from within the class so it is readonly
        [Display(Name = "Sales Tax:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Required(ErrorMessage = "Sales Tax is required for walkup orders.")]
        public Decimal SalesTax { get; private set; }


        public void CalcTotals()
        {
            //calling on CalcSubtotals for methods and properties
            CalcSubtotals();
            SalesTax = Subtotal * SALES_TAX_RATE;
            Total = Subtotal + SalesTax;
        }
        
    }
}
