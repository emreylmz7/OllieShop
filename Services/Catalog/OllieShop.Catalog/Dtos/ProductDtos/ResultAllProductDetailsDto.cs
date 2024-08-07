﻿using OllieShop.Catalog.Entities;

namespace OllieShop.Catalog.Dtos.ProductDtos
{
    public class ResultAllProductDetailsDto
    {
        public string? ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? CategoryId { get; set; }
        public string? ImageUrl { get; set; }
        public string? CategoryName { get; set; }
        public List<Size>? Sizes { get; set;}
        public List<Color>? Colors { get; set;}
        public int TotalStock { get; set; }
    }
}
