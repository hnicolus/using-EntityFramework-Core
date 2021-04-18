using System;
using System.Linq;
namespace Example
{
    class Program
    {

        static void Main(string[] args)
        {
            var movie = new Movie
            {
                Title = "Avengers",
                Description = "Avengers is a Sci movie full of super heros Killing Villains."
            };
            var movieService = new MovieService();
            movieService.Create(movie);
        }
    }
}
