using System;
using System.Linq;
using System.Reflection;
using LeetCode;

class Program
{
    static void Main()
    {
        // Find all classes implementing ILeetCodeProblem
        var problems = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => typeof(ILeetCodeProblem).IsAssignableFrom(t) && !t.IsInterface)
            .ToList();

        // Display available problems
        Console.WriteLine("Available Problems:");
        for (int i = 0; i < problems.Count; i++)
            Console.WriteLine($"{i + 1}. {problems[i].Namespace}");

        // Ask user to pick a problem
        Console.Write("\nEnter problem number to run: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= problems.Count)
        {
            Console.WriteLine($"\nRunning {problems[choice - 1].Namespace}:\n");

            // Create instance and run the selected problem
            ILeetCodeProblem problem = (ILeetCodeProblem)Activator.CreateInstance(problems[choice - 1]);
            problem.Run();
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
}
