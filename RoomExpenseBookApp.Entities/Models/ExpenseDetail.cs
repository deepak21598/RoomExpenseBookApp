using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RoomExpenseBookApp.Entities.Models
{
    public class ExpenseDetail
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }
        public Guid MemberId { get; set; }
        public Guid KhataId { get; set; }

        //<Foreign Keys>
        [ForeignKey("MemberId")]
        public User User { get; set; }

        [ForeignKey("KhataId")]
        public Khata Khata { get; set; }
    }
}
