using Microsoft.AspNetCore.Mvc;
using RoomExpenseBookApp.Entities.ViewModels;
using RoomExpenseBookApp.Service.UserServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomExpenseBookApp.App.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IUserService _userService;
        public AuthenticationController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUpAsync(UserSignUpViewModel signUpViewModel)
        {
            if (ModelState.IsValid)
            {
                await _userService.SignUp(signUpViewModel);
                ModelState.Clear();
            }
            return View(signUpViewModel);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LoginAsync(UserLoginViewModel userLoginViewModel)
        {
            if (ModelState.IsValid)
            {
                if (_userService.Login(userLoginViewModel))
                    RedirectToAction("SignUp");
            }
            return View(userLoginViewModel);
        }
    }
}
