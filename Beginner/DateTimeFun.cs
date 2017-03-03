using System;
using Xunit;

namespace CSharpDrill.Beginner
{
    public class DateTimeFun
    {
        // Return true if a date is a working day.
        [Theory]
        [InlineData(2017, 2, 27, true)]
        [InlineData(2017, 2, 28, true)]
        [InlineData(2017, 3, 1, true)]
        [InlineData(2017, 3, 2, true)]
        [InlineData(2017, 3, 3, true)]
        [InlineData(2017, 3, 4, false)]
        [InlineData(2017, 3, 5, false)]
        public void IsWorkingDay_ForGivenDate_ShouldReturnExpected(int year, int month, int day, bool expectedIsWorkingDay)
        {
            throw new NotImplementedException();

            var isWorkingDay = default(bool); // Implement

            Assert.Equal(expectedIsWorkingDay, isWorkingDay);
        }

        // Return number of preceding working days.
        [Theory]
        [InlineData(2017, 2, 27, 0, 0)]
        [InlineData(2017, 2, 27, 1, 0)]
        [InlineData(2017, 2, 27, 2, 0)]
        [InlineData(2017, 2, 27, 3, 1)]
        [InlineData(2017, 3, 1, 3, 2)]
        [InlineData(2017, 3, 2, 3, 3)]
        public void NumberOfPrecedingWorkingDays_ForGivenDate_ShouldReturnExpected(int year, int month, int day, int precedingDays, int expected)
        {
            throw new NotImplementedException();

            var numberOfWorkingDays = default(int);

            Assert.Equal(expected, numberOfWorkingDays);
        }

        // Format the datetime to get the expected string.
        [Fact]
        public void FormatDate_ShouldReturnExpected()
        {
            var date = new DateTime(2017, 02, 24, 15, 31, 45, 456);

            throw new NotImplementedException();

            var formatedDate = default(string);

            Assert.Equal("24.02.2017 03:31 PM", formatedDate);
        }

        // Return true if a day is a public holiday in the Czech Republic in 2017.
        [Theory]
        [InlineData(2017, 1, 1, true)]
        [InlineData(2017, 4, 14, true)]
        [InlineData(2017, 4, 17, true)]
        [InlineData(2017, 5, 1, true)]
        [InlineData(2017, 5, 8, true)]
        [InlineData(2017, 7, 5, true)]
        [InlineData(2017, 7, 6, true)]
        [InlineData(2017, 9, 28, true)]
        [InlineData(2017, 10, 28, true)]
        [InlineData(2017, 11, 17, true)]
        [InlineData(2017, 12, 24, true)]
        [InlineData(2017, 12, 25, true)]
        [InlineData(2017, 12, 26, true)]
        [InlineData(2017, 1, 2, false)]
        [InlineData(2017, 7, 4, false)]
        [InlineData(2017, 12, 31, false)]
        [InlineData(2016, 1, 1, false)]
        public void IsPublicHolidayIn2017_ForGivenDate_ShouldReturnExpected(int year, int month, int day, bool expectedIsPublicHoliday)
        {
            throw new NotImplementedException();

            var isPublicHolidayIn2017 = default(bool);
            Assert.Equal(expectedIsPublicHoliday, isPublicHolidayIn2017);
        }
    }
}