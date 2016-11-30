using Nancy;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Coin.Object;
using System;

namespace CoinProgram
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
        string userInput = Request.Form["user-amount"];
        int userAmount = int.Parse(userInput);
        Console.WriteLine("1");
        CoinCombo giveCoins = new CoinCombo(userAmount);
        Console.WriteLine("2");
        giveCoins.CountCoins();
        return View["index.cshtml", giveCoins];
      };
    }
  }
}
