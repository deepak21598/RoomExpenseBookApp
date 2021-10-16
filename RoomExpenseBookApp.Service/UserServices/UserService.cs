using RoomExpenseBookApp.DataAccess.UserAccess;
using RoomExpenseBookApp.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RoomExpenseBookApp.Entities.Models;

namespace RoomExpenseBookApp.Service.UserServices
{
    public class UserService : IUserService
    {
        private readonly IUserDataAccess _userAccess;
        private readonly IMapper _mapper;
        public UserService(IUserDataAccess userAccess, IMapper mapper)
        {
            _userAccess = userAccess;
            _mapper = mapper;
        }
        public bool Login(UserLoginViewModel userLoginViewModel)
        {
            return _userAccess.Login(_mapper.Map<User>(userLoginViewModel));
        }

        public async Task<bool> SignUp(UserSignUpViewModel userSignUpViewModel)
        {
            User user = _mapper.Map<User>(userSignUpViewModel);
            user.Id = Guid.NewGuid();

            return await _userAccess.SignUp(user);
        }
    }
}
