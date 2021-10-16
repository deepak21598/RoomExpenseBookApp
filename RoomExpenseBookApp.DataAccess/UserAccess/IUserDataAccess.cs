using RoomExpenseBookApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RoomExpenseBookApp.DataAccess.UserAccess
{
    public interface IUserDataAccess
    {
        Task<bool> SignUp(User user);
        bool Login(User user);
    }
}
