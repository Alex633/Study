using System;

namespace CodingCoursesButThisTimeForFree
{
    internal class Program
    {
        static void Main()
        {
            string input;
            int angle;
            bool youDummy = false;


            while (true)
            {
                if (!youDummy)
                {
                    Console.WriteLine("Please, enter current time (hour):");
                }
                else
                {
                    Console.WriteLine("Please, enter current time (hour), you dummy :");
                }
                Console.WriteLine(new string('_', 24));
                input = Console.ReadLine();
                if (int.TryParse(input, out int hour))
                {
                    if (hour < 0)
                    {
                        Console.WriteLine("There is no such thing as negative time, DUMMY\n");
                        youDummy = true;

                    }
                    else if (hour > 23)
                    {
                        Console.WriteLine("There is only 23 hours, DUMMY\n");
                        youDummy = true;
                    }
                    else
                    {
                        angle = CalculateAngle(hour);
                        Console.WriteLine($"When hour is {hour}; angle is {angle}\n");
                    }
                }
                else
                {
                    Console.WriteLine($"'{input}' is not a Number, DUMMY\n");
                    youDummy = true;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        static int CalculateAngle(int hour)
        {
            int angle = 0;

            if (hour < 12) //0 - 12
            {
                angle = hour * 30;
            }
            else if (hour > 12 && hour < 24) //13 - 23
            {
                angle = (hour - 12) * 30;
            }

            if ((hour > 6 && hour <= 12) || (hour > 18 && hour < 24))
            {
                if (hour == 12)
                {
                    angle = 0;
                }
                else
                {
                    angle = 360 - angle;
                }
            }

            return angle;
        }
    }
}
