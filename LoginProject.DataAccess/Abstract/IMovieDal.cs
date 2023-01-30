using LoginProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject.DataAccess.Abstract
{
    public interface IMovieDal : IEntityRepository<Movie>
    {
    }
}
