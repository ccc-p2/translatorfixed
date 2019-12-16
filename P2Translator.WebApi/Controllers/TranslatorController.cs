using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace P2Translator.WebApi.Controllers 
{
  public class TranslatorController : ControllerBase
  {
    [HttpGet]
    public string GetLanguages()
    {
        return "Hello World";
    }
  }
}