using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoStrong.ProductModel
{
    public class City
    {
        [BsonId]
        public ObjectId CityId { get; set; }

        public string CityName { get; set; }
    }
}
