using System;

namespace Beginner
{
    public class DateTimeFun
    {
        public void RunTests()
        {
        }

        //Task1
        private DateTime GetCustomDateTime()
        {
            // 1. Implement this method. It shoud return a DateTime object initialised to a date and time of your choice.
            // 2. Use this method in "RunTests()" to print its output to console
            // Bonus: Did you remove the "throw new NotImplementedException();" line? If not, how did it change behaviour of your method? 
            //        What does the line do and when should we use it?
            throw new NotImplementedException();
        }

        //Task2
        private bool IsWorkingDay(DateTime day)
        {
            // 1. Implement this method. It should return true if given day is working day, otherwise false. Ignore public holidays and other exceptional cases.
            // 2. Call this method in "RunTests()" and show its output for current date.
            throw new NotImplementedException();
        }

        //Task3
        private int NumberOfWorkingDaysInPreviousThreeDays(DateTime day)
        {
            // 1. Implement this method. It should return how many days were working days in 3 days before given dateTime (i.e. dateTime -1, -2 and -3)
            //    e.g. if dateTime is friday it returns 3, if dateTime is monday it returns 1
            //    Ignore public holidays and other exceptional dates.
            // 2. Demonstrate usage of the method in "RunTests()" for some date of your choosing
            throw new NotImplementedException();
        }

        //Task4
        private string PrintInfoAboutDay(DateTime day)
        {
            // 1. Implement this method. It should print "<given DateTime> is working day" or "<given DateTime> is non-working day".
            //    e.g. "1.1.2016 0:00:00 is working day" 
            //    Ignore public holidays and other exceptional dates.
            // 2. Demonstrate usage of the method in "RunTests()" for some date of your choosing
            throw new NotImplementedException();
        }

        //Task5
        private bool IsPublicHoliday(DateTime day)
        {
            // 1. Implement this method. It should return true for following days of the year, otherwise false:
            //    1st January
            //    8th May 
            //    24th December
            //    25th December
            //    26th December
            // 2. Demonstrate usage of the method in "RunTests()" for some date of your choosing
            throw new NotImplementedException();
        }

        //Task6
        private void PrintCombinedInfo()
        {
            // 1. Modify methods for tasks 2-4 to take into account public holidays (as defined in task 5). Call it from Main to demonstrate that it works.
            //    If done properly, method PrintCombinedInfo() should print following output:
            /*
                False
                0
                26.12.2017 0:00:00 is non-working day
                True
            */
            // 2. How many methods did you need to modify to make this work?
            // Bonus: If you had to modify more than one place, how can you change implementation of methods from tasks 2-4
            //        to make sure any future change to "Task5_IsPublicHoliday" will be automatically reflected in all of them?
            //        Refactor those methods now.
            var day = new DateTime(2017, 12, 26);
            Console.WriteLine(IsWorkingDay(day));//true -> false
            Console.WriteLine(NumberOfWorkingDaysInPreviousThreeDays(day));//1 -> 0
            Console.WriteLine(PrintInfoAboutDay(day));//working -> non-working
            Console.WriteLine(IsPublicHoliday(day));//true
        }
    }
}
