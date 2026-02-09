using System.ComponentModel.Design;
using System.Xml.Serialization;

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            int currentStep = 0;
            int completedSteps = 0;
            int maxSteps = 6;
            int restrictedStep = 4;
            int safetyLimit = 5;
            bool routineActive = true;
                Console.WriteLine();
                Console.WriteLine("1. start/ continue Routine");
                Console.WriteLine("2. View progress");
                Console.WriteLine("3. exit");
            do
            {
                Console.WriteLine();
                Console.Write("Enter Choice:");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                    if (!routineActive)
                    {
                        Console.WriteLine(" Routine has already emded. ");
                        continue;
                    }  
                        currentStep++;
                if (currentStep == restrictedStep)
                {
                    Console.WriteLine(" step " + currentStep + " is restricted and is skipped ");
                }
                else if (currentStep == safetyLimit)
                {
                    Console.WriteLine(" safety limit reached. Routine stopped ");
                    routineActive = false;
                }
                else if (currentStep <= maxSteps)
                {
                    Console.WriteLine(" routine step " + currentStep + " completed ");
                    completedSteps++;
                }
                if (currentStep >= maxSteps)
                {
                    routineActive = false;
                    Console.WriteLine(" Routine has Already ended");
                }
               else if (choice == 2)
                {
                    Console.WriteLine(" current progress: " + completedSteps + " steps completed.");
                }
                else if (choice == 3)
                {
                    Console.WriteLine(" program endded.");
                    break;
                }
            } while (routineActive);
        }
    }
}
/*
 * The loop exist because it is used to automate repatitive task.
 * 
 * 
 * The steps ar skipped because there can be a lack of understanding.
 * 
 * 
 */