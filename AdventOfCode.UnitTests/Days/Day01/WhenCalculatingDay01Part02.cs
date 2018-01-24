using AdventOfCode.Logic.Days.Day01;
using Shouldly;
using Xunit;

namespace AdventOfCode.UnitTests.Days.Day01
{
    public class WhenCalculatingDay01Part02
    {
        [Fact]
        public void ShouldCorrectlyCalculateScenarioOne()
        {
            const int expectedResult = 6;
            var day = new Day01Part02("1212");
            var result = day.Calculate();

            result.ShouldBe(expectedResult);
        }

        [Fact]
        public void ShouldCorrectlyCalculateScenarioTwo()
        {
            const int expectedResult = 0;
            var day = new Day01Part02("1221");
            var result = day.Calculate();

            result.ShouldBe(expectedResult);
        }

        [Fact]
        public void ShouldCorrectlyCalculateScenarioThree()
        {
            const int expectedResult = 4;
            var day = new Day01Part02("123425");
            var result = day.Calculate();

            result.ShouldBe(expectedResult);
        }

        [Fact]
        public void ShouldCorrectlyCalculateScenarioFour()
        {
            const int expectedResult = 12;
            var day = new Day01Part02("123123");
            var result = day.Calculate();

            result.ShouldBe(expectedResult);
        }

        [Fact]
        public void ShouldCorrectlyCalculateScenarioFive()
        {
            const int expectedResult = 4;
            var day = new Day01Part02("12131415");
            var result = day.Calculate();

            result.ShouldBe(expectedResult);
        }
    }
}
