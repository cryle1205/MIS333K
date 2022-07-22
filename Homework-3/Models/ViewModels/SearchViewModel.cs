using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Le_Crystal_HW3.Models
{
    //enum for UserRating choice of choosing to find rating higher or lower than input
    public enum UserRating {[Display(Name = "Greater Than") ] GreaterThan, [Display(Name = "Less Than")] LessThan}
    public class SearchViewModel
    {
        [Key] public Int32 SVMKey { get; set; } //Private key required to link

        //Title Search Property
        [Display(Name = "Search by Title:")]
        public String TitleSearch { get; set; }

        //Description Search property
        [Display(Name = "Search by Description:")]
        public String DescriptionSearch { get; set; }

        //Rating search property
        [Display(Name = "Search by Rating:")]
        public Rating? RatingSearch { get; set; }

        //Genre Search Property
        [Display(Name = "Search By Genre:")]
        public Int32? SelectedGenreID { get; set; }

        //User rating property
        [Display(Name = "Search By User Rating:")]
        public Decimal? UserNumRating { get; set;}

        //Enum property search
        [Display(Name = "Type of Search:")]
        public UserRating? UserRatingSearch{ get; set; }

        //Release Date property
        [Display (Name = "Search by Published Date:")]
        [DataType(DataType.Date)]
        public DateTime? ReleaseDateSearch { get; set; }


    }
}
