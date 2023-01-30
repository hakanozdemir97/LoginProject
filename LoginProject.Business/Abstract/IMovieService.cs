using LoginProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject.Business.Abstract
{
    public interface IMovieService
    {
        List<Movie> GetAll();
        List<Movie> GetByName(string movieName);
    }
}
