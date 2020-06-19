using System;
using System.Collections.Generic;

namespace problem_1
{
    public class MultiplesCalculator
    {
        public int SumMultiplesOf3And5Below(int limit)
        {
            var result = 0;
            for (var i = 1; i < limit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }
            return result;
        }
    }
}