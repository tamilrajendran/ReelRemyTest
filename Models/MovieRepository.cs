using System;
namespace ReelRemyTest.Models
{
	public class MovieRepository
	{
        public static List<Movie> Movies { get; set; } = new List<Movie>() {
                new Movie
                {
                    Id = 1,
                    MovieName = "VTV"
                },

                new Movie
                {
                    Id = 2,
                    MovieName = "ManjumalBoys"
                },

                new Movie
                {
                    Id = 3,
                    MovieName = "Billa"

               }

        };
	}
}

