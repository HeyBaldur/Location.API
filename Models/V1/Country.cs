using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Collections.Generic;

namespace Models.V1
{
    /// <summary>
    /// Represents country information.
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Gets or sets the unique identifier of the country.
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the country.
        /// </summary>
        [BsonElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the ISO 3166-1 alpha-3 code of the country.
        /// </summary>
        [BsonElement("iso3")]
        public string Iso3 { get; set; }

        /// <summary>
        /// Gets or sets the ISO 3166-1 alpha-2 code of the country.
        /// </summary>
        [BsonElement("iso2")]
        public string Iso2 { get; set; }

        /// <summary>
        /// Gets or sets the numeric code of the country.
        /// </summary>
        [BsonElement("numeric_code")]
        public string NumericCode { get; set; }

        /// <summary>
        /// Gets or sets the international phone code for the country.
        /// </summary>
        [BsonElement("phone_code")]
        public string PhoneCode { get; set; }

        /// <summary>
        /// Gets or sets the capital city of the country.
        /// </summary>
        [BsonElement("capital")]
        public string Capital { get; set; }

        /// <summary>
        /// Gets or sets the currency code of the country.
        /// </summary>
        [BsonElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the name of the currency used in the country.
        /// </summary>
        [BsonElement("currency_name")]
        public string CurrencyName { get; set; }

        /// <summary>
        /// Gets or sets the currency symbol of the country.
        /// </summary>
        [BsonElement("currency_symbol")]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Gets or sets the top-level domain (TLD) of the country.
        /// </summary>
        [BsonElement("tld")]
        public string Tld { get; set; }

        /// <summary>
        /// Gets or sets the native name of the country.
        /// </summary>
        [BsonElement("native")]
        public string Native { get; set; }

        /// <summary>
        /// Gets or sets the region where the country is located.
        /// </summary>
        [BsonElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the region.
        /// </summary>
        [BsonElement("region_id")]
        public string RegionId { get; set; }

        /// <summary>
        /// Gets or sets the subregion where the country is located.
        /// </summary>
        [BsonElement("subregion")]
        public string Subregion { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the subregion.
        /// </summary>
        [BsonElement("subregion_id")]
        public string SubregionId { get; set; }

        /// <summary>
        /// Gets or sets the nationality of the country's residents.
        /// </summary>
        [BsonElement("nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// Gets or sets the time zones used in the country.
        /// </summary>
        [BsonElement("timezones")]
        public List<Timezone> Timezones { get; set; }

        /// <summary>
        /// Gets or sets translations of the country's name in various languages.
        /// </summary>
        [BsonElement("translations")]
        public Dictionary<string, string> Translations { get; set; }

        /// <summary>
        /// Gets or sets the latitude coordinates of the country.
        /// </summary>
        [BsonElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude coordinates of the country.
        /// </summary>
        [BsonElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// Gets or sets the country's flag emoji.
        /// </summary>
        [BsonElement("emoji")]
        public string Emoji { get; set; }

        /// <summary>
        /// Gets or sets the Unicode representation of the country's flag emoji.
        /// </summary>
        [BsonElement("emojiU")]
        public string EmojiU { get; set; }
    }
}
