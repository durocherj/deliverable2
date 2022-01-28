using System;

namespace deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Hello, welcome to La Buffet! All you can eat for $9.99 per person. Water is free, but coffee is $2.\n" +
                " How many people in your party? Please note, we have a limt of 6 people max per party: ");
            int guests = int.Parse(Console.ReadLine());
            double perGuest = 9.99;
            int perCoffee = 2;

            if (guests <= 6)
            {
                Console.WriteLine("\n Table for " + guests + "! Great! Right this way.\n" +
                    "\n We'll start off with the drink orders, then you can help yourselves!\n" +
                    " The options are water or coffee.");
                int coffee = 0;
                int water = 0;
                for (int current = 1; current <= guests; current++)
                {                    
                    Console.Write("\n Guest " + current + ", water or coffee? ");
                    string drink = Console.ReadLine();
                    
                    if (drink == "coffee")
                    {
                        Console.WriteLine(" Ah, coffee! Excellent!!");
                        coffee++;
                    }
                    else if (drink == "water")
                    {
                        Console.WriteLine(" Ah, water! Excellent!!");
                        water++;
                    }
                    else
                    {
                        Console.WriteLine(" I'm sorry, we don't carry that!");
                    }
                }

                Console.WriteLine("\n Ok, so thats " + water + " waters and " + coffee + " coffees." +
                    "\n I'll bring your drinks around in a moment. You can go ahead and grab some grub!");

                double bill = (guests * perGuest) + (coffee * perCoffee);

                Console.WriteLine("\n Thank you so much for dining with us today!\n Your total comes to $" + bill);
                
            }
            else
            {
                Console.WriteLine("\n I'm sorry! Our max is 6 people per party. Have a nice day!");
            }

        }
    }
}
