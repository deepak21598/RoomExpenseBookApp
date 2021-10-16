using AutoMapper;
using RoomExpenseBookApp.Entities.Models;
using RoomExpenseBookApp.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoomExpenseBookApp.Entities.Utilities
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<UserLoginViewModel, User>();
            CreateMap<UserSignUpViewModel, User>();
        }
    }
}
