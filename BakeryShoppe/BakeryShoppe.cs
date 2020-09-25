using System;
using Bakery.Models;

namespace BakeryShoppe
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery Shoppe! We offer the finest Breads and Pastries around. Would you like to purchase something? Enter y for yes and n for no.");
      string userToShopInput = Console.ReadLine();

      if (userToShopInput == "y")
      {
        Console.WriteLine("How many loaves of bread would you like today?");
        string breadAmountRequested = Console.ReadLine();
        int breadAmount = int.Parse(breadAmountRequested);

      
        Console.WriteLine("Very good. And would you like to purchase any pastries? Please enter the amount you would like.");
        string pastryAmountRequested = Console.ReadLine();
        int pastryAmount = int.Parse(pastryAmountRequested);

        int totalCost = Bread.CalculateBread(breadAmount) + Pastry.CalculatePastry(pastryAmount);

        Console.WriteLine("Thank you for your purchases. Your total today will be $" + totalCost);

        // Console.WriteLine("Thank you for your purchases. Your total today for bread will be: $" + Bread.CalculateBread(breadAmount));
        // Console.WriteLine("Thank you for your purchases. Your total today for pastries will be: $" + Pastry.CalculatePastry(pastryAmount));
      }
      else
      {
        Console.WriteLine("Then have a nice day!");
      }
    }
  }
}
