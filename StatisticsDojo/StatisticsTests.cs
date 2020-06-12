using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticsDojo
{
    class StatisticsTests
    {
        private readonly Statiscis _statistic;
        public StatisticsTests()
        {
            
        }

        [Fact]
        [InlineData(-3, 4, 5, 1)]
        public async Task Should_Return_MinValue(int number1, int number2, int number3, int number4)
        {
            List<int> numbersToEvaluate = new List<int>();
            numbersToEvaluate.Add(number1);
            numbersToEvaluate.Add(number2);
            numbersToEvaluate.Add(number3);
            numbersToEvaluate.Add(number4);


            Console.WriteLine(numbersToEvaluate.Min());

            Assert


        }
    }
}
