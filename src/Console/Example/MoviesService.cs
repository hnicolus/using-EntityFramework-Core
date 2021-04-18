using System.Linq;
using System;

namespace Example
{
    public class MovieService
    {
        private readonly AppDbContext _dbcontext;
        public MovieService()
        {
            _dbcontext = new AppDbContext();
        }
        public Movie Get(int id)
        {
            var movie = _dbcontext.Movies.FirstOrDefault(x => x.Id == id);
            if (movie == null)
            {
                throw new Exception("Movie not Found");
            }
            return movie;
        }
        public void Create(Movie movie)
        {

            _dbcontext.Movies.Add(movie);
            _dbcontext.SaveChanges();

        }

        public void Update(int id, Movie input)
        {
            var dbMovie = _dbcontext.Movies.Find(id);

            dbMovie.Title = input.Title;
            dbMovie.Description = input.Description;
            _dbcontext.Movies.Update(dbMovie);
            _dbcontext.SaveChanges();
        }

        public bool Delete(int id)
        {
            var dbMovie = _dbcontext.Movies.Find(id);
            if (dbMovie == null) return false;

            _dbcontext.Movies.Remove(dbMovie);

            return true;
        }
    }

}