using Microsoft.AspNetCore.Mvc;
using Mad_Libs.Models;

namespace Mad_Libs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Theme() { return View(); }

    [Route("/formFantasticalAdventure")]
    public ActionResult FormFantasticalAdventure() { return View(); }
    
    [Route("/fantasticalAdventure")]
    public ActionResult FantasticalAdventure(string person1, string person2, string animal, string exclamation, string verb, string noun) 
    {
      FantasticalAdventureVariable fantasticalAdventureVariable = new FantasticalAdventureVariable();
      fantasticalAdventureVariable.Person1 = person1;
      fantasticalAdventureVariable.Person2 = person2;
      fantasticalAdventureVariable.Animal = animal;
      fantasticalAdventureVariable.Exclamation = exclamation;
      fantasticalAdventureVariable.Verb = verb;
      fantasticalAdventureVariable.Noun = noun;
      return View(fantasticalAdventureVariable);
    }

    [Route("/formFoodie")]
    public ActionResult FormFoodie() { return View(); }  

    [Route("/foodie")]
    public ActionResult Foodie(string food, string name, string noun, string adjective, string verb1, string verb2, string verb3)
    {
      FoodieVariable myFoodie = new FoodieVariable();
      myFoodie.Food = food;
      myFoodie.Name = name;
      myFoodie.Noun = noun;
      myFoodie.Adjective = adjective;
      myFoodie.Verb1 = verb1;
      myFoodie.Verb2 = verb2;
      myFoodie.Verb3 = verb3;
      return View(myFoodie);
    }   
  }
}