using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Calendar_App.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the Calendar_AppUser class
    public class Calendar_AppUser : IdentityUser
    {
        public string FirstName { get; set; }
    }
}
