using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Brennan Buffet - an all you can eat buffet experience for $9.99! You only pay extra for a Coke.\n");

        int people = 0;
        int water = 0;
        int coke = 0;
        int index = 1;
        bool valid = false;

        while (!valid)
        {
            Console.WriteLine("How many people are in your group today? We only are able to seat parties of 6 or less.");
            people = int.Parse(Console.ReadLine());
            if (people >= 1 && people <= 6)
            {
                Console.WriteLine("\nA table for " + people + "! Please follow me and have a seat. \nLet's start with some drinks. We have water or Coke.\n");
                valid = true;

                while (index <= people)
                {
                    Console.Write("Person " + index + " what would you like to drink? ");
                    string drink = Console.ReadLine().ToLower();
                    index++;

                    if (drink == "water")
                    {
                        Console.WriteLine("\nWater, excellent choice!\n");
                        water++;
                    }
                    else if (drink == "coke")
                    {
                        Console.WriteLine("\nCoke, great choice!\n");
                        coke++;
                    }
                    else
                    {
                        Console.WriteLine("\nI'm sorry we do not have that drink. You'll have water.\n");
                        water++;
                    }

                }
                Console.WriteLine("Okay, so that's " + water + " waters and " + coke + " cokes. I'll be right back with those. Go ahead and grab some food.");

                double total = (people * 9.99) + (coke * 2.00) + (water * 0);
                Console.WriteLine("\nYour total today comes to: " + total);
            }

            else
            {
                Console.WriteLine("\nI'm sorry. At this time, we are only accepting parties up to 6. Have a nice day.\n");
                break;
            }
        }
    }
}