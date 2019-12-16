using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using P2Translator.WebApi.Models;

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
        LanguageWebApi spanish = new LanguageWebApi("Spanish");
        return Ok(spanish);
    }
  }
}