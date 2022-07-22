using System.ComponentModel.DataAnnotations;
using System;

namespace Le_Crystal_HW2.Models
{
    //inheriting from the Order class
    public class CateringOrder: Order 
    {
        [Display(Name = "Customer Code:")]
        [StringLength(4, MinimumLength = 2, ErrorMessage = "Customer code must be 2-4 characters")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Customer code may only contain letters")]
        public String CustomerCode { get; set; }

        //All catering orders have 
        [Display(Name = "Delivery Fee:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Required(ErrorMessage = "Delivery Fee is required!")]
        [Range(0, 250, ErrorMessage = "Delivery Fee must be between $0 and $250.")]
        public Decimal DeliveryFee { get; set; }

        //Boolean property for Catering customers to check so they may get their delivery fee waived
        [Display(Name = "Preferred Customer?")]
        public Boolean PreferredCustomer { get; set; }

        public void CalcTotals()
        {
            CalcSubtotals();
            // if a customer is preferred or if their subtotal is more than 1000, then delivery is free
            if (PreferredCustomer  || Subtotal >= 1000) 
            {
                DeliveryFee = 0;
            }
                 
            Total = Subtotal + DeliveryFee;
        }

    }
}
