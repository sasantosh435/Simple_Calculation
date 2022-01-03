using System;

namespace Simple_Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.ReadLine();
            MainMenu();
            //Cal();
        }
        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to my App");
            Console.WriteLine("");
            Console.WriteLine("Option 1. Introduction");
            Console.WriteLine("Option 2. Calculations");
            Console.WriteLine("Option 3. Exit");
            Console.WriteLine("Please type 1 or 2 or 3 to navigate");


            string myOptions;
            myOptions = Console.ReadLine();
            switch (myOptions)
            {
                case "1":
                    Intro();
                    break;
                case "2":
                    Cal();
                    break;
                case "3":
                    Exit();
                    break;
            }
            Console.ReadLine();

            MainMenu();
        }
        static void Intro()
        {
            Console.WriteLine("This is my Intro");
            Console.ReadLine();
        }
        static void Cal()
        {
            Console.WriteLine("Please add your age");
            int vall = int.Parse(Console.ReadLine());


            Console.WriteLine("You will need {0} years to be able to drive!: (0)", 20 - vall);
            Console.ReadLine();
        }
        static void Exit()
        {
            Console.WriteLine("Are you sure you would like to exit the program?");
            Console.WriteLine("Press the Enter key on the keyboard to confirm!");
            Console.ReadLine();
            System.Environment.Exit(1);
        }
       
    }
}
