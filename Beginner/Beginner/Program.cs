using System;

namespace Beginner
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureEnvironment(); //Do not remove this or strange things may start happening in some exercises!
        }

        //Task1
        // 1. Modify the "Main" method to make it wait for any key to be pressed before exiting
        // Search web for answers if you don't know how to do this. 
        // Hint: you only need to write one line of code.

        //Task2
        // 1. Print "Hello World" to the console
        // 2. Call this method from the "Main" method so that you can run the application and check that it works

        //Task3
        // 1. Initialise class DateTimeFun in the "Main" method and invoke its only public method
        // 2. Run the program to test your code.         

        //Task4
        // 1. Solve all tasks described in class DateTimeFun
        // Use what you did in Task3 to test your code

        //Task?
        // 1. What does the method ConfigureEnvironment() below do?
        // 2. Change value of the CultureNameForExercies constant to "us-en". What will be different in DateTimeFun exercises? Test it!
        // 3. What would happen if we didn't call the ConfigureEnvironment() method from Main() at all? Test it!
        private static void ConfigureEnvironment()
        {
            const string CultureNameForExercises = "uk-en";
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(CultureNameForExercises);
        }
    }
}
