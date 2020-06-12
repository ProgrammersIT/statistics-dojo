using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace StatisticsDojo
{
    interface MathOperations
    {
        int minValue(List<int> numbers);
        int max(List<int> numbers);
        int avg(List<int> numbers);
    }

    public class Statistics : MathOperations
    {
        public void calculateValues(List<int> numbers)
        {
            int count = numbers.Count;
            int min = minValue(numbers);

        }

        public int minValue(List<int> numbers)
        {
            return numbers.Min();
        }

        public int max(List<int> numbers)
        {
            return numbers.Max();
        }

        public int avg(List<int> numbers)
        {
            return numbers.Sum() / numbers.Count;
        }


    }

    //class Evaluator
    //{
    //    public Evaluator()
    //    {

    //    }
    //    public int MinValue { get; set; }
    //    public int MaxValue { get; set; }
    //}
}
