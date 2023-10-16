using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Collections.Generic;

namespace Models.V1
{
    /// <summary>
    /// Represents subregion information.
    /// </summary>
    public class Subregion
    {
        /// <summary>
        /// Gets or sets the unique identifier of the region.
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the region.
        /// </summary>
        [BsonElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the region.
        /// </summary>
        [BsonElement("region_id")]
        public string RegionId { get; set; }

        /// <summary>
        /// Gets or sets translations of the region's name in various languages.
        /// </summary>
        [BsonElement("translations")]
        public Dictionary<string, string> Translations { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier linked to external knowledge sources.
        /// </summary>
        [BsonElement("wikiDataId")]
        public string WikiDataId { get; set; }
    }
}
