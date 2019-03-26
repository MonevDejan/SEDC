using System;
using System.Collections.Generic;


namespace ClassLibraryExercise.MovieClass
{
    public class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> ListOfMovies { get; set; }

        public Cinema(string name)
        {
            Name = name;
        }

        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($"Watching movie: {movie.Title}");
        }


    }
}
