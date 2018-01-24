namespace AdventOfCode.Logic.Days.Day01
{
    public class Day01Part02 : DayBase
    {
        public Day01Part02(string input) 
            : base(input)
        {
        }

        public override int Calculate()
        {
            var sum = 0;
            var inputLength = Inputs.Count;
            var stepSize = Inputs.Count / 2;

            for (var i = 0; i < inputLength; i++)
            {
                var nextIndex = i + stepSize;

                var nextValue = (nextIndex < inputLength)
                    ? Inputs[nextIndex]
                    : Inputs[nextIndex - inputLength];

                sum += Inputs[i] == nextValue ? Inputs[i] : 0;
            }

            return sum;
        }
    }
}
