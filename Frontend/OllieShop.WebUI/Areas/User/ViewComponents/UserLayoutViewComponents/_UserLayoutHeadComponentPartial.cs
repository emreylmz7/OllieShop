﻿using Microsoft.AspNetCore.Mvc;

namespace OllieShop.WebUI.Areas.User.ViewComponents.UserLayoutViewComponents
{
    public class _UserLayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
