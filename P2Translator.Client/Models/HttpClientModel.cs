using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace P2Translator.Client.Models 
{
  public class HttpClientModel
  {
    static HttpClient client = new HttpClient();
    static async Task RunAsync()
  {
      // Update port # in the following line.
      client.BaseAddress = new Uri("http://localhost:5000/");
      client.DefaultRequestHeaders.Accept.Clear();
      client.DefaultRequestHeaders.Accept.Add(
          new MediaTypeWithQualityHeaderValue("application/json"));
  }
  static async Task<List<MessageViewModel>> GetProductAsync(string path)
    {
    List<MessageViewModel> messages = null;
    HttpResponseMessage response = await client.GetAsync(path);
    if (response.IsSuccessStatusCode)
    {
        messages = await response.Content.ReadAsAsync<List<MessageViewModel>>();
    }
    return messages;
    }
  }
}