using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


//TODO: Change this namespace to match your project (LastName_FirstName_HW3)
namespace Le_Crystal_HW3.Models
{
    public class Genre
    {
        [Display(Name ="Genre ID")]
        public Int32 GenreID { get; set; }

        [Display(Name = "Genre Name")]
        public String GenreName { get; set; }

        //navigational properties
        public List<Movie> Movies { get; set; }

        //this is a constructor that will help to prevent
        //null reference errors.  You need this code every
        //time you have a list property
        public Genre()
        {
            if (Movies == null)
            { 
                Movies = new List<Movie>();
            }
        }
    }
}
