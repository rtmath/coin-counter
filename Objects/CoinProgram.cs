using System;

namespace Coin.Object
{
  public class CoinCombo
  {
    private int _amount;
    public int numQuarters {get; set;}
    public int numDimes {get; set;}
    public int numNickles {get; set;}
    public int numPennies {get; set;}

    public CoinCombo(int newAmount)
    {
      _amount = newAmount;
      numQuarters = 0;
      numDimes = 0;
      numNickles = 0;
      numPennies = 0;
    }

    public void CountCoins()
    {
      int changeToCount = _amount;
      while (changeToCount > 0)
      {
        System.Console.WriteLine(changeToCount);
        if (changeToCount >= 25)
        {
          numQuarters += changeToCount / 25;
          changeToCount = changeToCount % 25;
        }
        else if (changeToCount >= 10)
        {
          numDimes += changeToCount / 10;
          changeToCount = changeToCount % 10;
        }
        else if (changeToCount >= 5)
        {
          numNickles += changeToCount / 5;
          changeToCount = changeToCount % 5;
        }
        else
        {
          numPennies += changeToCount / 1;
          break;
        }
      }
    }
  }
}
