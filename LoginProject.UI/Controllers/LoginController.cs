using FluentValidation;
using FluentValidation.Results;
using LoginProject.Business.Abstract;
using LoginProject.Business.Concrete;
using LoginProject.Business.ValidationRules.FluentValidation;
using LoginProject.DataAccess;
using LoginProject.DataAccess.Concrete.EntityFramework;
using LoginProject.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginProject.UI.Controllers
{

    public class LoginController : Controller
    {
        private IUserService _userService;
        public LoginController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            UserValidator validator = new UserValidator();
            ValidationResult result = validator.Validate(user);
            if (result.IsValid == false)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                    //throw new ValidationException(result.Errors);
                }
                return View();

            }

            if (_userService.GetByUser(user) != null)
            {
                return RedirectToAction("MovieList", "Movie");
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
            
            
        }


    }
}
