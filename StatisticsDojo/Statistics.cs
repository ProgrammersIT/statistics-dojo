using System;
using System.Collections.Generic;
using System.Security.Principal;
using Xunit;

namespace StatisticsDojo
{
    public class Statiscis
    {
        [Fact]
        [InlineData(-3, 4, 5, 1)]
        public void Should_Return_MinValue(int number1, int number2, int number3, int number4)
        {
            List<int> numbersToEvaluate = new List<int>();
            numbersToEvaluate.Add(number1);
            numbersToEvaluate.Add(number2);
            numbersToEvaluate.Add(number3);
            numbersToEvaluate.Add(number4);

            foreach(var i in numbersToEvaluate)
            {

            };

        }
    }

    class Evaluator
    {
        public Evaluator()
        {

        }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
    }
}
