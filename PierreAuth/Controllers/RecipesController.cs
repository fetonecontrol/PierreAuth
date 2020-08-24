using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PierreAuth.Models;

namespace PierreAuth.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            var allRecipes = Recipe.GetRecipes(EnvironmentVariables.ApiKey);
            return View(allRecipes);
        }
    }
}
