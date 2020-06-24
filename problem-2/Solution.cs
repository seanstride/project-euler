using System;
using System.Collections.Generic;

namespace problem_2
{
    public class FibonacciGenerator
    {
        public List<int> GenerateSequence(int limit)
        {
            var sequence = new List<int>() { 1, 2 };

            var nextNumberInSequence = 0;
            while (nextNumberInSequence < limit)
            {
                nextNumberInSequence = sequence[sequence.Count - 2] + sequence[sequence.Count - 1];
                if (nextNumberInSequence < limit)
                {
                    sequence.Add(nextNumberInSequence);
                }
            }

            return sequence;
        }
    }
}