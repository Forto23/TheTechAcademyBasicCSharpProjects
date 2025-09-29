using System; // For console input/output

class CarInsuranceApproval
{
    static void Main()
    {
        // Print program title
        Console.WriteLine("Car Insurance Approval Program");

        // Ask for age
        Console.Write("What is your age? ");
        int age = Convert.ToInt32(Console.ReadLine()); // Convert input to integer

        // Ask about DUI
        Console.Write("Have you ever had a DUI? (true/false) ");
        bool hasDUI = Convert.ToBoolean(Console.ReadLine()); // Convert input to boolean

        // Ask about speeding tickets
        Console.Write("How many speeding tickets do you have? ");
        int tickets = Convert.ToInt32(Console.ReadLine()); // Convert input to integer

        // Check qualification rules
        bool qualified = age > 15 && !hasDUI && tickets <= 3;

        // Print result
        Console.WriteLine("\nQualified?");
        Console.WriteLine(qualified); // Will print true or false

        // Pause to view output
        Console.WriteLine("\nPress Enter to exit.");
        Console.ReadLine();
    }
}
