// using System.Threading.Tasks;
// using RestSharp;

// namespace PierreAuth.Models
// {
//   class ApiHelper
//   {
//     public static async Task<string> ApiCall(string apiKey)
//     {
//       RestClient client = new RestClient("https://api.spoonacular.com/recipes/complexSearch");
//       RestRequest request = new RestRequest($"home.json?api-key={apiKey}", Method.GET);
//       var response = await client.ExecuteTaskAsync(request);
//       return response.Content;
//     }
//   }
// }