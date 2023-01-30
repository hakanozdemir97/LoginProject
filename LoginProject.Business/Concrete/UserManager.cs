using LoginProject.Business.Abstract;
using LoginProject.Business.ValidationRules.FluentValidation;
using LoginProject.DataAccess.Abstract;
using LoginProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetByUser(User user)
        {
            var result = _userDal.Get(x => x.Username == user.Username && x.Password == user.Password);
            return result;
        }
    }
}
