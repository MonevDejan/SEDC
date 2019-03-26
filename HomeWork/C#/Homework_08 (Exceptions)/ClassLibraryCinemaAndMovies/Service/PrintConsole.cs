using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryExercise.MovieClass;

namespace ClassLibraryCinemaAndMovies.Service
{
    public class PrintConsole
    {
        public void ChoseCinema()
        {
            Console.WriteLine("Please chose cinema  (1 or 2) ");
            Console.WriteLine("1. Cineplex");
            Console.WriteLine("2. Milenium");
        }

        public void ChoseCinemaOptions()
        {
            Console.WriteLine("Please chose options  (1 or 2) ");
            Console.WriteLine("1. See all movies");
            Console.WriteLine("2. Movies by genre");
        }

        public void Movies(List<Movie> allMovies)
        {
            foreach (var movie in allMovies)
            {
                Console.WriteLine($"{movie.Title}");
            }
        }

        public void MovieGenre()
        {
            Console.WriteLine("Please chose from the folowing option");
            Console.WriteLine("1. Comedy");
            Console.WriteLine("2. Horror");
            Console.WriteLine("3. Action");
            Console.WriteLine("4. Drama");
            Console.WriteLine("5. SciFi");
        }
    }
}
