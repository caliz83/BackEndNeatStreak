using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndNeatStreak.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEndNeatStreak.Models.Context
{
    public class DataContext : DbContext
    {
        public DbSet<UserModel> UserInfo { get; set; } = null!;

        public DbSet<ChoreItemModel> ChoreInfo { get; set; } = null!;
        
        public DataContext(DbContextOptions<DataContext> options) : base(options) {

        }

        //function to create the tables themselves
        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        //     base.OnModelCreating(builder);
        // }

    }
}