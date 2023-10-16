using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models.V1
{
    /// <summary>
    /// Represents city information.
    /// </summary>
    public class City
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the city.
        /// </summary>
        [BsonElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the state or region to which the city belongs.
        /// </summary>
        [BsonElement("state_id")]
        public int StateId { get; set; }

        /// <summary>
        /// Gets or sets the code or abbreviation for the state or region.
        /// </summary>
        [BsonElement("state_code")]
        public string StateCode { get; set; }

        /// <summary>
        /// Gets or sets the full name of the state or region.
        /// </summary>
        [BsonElement("state_name")]
        public string StateName { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the country to which the city belongs.
        /// </summary>
        [BsonElement("country_id")]
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or sets the code or abbreviation for the country.
        /// </summary>
        [BsonElement("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the full name of the country.
        /// </summary>
        [BsonElement("country_name")]
        public string CountryName { get; set; }

        /// <summary>
        /// Gets or sets the latitude coordinates of the city.
        /// </summary>
        [BsonElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude coordinates of the city.
        /// </summary>
        [BsonElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier linked to external knowledge sources.
        /// </summary>
        [BsonElement("wikiDataId")]
        public string WikiDataId { get; set; }
    }
}
