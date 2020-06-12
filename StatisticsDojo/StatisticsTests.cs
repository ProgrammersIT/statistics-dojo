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
            var list = new List<int>();
            const int minValue = 1;
            Assert.Equal(list.Min(), minValue);
            list.Add(1);
            list.Add(3);
        }
    }
}
