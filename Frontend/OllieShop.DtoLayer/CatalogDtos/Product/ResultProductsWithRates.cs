﻿namespace OllieShop.DtoLayer.CatalogDtos.Product
{
    public class ResultProductsWithRates
    {
        public string? ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? CategoryId { get; set; }
        public string? ImageUrl { get; set; }
        public int TotalComments { get; set; }
        public double AverageRate { get; set; }
    }
}
