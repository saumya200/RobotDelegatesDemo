using System;

namespace RobotDelegatesDemo
{
    class Program
    {
        private static Action action;

        //step 1: Create a delegate
        delegate void RobotAction();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Robot Task Manager");

            //Step 2: Create actions
            Console.WriteLine("\nChoose a task for the robot:");
            Console.WriteLine("1- Dance");
            Console.WriteLine("2- Sing");
            Console.WriteLine("3- Wave");

            string choice = Console.ReadLine();

            // Step 3: Assign method to delegate based on the user input
            switch (choice)
            {
                case "1":
                    action = Dance;
                    break;

                case "2":
                    action += Sing;
                    break;

                case "3":
                    action += Wave;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Robot will just wave.");
                    action = Wave;
                    break;
            }

            //step 4: Execute the delegate
            Console.WriteLine("\nRobot is performing your chosen action...");
            action();

        }

        static void Dance()
        {
            Console.WriteLine("The robot is dancing!");
        }

        static void Sing()
        {
            Console.WriteLine("The robot is singing!");
        }


        static void Wave()
        {
            Console.WriteLine("The robot is waving!");
        }
    }
}