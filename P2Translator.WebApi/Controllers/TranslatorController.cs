using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace P2Translator.WebApi.Controllers 
{
  [Produces("application/json")]
  [Route("/api/[controller]/[action]")]
  [ApiController]
  public class TranslatorController : ControllerBase
  {
    [HttpGet]
    public IActionResult GetLanguages()
    {
        List<string> languages = new List<string>();
        languages.Add("Spanish");
        languages.Add("English");
        return Ok(languages);
    }
  }
}