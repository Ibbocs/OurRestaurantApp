using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurRestaurantAppAPI.Persistance.Configurations
{
    public static class ConnectionConfig
    {
        static public string ConnectionStringForOurRestaurantAppDb
        {
            get
            {
                //C:\Users\user\source\repos\OurRestaurantApp\OurRestaurantAppAPI.Persistance\Configurations - burdan
                //C:\Users\user\source\repos\OurRestaurantApp\OurRestaurantAppApi.Presentation -  gel


                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../OurRestaurantApp/OurRestaurantAppApi.Presentation"));
                configurationManager.AddJsonFile("appsettings.json");


                return configurationManager.GetConnectionString("OurRestaurantAppDB");

            }
        }
    }
}
