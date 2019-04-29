using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {

    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")]
    public ActionResult Letter() {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient("Jessica");
      myLetterVariable.SetSender("John");
      return View(myLetterVariable);
    }

    [Route("/my-fab-journal")]
    public ActionResult Journal() { return View(); }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender, string location1, string location2, string souvenirs)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient(recipient);
      myLetterVariable.SetSender(sender);
      myLetterVariable.SetLocation1(location1);
      myLetterVariable.SetLocation2(location2);
      myLetterVariable.SetSouvenirs(souvenirs);
      return View(myLetterVariable);
    }

  }
}
