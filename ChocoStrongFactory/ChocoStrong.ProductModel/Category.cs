using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoStrong.ProductModel
{
    public class Category
    {
        [BsonId]
        public ObjectId CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
