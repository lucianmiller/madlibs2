using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController
  {
    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }

    [Route("/madlibs")]
    public ActionResult Madlibs (string person1, string person2, string animal, string exclamation, string verb, string noun)
    {
      StoryInputs newStory = new StoryInputs();
      newStory.Person1 = person1;
      newStory.Person2 = person2;
      newStory.Animal = animal;
      newStory.Exclamation = exclamation;
      newStory.Verb = verb;
      newStory.Noun = noun;
      return View(newStory);
    }
  }
}