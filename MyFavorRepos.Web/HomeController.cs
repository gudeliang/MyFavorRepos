﻿using Microsoft.AspNetCore.Mvc;

namespace MyFavorRepos.Web
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Redirect("/MyFavorRepos.html");
        }
    }
}
