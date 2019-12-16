using System.Collections.Generic;
using P2Translator.WebApi.Controllers;
using Xunit;

namespace P2Translator.Testing.Web_Api
{
  public class TranslatorControllerTest
  {
    [Fact]
    public void TestGetAllLanguages()
    {
      var sut = new TranslatorController();
      var actual = sut.GetLanguages() as List<string>;
      Assert.True(actual.Count > 1);
    }
  }
}