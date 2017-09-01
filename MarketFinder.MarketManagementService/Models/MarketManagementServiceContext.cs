using System;
using System.Data.Entity;

namespace MarketFinder.MarketManagementService.Models
{
    public class MarketManagementServiceContext : DbContext
    {
        static MarketManagementServiceContext()
        {
            // Use CreateDatabase.sql to create Database
            Database.SetInitializer<MarketManagementServiceContext>(null);
        }

        public MarketManagementServiceContext()
            : base("name=MarketManagementServiceDb")
        {
        }

        public System.Data.Entity.DbSet<Market> Markets { get; set; }

        public System.Data.Entity.DbSet<MarketFinder.MarketManagementService.Models.Rating> Ratings { get; set; }

    }
}
