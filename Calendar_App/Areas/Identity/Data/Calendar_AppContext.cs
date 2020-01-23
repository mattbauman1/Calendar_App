﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calendar_App.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Calendar_App.Data
{
    public class Calendar_AppContext : IdentityDbContext<Calendar_AppUser>
    {
        public Calendar_AppContext(DbContextOptions<Calendar_AppContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
