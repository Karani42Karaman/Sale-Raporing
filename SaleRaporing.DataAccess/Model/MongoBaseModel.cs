using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace SaleRaporing.DataAccess.Model
{
    public abstract class MongoBaseModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
    }
}
