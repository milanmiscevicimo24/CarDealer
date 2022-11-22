using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CarDealer.Database.Entities
{
    public class CarBrand
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Manufacturer")]
        public string Manufacturer { get; set; }
    }
}
