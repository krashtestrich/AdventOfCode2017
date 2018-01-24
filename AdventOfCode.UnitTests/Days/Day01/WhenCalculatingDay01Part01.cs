using AdventOfCode.Logic.Days.Day01;
using Shouldly;
using Xunit;

namespace AdventOfCode.UnitTests.Days.Day01
{
    public class WhenCalculatingDay01Part01
    {
        [Fact]
        public void ShouldCorrectlyCalculateScenarioOne()
        {
            const int expectedResult = 3;
            var day = new Day01Part01("1122");
            var result = day.Calculate();

            result.ShouldBe(expectedResult);
        }

        [Fact]
        public void ShouldCorrectlyCalculateScenarioTwo()
        {
            const int expectedResult = 4;
            var day = new Day01Part01("1111");
            var result = day.Calculate();

            result.ShouldBe(expectedResult);
        }

        [Fact]
        public void ShouldCorrectlyCalculateScenarioThree()
        {
            const int expectedResult = 0;
            var day = new Day01Part01("1234");
            var result = day.Calculate();

            result.ShouldBe(expectedResult);
        }

        [Fact]
        public void ShouldCorrectlyCalculateScenarioFour()
        {
            const int expectedResult = 9;
            var day = new Day01Part01("91212129");
            var result = day.Calculate();

            result.ShouldBe(expectedResult);
        }
    }
}
