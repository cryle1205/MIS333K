//Name: Crystal Le
//Date: 2/18/2022
//Description: HW2 - Food Truck Checkout


using Microsoft.AspNetCore.Mvc;
using Le_Crystal_HW2.Models;
using System;

namespace Le_Crystal_HW2.Controllers
{
   
    public class HomeController : Controller
    {   
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CheckoutCatering() //views for customer is input values
        {
            return View();
        }

        public IActionResult CateringTotals(CateringOrder cateringOrder, CustomerType CustomerType) //Overload in parameter because Order is abstract
        {
            TryValidateModel(cateringOrder); //Validating Models to make sure they are within range and requirements

            if (ModelState.IsValid == false) //something is wrong
            {
                //go back to the create view
                return View("CheckoutCatering");
            }
            try // capturing exception if total items is 0
            {
                cateringOrder.CalcTotals();
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View("CheckoutCatering");
            }
            CustomerType = CustomerType.Catering; //set customertype
            cateringOrder.CalcTotals();
            return View("CateringTotals", cateringOrder);

        }

        public IActionResult CheckoutWalkup() //views for customer is input values
        {
            return View();
        }

        public IActionResult WalkupTotals(WalkupOrder walkupOrder, CustomerType CustomerType) //Overload in parameter because Order is abstract
        {
            
            TryValidateModel(walkupOrder); //Validating Models to make sure they are within range and requirements

            if (ModelState.IsValid == false) //something is wrong
            {
                //go back to the create view
                return View("CheckoutWalkup");
            }
            try // capturing exception if total items is 0
            {
                walkupOrder.CalcTotals();
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View("CheckoutWalkup");
            }
            CustomerType = CustomerType.Walkup; //set customertype
            walkupOrder.CalcTotals();
            return View("WalkupTotals", walkupOrder);

        }
    }
}
