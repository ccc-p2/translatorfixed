using System.Collections.Generic;
using P2Translator.Data;
using P2Translator.WebApi.Controllers;
using Xunit;

namespace P2Translator.Testing.Web_Api
{
  public class TranslatorControllerTest
  {
    private readonly P2TranslatorDbContext _db;
    public TranslatorControllerTest(P2TranslatorDbContext _db)
    {
        this._db = _db;
    }
  }
}