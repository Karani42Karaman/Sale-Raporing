using MongoDB.Bson.Serialization.Attributes;
using System;

namespace SaleRaporing.DataAccess.Model
{
    public class rpacollection : MongoBaseModel
    {
        [BsonElement]
        public String FileName { get; set; }    

        [BsonElement]
        public byte[] FileContent { get; set; }

        [BsonElement]
        public string ContentType { get; set; }

        [BsonElement]
        public DateTime CreateDate { get; set; }

        [BsonElement]
        public byte[] FileHash { get; set; }

    }
}
