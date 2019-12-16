using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using P2Translator.Data;

namespace P2Translator.WebApi.Controllers 
{
  [Produces("application/json")]
  [Route("/api/[controller]/[action]")]
  [ApiController]
  public class TranslatorController : ControllerBase
  {
    
    private readonly P2TranslatorDbContext _db;
    public TranslatorController(P2TranslatorDbContext _db)
    {
        this._db = _db;
    }

    [HttpGet]
    public IActionResult GetLanguages()
    {
      List<string> languages = new List<string>();
      languages.Add("Spanish");
      languages.Add("English");
      return Ok(languages);
    }
    [HttpGet]
    public object GetMessage()
    {
      return _db.Message.Where(m => m.Content.Contains("Content")).Select((c) => new 
      {
        Id = c.MessageId,
        Content = c.Content,
        MessageDateTime = c.MessageDateTime
      }).ToList();
    }
  }
}