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
        double avg(List<int> numbers);
    }

    public class Statistics : MathOperations
    {
        public int calculateValues(List<int> numbers)
        {
            int count = numbers.Count;
            return minValue(numbers);
        }

        public int minValue(List<int> numbers)
        {
            return numbers.Min();
        }

        public int max(List<int> numbers)
        {
            return numbers.Max();
        }

        public double avg(List<int> numbers)
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
