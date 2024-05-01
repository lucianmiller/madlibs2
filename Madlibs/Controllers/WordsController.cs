using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;
using System.Collections.Generic;

namespace Madlibs.Controllers
{
  public class WordsController : Controller
  {
    [Route("/madlibs")]
    public ActionResult Madlibs (string person1, string person2, string animal, string exclamation, string verb, string noun)
    {
      Words newStory = new Words(person1, person2, animal, exclamation, verb, noun);
      return View(newStory);
    }
  }
}