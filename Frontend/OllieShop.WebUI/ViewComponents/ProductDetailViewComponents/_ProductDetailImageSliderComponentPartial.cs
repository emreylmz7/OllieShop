﻿using Microsoft.AspNetCore.Mvc;
using OllieShop.WebUI.Services.CatalogServices.ProductImageServices;

namespace OllieShop.WebUI.ViewComponents.ProductDetailViewComponents
{
    public class _ProductDetailImageSliderComponentPartial:ViewComponent
    {
        private readonly IProductImageService _productImageService;
        public _ProductDetailImageSliderComponentPartial(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var productImages = await _productImageService.GetProductImagesByProductId(id);
            return View(productImages);
        }
    }
}
