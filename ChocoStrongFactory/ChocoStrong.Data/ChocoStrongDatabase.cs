using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChocoStrong.Model;

namespace ChocoStrong.Data
{
    public class ChocoStrongDatabase
    {
        private IDatabaseContext mDbContext;
        private IGenericRepository<Product> mProductsRepository;
        private IGenericRepository<Shop> mShopsRepository;
        private IGenericRepository<Sale> mSalesRepository;

        public ChocoStrongDatabase()
        {
            mDbContext = new EntityFrameworkContext();
            mProductsRepository = new GenericRepository<Product>(mDbContext);
            mShopsRepository = new GenericRepository<Shop>(mDbContext);
            mSalesRepository = new GenericRepository<Sale>(mDbContext);
        }

        public IGenericRepository<Product> Products
        {
            get { return mProductsRepository; }
        }

        public IGenericRepository<Shop> Shops
        {
            get { return mShopsRepository; }
        }

        public IGenericRepository<Sale> Sales
        {
            get { return mSalesRepository; }
        }
    }
}
