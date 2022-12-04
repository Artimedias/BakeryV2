using System;
using System.Collections;
using System.Collections.Generic;
using BreadCalc;
using PastryCalc;


namespace Bakery
{
  public class BakeryFront
  {
    public static void Main()
    {
      Bread newBread = new Bread();
      Pastry newPastry = new Pastry();

      Console.WriteLine("Welcome to the Bakery! We have breads and donuts for sale today. Bread is buy 2 get one free at a price of 5 dollars a loaf. Can I interest you in any loaves of bread? Y/N");
      string userInput = Console.ReadLine();

      if (userInput == "Y" || userInput == "y")
      {
        Console.WriteLine("Fantatstic! How many loaves of bread would you like?");
        

        newBread.HowMany = int.Parse(Console.ReadLine());

        if(newBread.DealChecker(newBread.HowMany))
        {
          Console.WriteLine("You are eligiable for an extra free loaf of bread, would you like it? Y/N");
            userInput = Console.ReadLine();
             if (userInput == "Y" || userInput == "y")
             {
              Console.WriteLine("Adding it now!");
               newBread.HowMany =  newBread.HowMany + 1;
             }
             else
             {
              Console.WriteLine("No? Alright.");
             }
        }
      }
      else
      {
        Console.WriteLine("No bread today, got it!");
      }

      Console.WriteLine("Can I interest you in some donuts today perhaps? Theyre buy two get one for one, or 2 dollars individually. Y/N");
        userInput = Console.ReadLine();
          if (userInput == "Y" || userInput == "y")
          {
            Console.WriteLine("Wonderful! How many donuts would you like?");
        
        
        newPastry.HowMany = int.Parse(Console.ReadLine());

        if(newPastry.DealChecker(newPastry.HowMany))
        {
          Console.WriteLine("You are eligiable for an extra donut for only one dollar, would you like it? Y/N");
            userInput = Console.ReadLine();
             if (userInput == "Y" || userInput == "y")
             {
              Console.WriteLine("Adding it now!");
               newPastry.HowMany =  newPastry.HowMany + 1;
             }
             else
             {
              Console.WriteLine("No? Alright.");
             }
        }
          }

        else
        {
          Console.WriteLine("No Dounuts then? Got it!");
        }

      int price = newBread.BreadPrice(newBread.HowMany, 0);
      price = newPastry.PastryPrice(newPastry.HowMany, price);

      Console.WriteLine($"You purchased {newBread.HowMany} loaves of bread, and {newPastry.HowMany} donuts. Your total is {price} dollars. Thank you for shopping with us today.");
    }
  }
}