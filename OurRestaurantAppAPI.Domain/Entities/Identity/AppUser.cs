using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurRestaurantAppAPI.Domain.Entities.Identity
{
    public class AppUser : IdentityUser<string>
    {
    }

    public class AppRole : IdentityRole<string>
    {
    }

    public class AppUserRoles : IdentityUserRole<string>
    {
    }
}
