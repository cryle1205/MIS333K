using System;
using System.ComponentModel.DataAnnotations;


namespace Le_Crystal_HW2.Models
{
    // enum to store whether customer is a walkup or catering customer
    public enum CustomerType {[Display(Name = "Walk-Up")] Walkup, Catering }

    public abstract class Order // declaring class as abstract
    {

        //property for CustomerType
        public CustomerType CustomerType { get; set; } //property for enum

        // constant variables of Price per Taco is 2.75 and per Burger is 4.50
        public const Decimal TACO_PRICE = 2.75m;
        public const Decimal BURGER_PRICE = 4.50m;

        [Display(Name = "Number of Burgers:")] //Burgers are set to Int32 and has to be not smaller than 0 
        [Required(ErrorMessage = "Number of Burgers cannot be less than 0.")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Number of Burgers cannot be less than 0.")]
        public Int32 NumberOfBurgers { get; set; }

        [Display(Name = "Number of Tacos:")] //Tacos are set to Int32 and has to be not smaller than 0 
        [Required(ErrorMessage = "Number of Tacos cannot be less than 0.")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Number of Tacos cannot be less than 0.")]
        public Int32 NumberOfTacos { get; set; }


        [Display(Name = "Burger Subtotal:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal BurgerSubtotal{ get; private set; }


        [Display(Name = "Subtotal:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal Subtotal { get; private set; }
        

        [Display(Name = "Taco Subtotal:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal TacoSubtotal { get; private set; }


        [Display(Name = "Total:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal Total { get; set; }
        

        [Display(Name = "Total Items:")]
        public Int32 TotalItems{ get; private set; }


        //method is calculate subtotals in all models (some will be inheriting)
        public void CalcSubtotals()
        {
            //calculate total number of items before sending into exception throw
            TotalItems = NumberOfBurgers + NumberOfTacos;
            if (TotalItems == 0 )
            {
                throw new Exception("You must order at least one item!");
            }
            
            TacoSubtotal = NumberOfTacos * TACO_PRICE;
            Subtotal = TacoSubtotal + BurgerSubtotal;
            BurgerSubtotal = NumberOfBurgers * BURGER_PRICE;
        }








    }
}
