using System;

namespace CodingCoursesButThisTimeForFree
{
    internal class Program
    {
        static void Main()
        {
            int count = 0;

            Console.WriteLine("Main Number:");
            var mainNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n{mainNum} is your number.\nSimple Deviders:");

            for (int devider = 1; devider < mainNum; devider++)
            {
                if (mainNum % devider == 0)
                {
                    count++;
                    Console.Write($"{devider} ");
                }
            }

            if (count == 0)
                Console.WriteLine("No simple deviders has been found");
            else
                Console.WriteLine($"\nAmount of simple deviders: {count}");
        }
    }
}
