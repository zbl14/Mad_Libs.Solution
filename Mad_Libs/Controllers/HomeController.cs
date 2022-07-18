using Microsoft.AspNetCore.Mvc;
using Mad_Libs.Models;

namespace Mad_Libs.Controllers
{
  public class HomeController : Controller
  {
     [Route("/story")]
    public ActionResult Story(string person1, string person2, string animal, string exclamation, string verb, string noun) 
    {
      StoryVariable myStoryVariable = new StoryVariable();
      myStoryVariable.Person1 = person1;
      myStoryVariable.Person2 = person2;
      myStoryVariable.Animal = animal;
      myStoryVariable.Exclamation = exclamation;
      myStoryVariable.Verb = verb;
      myStoryVariable.Noun = noun;
      return View(myStoryVariable);
    }

    [Route("/")]
    public ActionResult Form() { return View(); }
  }
}