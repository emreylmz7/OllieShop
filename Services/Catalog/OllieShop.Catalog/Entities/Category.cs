﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OllieShop.Catalog.Entities
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? CategoryId { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
    }
}
