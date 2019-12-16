using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace P2Translator.Client.Models 
{
  public class HttpClientModel
  {
    private HttpClient client = new HttpClient();
    public async Task RunAsync()
  {
      // Update port # in the following line.
      client.BaseAddress = new Uri("http://localhost:5000/");
      client.DefaultRequestHeaders.Accept.Clear();
      client.DefaultRequestHeaders.Accept.Add(
      new MediaTypeWithQualityHeaderValue("application/json"));
  }
    public async Task<List<MessageViewModel>> GetMessagesAsync(string path)
    {
    List<MessageViewModel> messages = null;
    HttpResponseMessage response = await client.GetAsync(path);
    if (response.IsSuccessStatusCode)
    {
        messages = await response.Content.ReadAsAsync<List<MessageViewModel>>();
    }
    return messages;
    }
    public async Task<List<LanguageViewModel>> GetLanguagesAsync(string path)
    {
    List<LanguageViewModel> languages = null;
    HttpResponseMessage response = await client.GetAsync(path);
    if (response.IsSuccessStatusCode)
    {
        languages = await response.Content.ReadAsAsync<List<LanguageViewModel>>();
    }
    return languages;
    }
  }
}