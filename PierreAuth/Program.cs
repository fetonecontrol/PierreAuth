using System;
using System.Threading.Tasks;
using RestSharp;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace PierreAuth
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var apiCallTask = ApiHelper.ApiCall("[YOUR-API-KEY-HERE]");
            var result = apiCallTask.Result;
            Console.WriteLine(result);
        }
            class ApiHelper
        {
        public static async Task<string> ApiCall(string apiKey)
        {
        RestClient client = new RestClient("https://webknox-recipes.p.rapidapi.com/recipes/cuisine");
        RestRequest request = new RestRequest($"home.json?api-key={apiKey}", Method.GET);
        var response = await client.ExecuteTaskAsync(request);
        return response.Content;
        }
    }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
