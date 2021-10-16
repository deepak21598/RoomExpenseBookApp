using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RoomExpenseBookApp.Entities.Models
{
    public class User
    {
        public Guid Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(30)]
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
