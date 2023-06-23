using System;

namespace Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();

            int projectsCount = int.Parse(Console.ReadLine());

            int hours = projectsCount * 3;

            Console.WriteLine
                ($"The architect {architectName} will need {hours} hours to complete {projectsCount} project/s.");
        }
    }
}
