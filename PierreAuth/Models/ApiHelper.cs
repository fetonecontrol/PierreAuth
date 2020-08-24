using System.Threading.Tasks;
using RestSharp;

namespace PierreAuth.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"Dreams", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    public static async Task Post(string newDream)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"Dreams", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newDream);
      var response = await client.ExecuteTaskAsync(request);
    }
  }
}