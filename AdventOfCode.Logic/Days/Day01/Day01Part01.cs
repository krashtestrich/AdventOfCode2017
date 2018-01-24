namespace AdventOfCode.Logic.Days.Day01
{
    public class Day01Part01 : DayBase
    {
        public Day01Part01(string input)
            : base(input)
        {
        }

        public override int Calculate()
        {
            var sum = 0;
            var inputLength = Inputs.Count;
            for (var i = 0; i < inputLength; i++)
            {
                var nextIndex = i + 1;

                var nextValue = nextIndex < inputLength
                    ? Inputs[nextIndex] : Inputs[0];

                sum += Inputs[i] == nextValue ? Inputs[i] : 0;
            }

            return sum;
        }
    }
}
