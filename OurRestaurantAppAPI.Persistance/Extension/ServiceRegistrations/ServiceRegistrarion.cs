using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OurRestaurantAppAPI.Domain.Entities.Identity;
using OurRestaurantAppAPI.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurRestaurantAppAPI.Persistance.Extension.ServiceRegistrations
{
    static public class ServiceRegistrarion
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<OurRestaurantAppDbContext>(options=> options.UseSqlServer(Configurations.ConnectionConfig.ConnectionStringForOurRestaurantAppDb));

            services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<OurRestaurantAppDbContext>();
        }
    }
}
