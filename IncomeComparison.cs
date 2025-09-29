using System; // Import System namespace for Console input/output

// Declare the class
class IncomeComparison
{
    // Main method - entry point of the program
    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program"); // Program title

        // --------- Person 1 Input ---------
        Console.WriteLine("\nPerson 1");
        Console.Write("Hourly Rate? ");
        double person1Rate = Convert.ToDouble(Console.ReadLine()); // Convert input to double

        Console.Write("Hours worked per week? ");
        double person1Hours = Convert.ToDouble(Console.ReadLine());

        // --------- Person 2 Input ---------
        Console.WriteLine("\nPerson 2");
        Console.Write("Hourly Rate? ");
        double person2Rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Hours worked per week? ");
        double person2Hours = Convert.ToDouble(Console.ReadLine());

        // --------- Calculate Annual Salaries ---------
        double person1Salary = person1Rate * person1Hours * 52; // 52 weeks per year
        double person2Salary = person2Rate * person2Hours * 52;

        // --------- Print Results ---------
        Console.WriteLine("\nAnnual salary of Person 1:");
        Console.WriteLine(person1Salary);

        Console.WriteLine("Annual salary of Person 2:");
        Console.WriteLine(person2Salary);

        // --------- Compare Salaries ---------
        Console.WriteLine("\nPerson 1 makes more money than Person 2:");
        bool comparison = person1Salary > person2Salary;
        Console.WriteLine(comparison);

        // --------- End Program ---------
        Console.WriteLine("\nPress Enter to exit.");
        Console.ReadLine(); // Wait for user to press Enter before closing
    }
}

