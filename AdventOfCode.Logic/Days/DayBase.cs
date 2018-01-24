using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Logic.Days
{
    public abstract class DayBase
    {
        protected readonly List<int> Inputs;

        protected DayBase(string input)
        {
            Inputs = ConvertInput(input);
        }

        public abstract int Calculate();

        private static List<int> ConvertInput(string input)
        {
            return input
                .Select(x => int.Parse(x.ToString()))
                .ToList();
        }
    }
}
