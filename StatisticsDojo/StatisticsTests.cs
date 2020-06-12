using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public async Task Should_Return_MinValue()
        {
            var list = new List<int>() { 2, 4, 8, 20, 50 };
            var min = _statistics.minValue(list);
            int minValue = list.Min();
            Assert.Equal(min, minValue);

        }

        [Fact]
        public async Task Should_Return_MaxValue()
        {
            var list = new List<int> { 2, 4, 8, 20, 50 };
            var max = _statistics.max(list);
            int maxValue = list.Max();
            Assert.Equal(max, maxValue);
        }

        [Fact]
        public async Task Should_Return_Average()
        {
            var list = new List<int> { 2, 4, 8, 20, 50 };
            var avg = _statistics.avg(list);
            int avgValue = list.Sum() / list.Count();
            Assert.Equal(avg, avgValue);
        }
    }
}
