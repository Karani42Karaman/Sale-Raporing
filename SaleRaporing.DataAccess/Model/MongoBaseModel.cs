using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace SaleRaporing.DataAccess.Model
{
    public abstract class MongoBaseModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}
