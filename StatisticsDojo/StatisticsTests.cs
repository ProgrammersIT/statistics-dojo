using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StatisticsDojo
{
    class StatisticsTests
    {
        private Statistics _statistics;

        public StatisticsTests()
        {
            _statistics = new Statistics();
        }

        [Fact]
        [InlineData(-3, 4, 5, 1)]
        public async Task Should_Return_MinValue(params int[] list)
        {
            const int minValue = 1;
            Assert.Equal(list.Min(), minValue);
        }
    }
}
