using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Models.V1
{
    /// <summary>
    /// Represents state or province information.
    /// </summary>
    public class State
    {
        /// <summary>
        /// Gets or sets the unique identifier of the state or province.
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the state or province.
        /// </summary>
        [BsonElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the country to which the state or province belongs.
        /// </summary>
        [BsonElement("country_id")]
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or sets the code or abbreviation for the country to which the state or province belongs.
        /// </summary>
        [BsonElement("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the full name of the country to which the state or province belongs.
        /// </summary>
        [BsonElement("country_name")]
        public string CountryName { get; set; }

        /// <summary>
        /// Gets or sets the code or type of the state or province (if applicable).
        /// </summary>
        [BsonElement("state_code")]
        public string StateCode { get; set; }

        /// <summary>
        /// Gets or sets the type or category of the state or province (if applicable).
        /// </summary>
        [BsonElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the latitude coordinates of the state or province.
        /// </summary>
        [BsonElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude coordinates of the state or province.
        /// </summary>
        [BsonElement("longitude")]
        public string Longitude { get; set; }
    }
}
