using LoginProject.Business.Abstract;
using LoginProject.DataAccess.Abstract;
using LoginProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject.Business.Concrete
{
    public class MovieManager : IMovieService
    {
        private IMovieDal _movieDal;
        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }
        public List<Movie> GetAll()
        {
            var result = _movieDal.GetAll();
            return result;
        }

        public List<Movie> GetByName(string movieName)
        {
            var result = _movieDal.GetAll(x => x.MovieName.Contains(movieName));
            return result;
        }
    }
}
