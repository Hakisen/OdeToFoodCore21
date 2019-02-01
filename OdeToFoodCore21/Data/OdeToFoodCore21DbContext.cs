using Microsoft.EntityFrameworkCore;
using OdeToFoodCore21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFoodCore21.Data
{
    public class OdeToFoodCore21DbContext : DbContext
    {
        public OdeToFoodCore21DbContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
