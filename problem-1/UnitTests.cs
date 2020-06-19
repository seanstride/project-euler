using System;
using System.Collections.Generic;
using Xunit;

namespace problem_1
{
    public class GivenTheMultiplesOf3And5Below10
    {
        [Fact]
        public void WhenSummedUpTheyEqual23()
        {
            var multiplesCalculator = new MultiplesCalculator();
            var result = multiplesCalculator.SumMultiplesOf3And5Below(10);
            Assert.Equal(23, result);
        }
    }

    public class GivenTheMultiplesOf3And5Below1000
    {
        [Fact]
        public void WhenSummedUpTheyEqual233168()
        {
            var multiplesCalculator = new MultiplesCalculator();
            var result = multiplesCalculator.SumMultiplesOf3And5Below(1000);
            Assert.Equal(233168, result);
        }
    }
}
