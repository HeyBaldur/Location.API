using MongoDB.Bson.Serialization.Attributes;

namespace Models.V1
{
    /// <summary>
    /// Represents location information (cities or other places).
    /// </summary>
    public class Location
    {
        /// <summary>
        /// Gets or sets the name of the location.
        /// </summary>
        [BsonElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the latitude coordinates of the location.
        /// </summary>
        [BsonElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude coordinates of the location.
        /// </summary>
        [BsonElement("longitude")]
        public string Longitude { get; set; }
    }
}
