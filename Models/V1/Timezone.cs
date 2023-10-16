using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Models.V1
{
    /// <summary>
    /// Represents a timezone.
    /// </summary>
    public class Timezone
    {
        /// <summary>
        /// Gets or sets the timezone name.
        /// </summary>
        [BsonElement("zoneName")]
        public string ZoneName { get; set; }

        /// <summary>
        /// Gets or sets the GMT (Greenwich Mean Time) offset in seconds.
        /// </summary>
        [BsonElement("gmtOffset")]
        public int GmtOffset { get; set; }

        /// <summary>
        /// Gets or sets the GMT offset name.
        /// </summary>
        [BsonElement("gmtOffsetName")]
        public string GmtOffsetName { get; set; }

        /// <summary>
        /// Gets or sets the abbreviation for the timezone.
        /// </summary>
        [BsonElement("abbreviation")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Gets or sets the full name of the timezone.
        /// </summary>
        [BsonElement("tzName")]
        public string TzName { get; set; }
    }
}
