using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PierreAuth.Models
{
  public class Recipe
  {
    public string Section { get; set; }
    public string Title { get; set; }
    public string Abstract { get; set; }
    public string Url { get; set; }
    public string Byline { get; set; }

    public static List<Recipe> GetRecipes(string apiKey)
    {
      var apiCallTask = ApiHelper.ApiCall(apiKey);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Recipe> articleList = JsonConvert.DeserializeObject<List<Recipe>>(jsonResponse["results"].ToString());

      return articleList;
    }
  }
}