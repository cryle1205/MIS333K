using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//TODO: Change these using statements to match your project (LastName_FirstName_HW3)
using Le_Crystal_HW3.DAL;
using Le_Crystal_HW3.Models;


//TODO: Change this namespace to match your project (LastName_FirstName_HW3)
namespace Le_Crystal_HW3.Seeding
{
    public static class SeedGenres
    {
        public static void SeedAllGenres(AppDbContext db)
        {
            List<Genre> AllGenres = new List<Genre>();

            AllGenres.Add(new Genre { GenreName = "Action" });
            AllGenres.Add(new Genre { GenreName = "Adventure" });
            AllGenres.Add(new Genre { GenreName = "Animation" });
            AllGenres.Add(new Genre { GenreName = "Comedy" });
            AllGenres.Add(new Genre { GenreName = "Crime" });
            AllGenres.Add(new Genre { GenreName = "Documentary" });
            AllGenres.Add(new Genre { GenreName = "Drama" });
            AllGenres.Add(new Genre { GenreName = "Family" });
            AllGenres.Add(new Genre { GenreName = "Fantasy" });
            AllGenres.Add(new Genre { GenreName = "Horror" });
            AllGenres.Add(new Genre { GenreName = "Musical" });
            AllGenres.Add(new Genre { GenreName = "Mystery" });
            AllGenres.Add(new Genre { GenreName = "Romance" });
            AllGenres.Add(new Genre { GenreName = "Science Fiction" });
            AllGenres.Add(new Genre { GenreName = "Thriller" });
            AllGenres.Add(new Genre { GenreName = "Western" });

            //create a counter to help debug
            int intGenreID = 0;
            string strGenreName = "Start";

            try
            {
                foreach (Genre seedGenre in AllGenres)
                {
                    //updates the counter to get info on where the problem is
                    intGenreID = seedGenre.GenreID;
                    strGenreName = seedGenre.GenreName;

                    //find the genre in the database
                    Genre dbGenre = db.Genres.FirstOrDefault(g => g.GenreName == seedGenre.GenreName);

                    if (dbGenre == null) //the genre isn't in the database
                    {
                        //add the genre
                        db.Genres.Add(seedGenre);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("There was an error adding the ");
                msg.Append(strGenreName);
                msg.Append(" genre (GenreID = ");
                msg.Append(intGenreID);
                msg.Append(")");
                throw new Exception( msg.ToString(), ex);
            }
        }
    }
}
