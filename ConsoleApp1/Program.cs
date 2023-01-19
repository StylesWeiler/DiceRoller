using System;

class DiceSimulator
{
    static void Main()
    {
        Random randomNum = new Random(); // random number generated
        long[] rollCount = new long[13]; // holds the sum of the two dice rolled 
        long totalRolls; // counts the number of times a dice is rolled

        // write the opening lines and ask for number of rolls from user
        Console.Write("Welcome to the dice throwing simulator!");
        Console.Write("\n\n");
        Console.Write("Enter the number of times to roll the dice:");

        // store number in variable
        totalRolls = int.Parse(Console.ReadLine());

        Console.Write("\n");

        // for loop to roll each dice which is then total and added to the array
        for (int x = 0; x < totalRolls; x++)
        {
            int firstRoll = randomNum.Next(1, 7); // Generate a random number between 1 and 6 for the first die
            int secondRoll = randomNum.Next(1, 7); // Generate a random number between 1 and 6 for the second die
            int rollTotal = firstRoll + secondRoll; // Calculate the total of the two dice rolls
            rollCount[rollTotal]++; // Increment the count of the corresponding total roll
        }

        // print results 
        Console.Write("DICE ROLLING SIMULATION RESULTS");
        Console.Write("\n");
        Console.Write("Each \" * \" represents 1% of the total number of rolls.");
        Console.Write("\n");
        Console.Write("Total number of rolls = " + totalRolls + ".");
        Console.Write("\n\n");

        for (int y = 2; y <= 12; y++)
        {
            double rollPercent = (double)rollCount[y] / totalRolls * 100; // Calculate a percent for the dice rolling results
            Console.Write(y + ": "); // create histogram

            for (int z = 0; z < rollPercent; z++)
            {
                Console.Write("*"); // Print a * for each 1% of the total rolls
            }
            Console.WriteLine();
        }
        // write goodbye statement below outputted results
        Console.Write("\n");
        Console.Write("Thank you for using the dice throwing simulator. Goodbye!");
        Console.ReadLine();
    }

}