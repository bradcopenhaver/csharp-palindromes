using Nancy;
using System;
using Palindrome.Objects;

namespace Palindrome
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };
      Post["/result"] = _ =>
      {
        PalindromeChecker newChecker = new PalindromeChecker(Request.Form["input"]);
        newChecker.ToLowerAndTrim();
        return View["index.cshtml", newChecker];
      };
    }
  }
}
