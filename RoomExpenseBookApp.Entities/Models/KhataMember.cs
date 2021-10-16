using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RoomExpenseBookApp.Entities.Models
{
    public class KhataMember
    {
        public Guid Id { get; set; }
        public Guid KhataId { get; set; }
        public Guid MemberId { get; set; }
        //<Foreign Keys>
        [ForeignKey("KhataId")]
        public Khata Khata { get; set; }

        [ForeignKey("MemberId")]
        public User User { get; set; }
    }
}
