using System;
using Microsoft.EntityFrameworkCore;

namespace Week2Project.Models
{
    public class UsersContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public UsersContext(DbContextOptions<UsersContext> options)
                    : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
