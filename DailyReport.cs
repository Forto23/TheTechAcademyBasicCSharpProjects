using System;

class DailyReport
{
    static void Main()
    {
        // Header
        Console.WriteLine("Academy of Learning Career College");
        Console.WriteLine("Student Daily Report.\n");

        // Ask for student's name
        Console.Write("What is your name? ");
        string studentName = Console.ReadLine();

        // Ask course
        Console.Write("What course are you on? ");
        string courseName = Console.ReadLine();

        // Ask page number
        Console.Write("What page number? ");
        int pageNumber = int.Parse(Console.ReadLine());

        // Ask if they need help
        Console.Write("Do you need help with anything? Please answer 'true' or 'false': ");
        bool needsHelp = bool.Parse(Console.ReadLine());

        // Positive experiences
        Console.Write("Were there any positive experiences you'd like to share? ");
        string positiveExperiences = Console.ReadLine();

        // Additional feedback
        Console.Write("Is there any other feedback you'd like to provide? ");
        string additionalFeedback = Console.ReadLine();

        // Hours studied
        Console.Write("How many hours did you study today? ");
