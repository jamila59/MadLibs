  
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Models
{
  public class Words
  {
    public string Noun { get; set; }
    public string Adjective { get; set; }

    public Words(string noun, string adjective)
    {
        Noun = noun;
        Adjective = adjective;
    }
  }
}