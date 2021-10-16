using RoomExpenseBookApp.Entities.DataBaseContext;
using RoomExpenseBookApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace RoomExpenseBookApp.DataAccess.UserAccess
{
    public class UserDataAccess : IUserDataAccess
    {
        private readonly RoomExpenseBook_DbContext _context;
        public UserDataAccess(RoomExpenseBook_DbContext context)
        {
            _context = context;
        }
        public bool Login(User user)
        {
            var userDetails = _context.Users.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);
            if (userDetails == null)
                return false;
            else
                return true;
        }

        public async Task<bool> SignUp(User user)
        {
            await _context.AddAsync(user);
            var rowAffected = await _context.SaveChangesAsync();
            return rowAffected > 0;
        }

    }
}
