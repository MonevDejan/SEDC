using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibraryExercise.MovieClass;
using ClassLibraryExercise.Enum;
using ClassLibraryCinemaAndMovies.Service;

namespace Exercise1
{
    //Task
    #region 
    /*
        Make a class Movie. Movie must have: Title, Genre, Rating, TicketPrice and a constructor for setting them
        Rating should be a number from 1 to 5. Throw exception if its more or less ( you should also handle other exceptions )
        Set the TicketPrice to be 5 * Rating when creating a new object
        Genre should be an enum with Comedy, Horror, Action, Drama and SciFi
        Make a class Cinema. Cinema must have: Name, Halls , ListOfMovies
        Cinema should have method MoviePlaying  that will have a parameter ‘movie’ and then print out in the console “Watching Movie.Title”
        We will provide 10 movies per cinema to put in the cinema movies list

        Make a user interface that will choose a cinema.
        After that the user should chose if he likes to see all movies or by genre
        All movies - show all movies and give option to choose a movie ( the movie Playing method should be called )
        By genre the user should input his favorite genre and a list of movies from that genre from the 
        cinema should be displayed and give an option to choose one
        If the user enter a wrong input throw an exception, 
        Handle all exceptions with Try/Catch
     */

    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Validate validate = new Validate();
            PrintConsole consolePrint = new PrintConsole();

            Movie movie1 = new Movie("Scary Movie", 2);
            Movie movie2 = new Movie("American Pie", MovieGenre.Comedy, 4, 2.5);
            Movie movie3 = new Movie("Saw", MovieGenre.Horror, 2, 2.5);
            Movie movie4 = new Movie("The Shining", MovieGenre.Horror, 4, 2.5);
            Movie movie5 = new Movie("Rambo", MovieGenre.Action, 4, 2.5);
            Movie movie6 = new Movie("The Terminator", MovieGenre.Action, 4, 2.5);
            Movie movie7 = new Movie("Forrest Gump", MovieGenre.Drama, 1, 2.5);
            Movie movie8 = new Movie("12 Angru Men", MovieGenre.Drama, 4, 2.5);
            Movie movie9 = new Movie("Passengers", MovieGenre.SciFi, 4, 2.5);
            Movie movie10 = new Movie("Interstellar", MovieGenre.SciFi, 4, 2.5);
            List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };

            Movie movie11 = new Movie("Airplane", MovieGenre.Comedy, 4, 2.5);
            Movie movie12 = new Movie("Johnny English", MovieGenre.Comedy, 4, 2.5);
            Movie movie13 = new Movie("The Ring", MovieGenre.Horror, 4, 2.5);
            Movie movie14 = new Movie("Sinister", MovieGenre.Horror, 4, 2.5);
            Movie movie15 = new Movie("RoboCop", MovieGenre.Action, 4, 2.5);
            Movie movie16 = new Movie("Judge Dredd", MovieGenre.Action, 4, 2.5);
            Movie movie17 = new Movie("The Social Network", MovieGenre.Drama, 4, 2.5);
            Movie movie18 = new Movie("The Shawshank Redemption", MovieGenre.Drama, 4, 2.5);
            Movie movie19 = new Movie("Inception", MovieGenre.SciFi, 4, 2.5);
            Movie movie20 = new Movie("Avatar", MovieGenre.SciFi, 4, 2.5);
            List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };

            Cinema cinema1 = new Cinema("Cineplex");
            cinema1.Halls = new List<int>() { 1, 2, 3, 4 };
            cinema1.ListOfMovies = MovieSet1;

            Cinema cinema2 = new Cinema("Milenium");
            cinema2.Halls = new List<int>() { 1, 2 };
            cinema2.ListOfMovies = MovieSet2;

            consolePrint.ChoseCinema();
            string chosenCinema = validate.Option1or2();

            switch (chosenCinema)
            {
                case "1":
                    consolePrint.ChoseCinemaOptions();
                    string chosenMovieView1 = validate.Option1or2();

                    switch (chosenMovieView1)
                    {
                        case "1":
                            consolePrint.Movies(cinema1.ListOfMovies);
                            Console.WriteLine("Please chose movie");
                            Movie movieToWatch = validate.Movie(cinema1.ListOfMovies);
                            cinema1.MoviePlaying(movieToWatch);
                            break;

                        case "2":
                            consolePrint.MovieGenre();
                            string genre = validate.Option1to5();
                            MovieGenre chosenGenre = validate.Genre(genre);
                            
                            List<Movie> moviesByGenre = cinema1.ListOfMovies.Where(x => x.Genere == chosenGenre).ToList();
                            consolePrint.Movies(moviesByGenre);

                            Console.WriteLine("Please chose movie");
                            Movie movieFromGenre = validate.Movie(moviesByGenre);
                            cinema1.MoviePlaying(movieFromGenre);
                            break;
                    }

                    break;

                case "2":

                    consolePrint.ChoseCinemaOptions();
                    string chosenMovieView2 = validate.Option1or2();

                    switch (chosenMovieView2)
                    {
                        case "1":

                            consolePrint.Movies(cinema2.ListOfMovies);
                            Console.WriteLine("Please chose movie");
                            Movie movieToWatch = validate.Movie(cinema2.ListOfMovies);
                            cinema2.MoviePlaying(movieToWatch);
                            break;

                        case "2":
                        
                            consolePrint.MovieGenre();
                            string genre = validate.Option1to5();
                            MovieGenre chosenGenre = validate.Genre(genre);
                            
                            List<Movie> moviesByGenre = cinema2.ListOfMovies.Where(x => x.Genere == chosenGenre).ToList();
                            consolePrint.Movies(moviesByGenre);

                            Console.WriteLine("Please chose movie");
                            Movie movieFromGenre = validate.Movie(moviesByGenre);
                            cinema2.MoviePlaying(movieFromGenre);
                            break;
                    }
                    break;
            }

            Console.ReadLine();
        }
    }
}
