using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Otus.Teaching.Pcf.Administration.Core.Domain
{
    public class BaseEntity
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public BaseEntity()
        {
            Id = ObjectId.GenerateNewId();
        }
    }
}