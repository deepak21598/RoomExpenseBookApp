using Microsoft.EntityFrameworkCore;
using RoomExpenseBookApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoomExpenseBookApp.Entities.DataBaseContext
{
    public class RoomExpenseBook_DbContext : DbContext
    {
        public RoomExpenseBook_DbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("DataBaseConnection"));
            }
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Khata> Khatas { get; set; }
        public DbSet<KhataMember> KhataMembers { get; set; }
        public DbSet<ExpenseDetail> ExpenseDetails { get; set; }
    }
}
