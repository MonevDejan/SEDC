using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryExercise.MovieClass;
using ClassLibraryExercise.Enum;

namespace ClassLibraryCinemaAndMovies.Service
{
    public class Validate
    {
        public string Option1or2()
        {
            string input = Console.ReadLine();

            if ((input != "1") && (input != "2"))
            {
                Console.WriteLine("Please chose options from 1 or 2");

                input = Option1or2();
            }
            return input;
        }

        public string Option1to5()
        {
            string input = Console.ReadLine();

            if ((input != "1") && (input != "2") && (input != "3") && (input != "4") && (input != "5"))
            {
                Console.WriteLine("Please chose options from 1, 2, 3, 4 or 5");

                input = Option1to5();
            }
            return input;
        }

        public Movie Movie(List<Movie> allMovies)
        {
            string input = Console.ReadLine();
            Movie movieToWatch = null;

            foreach (var movie in allMovies)
            {
                if (input == movie.Title)
                {
                    movieToWatch = movie;
                }
            }
            if (movieToWatch == null)
            {
                Console.WriteLine("Please chose movie from the list");
                movieToWatch = Movie(allMovies);
            }
            return movieToWatch;
        }

        public MovieGenre Genre(string genre)
        {
            MovieGenre chosenGenre = MovieGenre.Random;

            switch (genre)
            {
                case "1":
                    chosenGenre = MovieGenre.Comedy;
                    break;
                case "2":
                    chosenGenre = MovieGenre.Horror;
                    break;
                case "3":
                    chosenGenre = MovieGenre.Action;
                    break;
                case "4":
                    chosenGenre = MovieGenre.Drama;
                    break;
                case "5":
                    chosenGenre = MovieGenre.SciFi;
                    break;
            }
            return chosenGenre;
        }


    }
}
