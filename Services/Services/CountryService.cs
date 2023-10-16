﻿using Microsoft.Extensions.Logging;
using Models.V1;
using MongoDB.Bson;
using MongoDB.Driver;
using Services.Data;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CountryService : ICountryService
    {
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<Country> _countryCollection;
        private readonly ILogger<CountryService> _logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="logger"></param>
        /// <param name="mongoClient"></param>
        public CountryService(
            IMongoDbSettings settings,
            ILogger<CountryService> logger,
            IMongoClient mongoClient)
        {
            _database = mongoClient.GetDatabase(settings.DatabaseName);

            _logger = logger;

            _countryCollection = _database.GetCollection<Country>("countries");
        }

        /// <summary>
        /// Get country by keyword.
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<List<Country>> GetCountryByKeyword(string keyword)
        {
            // Create a regex pattern for a case-insensitive partial match
            var regexPattern = new BsonRegularExpression(new Regex(keyword, RegexOptions.IgnoreCase));

            // Create a filter for the 'name' property with a partial match
            var filter = Builders<Country>.Filter.Regex("name", regexPattern);

            var results = await _countryCollection.Find(filter).ToListAsync();

            return results;
        }
    }
}
