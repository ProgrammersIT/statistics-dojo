using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace StatisticsDojo
{
    public class StatisticsTests
    {
        private Statistics _statistics;

        public StatisticsTests()
        {
            _statistics = new Statistics();
        }

        [Fact]
        public void Should_Return_MinValue()
        {
            var list = new List<int>() { 2, 4, 8, 20, 50 };
            var min = _statistics.minValue(list);
            int minValue = list.Min();
            Assert.Equal(min, minValue);

        }

        [Fact]
        public void Should_Return_MaxValue()
        {
            var list = new List<int> { 2, 4, 8, 20, 50 };
            var max = _statistics.max(list);
            int maxValue = list.Max();
            Assert.Equal(max, maxValue);
        }

        [Fact]
        public void Should_Return_Average()
        {
            var list = new List<int> { 2, 4, 8, 20, 50 };
            var avg = _statistics.avg(list);
            int avgValue = list.Sum() / list.Count();
            Assert.Equal(avg, avgValue);
        }

        public void Should_Return_CorrectLenght()
        {
            const int ArraySize = 5;
            var ArraySizeList = new List<int> { 4, 6, 74, 46, 563 };
            
        }

        //public void Should_Return_DivideByZeroException()
        //{
        //    var list = new List<int> { 0, 0, 0, 0, 0};
        //    Assert.Throws();

        //}
    }
}
