using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChocoStrong.Model;

namespace ChocoStrong.Data
{
    public interface IDatabaseContext
    {
        IDbSet<Product> Products { get; set; }

        IDbSet<Shop> Shops { get; set; }

        IDbSet<Sale> Sales { get; set; }

        IDbSet<City> Cities { get; set; }

        IDbSet<Category> Categories { get; set; }

        IDbSet<T> Set<T>() where T : class;

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        void SaveChanges();
    }
}