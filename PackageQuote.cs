using System; // For console input/output

class PackageExpress
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Package weight
        Console.Write("Please enter the package weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Console.ReadLine();
            return;
        }

        // Package dimensions
        Console.Write("Please enter the package width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enter the package height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enter the package length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        if ((width + height + length) > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            Console.ReadLine();
            return;
        }

        // Calculate quote
        double quote = (width * height * length * weight) / 100;

        // Display quote
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote}");
        Console.WriteLine("Thank you!");

        Console.ReadLine();
    }
}
