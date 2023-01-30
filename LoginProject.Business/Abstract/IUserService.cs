using LoginProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject.Business.Abstract
{
    public interface IUserService
    {
        User GetByUser(User user);
    }
}
