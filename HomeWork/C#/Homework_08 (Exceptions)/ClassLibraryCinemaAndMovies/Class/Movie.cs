using System;
using ClassLibraryExercise.Enum;

namespace ClassLibraryExercise.MovieClass
{
    public class Movie
    {

        public string Title { get; set; }
        public MovieGenre Genere { get; set; }
        public byte Rating { get; set; }
        public double TicketPrice { get; set; }

        public Movie(string title, byte rating)
        {
            Title = title;
            try
            {
                if (rating < 1 || rating > 5)
                {
                    throw new Exception("Invalid rating range!");
                }
                Rating = rating;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Rating should be form 1 to 5");
                Console.WriteLine("Rating is set to 1");
                Console.WriteLine("");
                Rating = 1;
            }

            TicketPrice = 5 * rating;
            Genere = MovieGenre.Random;


        }

        public Movie(string title, MovieGenre genere, byte rating, double ticketPrice)
        {
            Title = title;
            Genere = genere;

            try
            {
                if (rating < 1 || rating > 5)
                {
                    throw new Exception("Invalid rating range!");
                }
                Rating = rating;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Rating should be from 1 to 5");
                Console.WriteLine("Rating is set to 1");
                Rating = 1;
            }


            if (ticketPrice == 0)
            {
                TicketPrice = 5 * rating;
            }
            else
            {
                TicketPrice = ticketPrice;
            }

        }
    }
}
