using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoStrong.ProductModel
{
    public class Shop
    {
        [BsonId]
        public ObjectId ShopId { get; set; }
        public string ShopName { get; set; }
        public City City { get; set; }

        [BsonConstructor]
        public Shop(string shopName, City city)
        {
            this.ShopName = shopName;
            this.City = city;
        }
        //public virtual ICollection<Sale> Sales
        //{
        //    get { return mSales; }
        //    set { mSales = value; }
        //}


        //public virtual City Location { get; set; }

        public string GetStringId()
        {
            return this.ShopId.ToString();
        }
    }
}
