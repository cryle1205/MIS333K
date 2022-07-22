using System;
using System.ComponentModel.DataAnnotations;


//TODO: Change this namespace to match your project (LastName_FirstName_HW3)
namespace Le_Crystal_HW3.Models
{
    public enum Rating { G, PG, [Display(Name ="PG-13")]PG13, R, Unrated  }
    public class Movie
    {
        [Display(Name = "Movie ID")]
        public Int32 MovieID { get; set; }

        [Display(Name = "IMDB ID")]
        public String IMDBID { get; set; }

        public String Title { get; set; }
        public String Description { get; set; }

        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Average Rating")]
        public Decimal VoteAverage { get; set; }

        [Display(Name = "# of Votes")]
        [DisplayFormat(DataFormatString ="{0:n0}")]
        public Int32 VoteCount { get; set; }

        [Display(Name = "Website")]
        [DataType(DataType.Url)]
        public String URL { get; set; }

        [Display(Name = "MPAA Rating")]
        public Rating Rating { get; set; }

        //navigational property
        public Genre Genre { get; set; }

    }
}
