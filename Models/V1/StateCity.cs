using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Collections.Generic;

namespace Models.V1
{
    /// <summary>
    /// Represents state or province information along with associated cities.
    /// </summary>
    public class StateCity
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
        /// Gets or sets the code or abbreviation for the state or province.
        /// </summary>
        [BsonElement("state_code")]
        public string StateCode { get; set; }

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

        /// <summary>
        /// Gets or sets the identifier of the country to which the state or province belongs.
        /// </summary>
        [BsonElement("country_id")]
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or sets a list of cities within the state or province.
        /// </summary>
        [BsonElement("cities")]
        public List<Location> Cities { get; set; }
    }
}
