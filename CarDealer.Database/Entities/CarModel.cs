using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CarDealer.Database.Entities
{
    public class CarModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Model")]
        public string Model { get; set; }
    }
}
