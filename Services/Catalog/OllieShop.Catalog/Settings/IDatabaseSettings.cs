﻿namespace OllieShop.Catalog.Settings
{
    public interface IDatabaseSettings
    {
        public string CategoryCollectionName { get; set; }
        public string ProductCollectionName { get; set; }
        public string ProductImageCollectionName { get; set; }
        public string ProductDetailCollectionName { get; set; }
        public string CarouselCollectionName { get; set; }
        public string FeatureCollectionName { get; set; }
        public string OfferCollectionName { get; set; }
        public string VendorCollectionName { get; set; }
        public string AboutCollectionName { get; set; }
        public string ContactCollectionName { get; set; }
        public string SizeCollectionName { get; set; }
        public string ColorCollectionName { get; set; }
        public string ProductStockCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
