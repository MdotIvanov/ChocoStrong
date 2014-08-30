using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChocoStrong.Model;

namespace ChocoStrong.Data
{
    public class EntityFrameworkContext : DbContext, IDatabase
    {
        public EntityFrameworkContext()
            : base("ChocoStongDb")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EntityFrameworkContext, MigrationsConfiguration>());
        }

        public IDbSet<Product> Products { get; set; }

        public IDbSet<Shop> Shops { get; set; }

        public IDbSet<Sale> Sales { get; set; }

        public IDbSet<City> Cities { get; set; }

        public IDbSet<Category> Categories { get; set; }

        IDbSet<T> IDatabase.Set<T>()
        {
            return base.Set<T>();
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}
