using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CarDealer.Database.Entities
{
    public class CarOffer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Offer")]
        public string Offer { get; set; }

        [BsonElement("Color")]
        public string Color { get; set; }

        [BsonElement("Hp")]
        public double Hp { get; set; }

        [BsonElement("Engine")]
        public double Engine { get; set; }

        [BsonElement("Fuel")]
        public string Fuel { get; set; }
    }
}
