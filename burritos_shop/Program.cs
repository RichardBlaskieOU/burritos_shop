using System;

class Program
{

    /* Go to Tools > Options. t
     * In the search bar at the top left of the window, type IntelliCode.
     * Find C# user model predictions (or "Whole line completions") and set it to Disabled.
     * */

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("=== Burritos Shop Break Even Points Calculator ===");
            Console.WriteLine("1) Using For Loop");
            Console.WriteLine("2) Using While Loop");
            Console.WriteLine("3) Using Do-While Loop");
            Console.WriteLine("4) Exit");
            Console.Write("\nSelect an option: ");

            string input = Console.ReadLine();

            if (input == "1")
            {
                using_for_loop();
            }
            else if (input == "2")
            {
                using_while_loop();
            }
            else if (input == "3")
            {
                using_dowhile_loop();
            }
            else if (input == "4")
            {
                Console.WriteLine("Exiting program...");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press any key to try again.");
                Console.ReadKey();
            }
        }
    }

    // --- Using For Loop ---

    static void using_for_loop()
    {

        /* A food truck sells burritos for $9 each.
         * Minimum cost per month is $1200 .
         * The unit cost per burrito is $3.80.
         * 
         * Write a program that:
         * 
         * Starts from 0 burritos sold.
         * Keeps increasing the number of burritos sold by 1 each time.
         * Calculates revenue, cost, and profit (revenue - cost).
         * Stops and reports the first number of burritos where the truck makes profit (revenue > cost).
         * 
         * Expected output:
         * ...
         * After selling 229 burritos: profit -9.20.
         * After selling 230 burritos: profit -4.00
         * ------------------------------------
         * Success! Profit reached.
         * Number of Burritos: 231 
         * Revenue: $2,079.00 
         * Cost: $2,077.80 
         * Profit: $1.20
         * 
        */


        Console.WriteLine("Calculating the break-even point using for loop ... ");
        Console.WriteLine("------------------------------------");

        // Please Enter Your For Loop Codes Here

        decimal unitPrice = 9.00m;
        decimal minCost = 1200m;
        decimal unitCost = 3.80m;
        int itemSold = 0;
        decimal cost = 0m;
        decimal revenue = 0m;
        decimal profit = 0m;

        for (itemSold = 0; ; itemSold++)
        {
            revenue = unitPrice * itemSold;
            cost = minCost + (unitCost * itemSold);
            profit = revenue - cost;

            if (profit <= 0)
            {
                Console.WriteLine($"After selling {itemSold} burritos: profit {profit:F2}");
            }
            else
            {
                
                break;
            }

        }
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("Success! Profit reached.");
        Console.WriteLine($"Number of burritos: {itemSold}");
        Console.WriteLine($"Revenue:  {revenue:c2}");
        Console.WriteLine($"Cost:  {cost:c2}");
        Console.WriteLine($"Profit:  {profit:c2}");

        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }

    // --- Using While Loop ---

    static void using_while_loop()
    {
        Console.WriteLine("Calculating the break-even point using while loop ... ");
        Console.WriteLine("------------------------------------");

        // Please Enter Your While Loop Codes Here

        decimal unitPrice = 9.00m;
        decimal minCost = 1200m;
        decimal unitCost = 3.80m;
        int itemSold = 0;
        decimal cost = 0m;
        decimal revenue = 0m;
        decimal profit = 0m;

        while (profit <= 0)
        {
            itemSold++;
            revenue = unitPrice * itemSold;
            cost = minCost + (unitCost * itemSold);
            profit = revenue - cost;
            if (profit <= 0)
            {

                Console.WriteLine($"After selling {itemSold} burritos: profit {profit:F2}");
            }
            else
            {

                break;
            }
        }
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("Success! Profit reached.");
        Console.WriteLine($"Number of burritos: {itemSold}");
        Console.WriteLine($"Revenue:  {revenue:c2}");
        Console.WriteLine($"Cost:  {cost:c2}");
        Console.WriteLine($"Profit:  {profit:c2}");

        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }
    


    // --- Using Do-While Loop ---

    static void using_dowhile_loop()
    {
        Console.WriteLine("Calculating the break-even point using do-while loop ... ");
        Console.WriteLine("------------------------------------");

        // Please Enter Your Do-While Loop Codes Here
        decimal unitPrice = 9.00m;
        decimal minCost = 1200m;
        decimal unitCost = 3.80m;
        int itemSold = 0;
        decimal cost = 0m;
        decimal revenue = 0m;
        decimal profit = 0m;
        do
        {
            itemSold++;
            revenue = unitPrice * itemSold;
            cost = minCost + (unitCost * itemSold);
            profit = revenue - cost;

            if (profit <= 0)
            {
                Console.WriteLine($"After selling {itemSold} burritos: profit {profit:F2}");
            }
            else { 

            break; 
            }
        }
        while (profit <= 0); 

        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("Success! Profit reached.");
        Console.WriteLine($"Number of burritos: {itemSold}");
        Console.WriteLine($"Revenue:  {revenue:c2}");
        Console.WriteLine($"Cost:  {cost:c2}");
        Console.WriteLine($"Profit:  {profit:c2}");


        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }
}