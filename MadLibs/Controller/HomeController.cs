using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/input")]
    public ActionResult Input() { return View(); }

    [Route("/output")]
    public ActionResult Output(string noun, string adjective) { 

        Words newWord = new Words(noun, adjective);

        return View(newWord); }
  }
}