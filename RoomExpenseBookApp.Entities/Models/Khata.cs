using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RoomExpenseBookApp.Entities.Models
{
    public class Khata
    {
        public Guid Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }
        public Guid OwnerId { get; set; }

        //<Foreign Keys>
        [ForeignKey("OwnerId")]
        public User User { get; set; }
    }
}
