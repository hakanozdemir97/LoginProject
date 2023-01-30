using LoginProject.DataAccess.Abstract;
using LoginProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject.DataAccess.Abstract
{
    public interface IUserDal: IEntityRepository<User>
    {
    }
}
