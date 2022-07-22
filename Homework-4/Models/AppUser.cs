using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Le_Crystal_HW4.Models
{
    public class AppUser : IdentityUser
    {
        // Add additional user fields here
        //First name is provided as an example

        [Display(Name = "First Name:")]
        [Required(ErrorMessage = "First name is required.")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name:")]
        [Required(ErrorMessage = "Last name is required.")]
        public String LastName { get; set; }

 


    }
}