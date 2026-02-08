namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int progross = 0;
            int maxAllowedSteps = 7;
            int safteyStopPoint = 5;
            int skippedStep = 3;

            bool menuActive = true;

            while (menuActive)
            {
                Console.WriteLine("1. Start/Continue Routine");
                Console.WriteLine("2. View Progress");
                Console.WriteLine("3. Exit");
                Console.Write("Enter Choice:");

                int userChoice = int.Parse(Console.ReadLine());

                if (userChoice == 1)
                {
                    if (progross >= safteyStopPoint)
                    {
                        Console.WriteLine("Saftey limit has reached. Routine Stopped.");
                        continue;
                    }

                    if (progross >= maxAllowedSteps)
                    {
                        Console.WriteLine("Maximum steps reached. Routine is complete.");
                        continue;
                    }

                    progross++;

                    if (progross == skippedStep)
                    {
                        Console.WriteLine($"Step {progross} is restricted and was skipped.");
                        continue;
                    }

                }

            }

        }
    }
}
