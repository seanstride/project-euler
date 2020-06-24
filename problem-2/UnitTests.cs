using System;
using System.Linq;
using Xunit;

namespace problem_2
{
    public class GivenTheTermsInTheFibonacciSequenceBelowNinety
    {
        [Fact]
        public void WhenTheEvenNumbersInTheSequenceAreSummedTogetherThenTheResultIsFourtyFour()
        {
            var fibonacciGenerator = new FibonacciGenerator();
            var sequence = fibonacciGenerator.GenerateSequence(90);
            var result = sequence.Where(x => x % 2 == 0).Sum();
            Assert.Equal(44, result);
        }
    }
    public class GivenTheTermsInTheFibonacciSequenceBelowFourMillion
    {
        [Fact]
        public void WhenTheEvenNumbersInTheSequenceAreSummedTogetherThenTheResultIsX()
        {
            var fibonacciGenerator = new FibonacciGenerator();
            var sequence = fibonacciGenerator.GenerateSequence(4000000);
            var result = sequence.Where(x => x % 2 == 0).Sum();
            Assert.Equal(4613732, result);
        }
    }
}
