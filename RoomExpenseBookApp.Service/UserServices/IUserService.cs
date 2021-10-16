using RoomExpenseBookApp.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RoomExpenseBookApp.Service.UserServices
{
    public interface IUserService
    {
        Task<bool> SignUp(UserSignUpViewModel userSignUpViewModel);
        bool Login(UserLoginViewModel userLoginViewModel);
    }
}
