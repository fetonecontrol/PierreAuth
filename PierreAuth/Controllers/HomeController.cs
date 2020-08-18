using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PierreAuth.Models;

namespace PierreAuth.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allRecipes = Recipe.GetArticles(EnvironmentVariables.ApiKey);
            return View();
        }
    }
}
