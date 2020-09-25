using System;
using Bakery.Models;

namespace BakeryShoppe
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery Shoppe! We offer the finest Breads and Pastries around, but we also love a good discount! Every third bread is free and every third pastry is a $1 off.");
      Console.WriteLine("Would you like to purchase something? Enter 'y' for yes and 'n' for no.");
      string userToShopInput = Console.ReadLine().ToLower();

      if (userToShopInput == "y")
      {
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Let's start with our bread selection. We offer two types: Rye and Sourdough. Would you like to purchase bread? Please enter 'y' for yes and 'n' for no.");
        string userBreadPurchase = Console.ReadLine().ToLower();

        if (userBreadPurchase == "y")
        {
          Console.WriteLine("Please enter what bread type you would like first:");
          string firstBreadType = Console.ReadLine().ToLower();
          
          Console.WriteLine($"Very good. And how many loaves of {firstBreadType} would you like today?");
          string breadAmountRequested = Console.ReadLine();
          int breadAmount = int.Parse(breadAmountRequested);

          Console.WriteLine("Would you like to select the other bread type as well? Please type 'y' for yes and 'n' for no.");
          string userSecondBreadSelection = Console.ReadLine().ToLower();
         
          if (userSecondBreadSelection == "y")
          {
            Console.WriteLine("And how many loaves of that would you like?");
            string breadAmountRequestedSecond = Console.ReadLine();
            int breadAmountSecond = int.Parse(breadAmountRequestedSecond);

            int totalBreadRequested = breadAmount + breadAmountSecond;

            Console.WriteLine("Very good. And would you like to purchase any pastries? Please enter the amount you would like.");
            string pastryAmountRequested = Console.ReadLine();
            int pastryAmount = int.Parse(pastryAmountRequested);

            Bread breadOrder = new Bread(totalBreadRequested);
            Pastry pastryOrder = new Pastry(pastryAmount);
            int totalCost = breadOrder.CalculateBread() + pastryOrder.CalculatePastry();

            Console.WriteLine("Thank you for your purchases. Your total today will be $" + totalCost + ". Have a nice day, and come again!");
          }
          else
          {
            Console.WriteLine("Very good. And would you like to purchase any pastries? Please enter the amount you would like.");
            string pastryAmountRequested = Console.ReadLine();
            int pastryAmount = int.Parse(pastryAmountRequested);

            Bread breadOrder = new Bread(breadAmount);
            Pastry pastryOrder = new Pastry(pastryAmount);
            int totalCost =  breadOrder.CalculateBread() + pastryOrder.CalculatePastry();

            Console.WriteLine("Thank you for your purchases. Your total today will be $" + totalCost + ". Have a nice day, and come again!");
          }
        }
        else
        {
          Console.WriteLine("Very good. And would you like to purchase any pastries? Please enter the amount you would like.");
          string pastryAmountRequested = Console.ReadLine();
          int pastryAmount = int.Parse(pastryAmountRequested);

          Pastry pastryOrder = new Pastry(pastryAmount);
          int totalCost =  pastryOrder.CalculatePastry();

          Console.WriteLine("Thank you for your purchases. Your total today will be $" + totalCost + ". Have a nice day, and come again!");
        }
      }
      else
      {
        Console.WriteLine("Then have a nice day!");
      }
    }
  }
}