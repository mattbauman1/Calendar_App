using Calendar_App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar_App.Data
{
    public class Calendar_AppDbContext : DbContext
    {
        public Calendar_AppDbContext(DbContextOptions<Calendar_AppDbContext> options) 
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
