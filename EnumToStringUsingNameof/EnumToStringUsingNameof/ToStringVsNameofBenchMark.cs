
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;

namespace EnumToStringUsingNameof
{

    [MemoryDiagnoser]
    public class ToStringVsNameofBenchMark
    {

        [Benchmark]
        public void ConverToStringUsignNameof()
        {
            var dayString = nameof(DaysofWeek.Monday);
            Console.WriteLine(dayString);
        }

        [Benchmark]
        public void ConvertToStringUsingToString()
        {
            var day = DaysofWeek.Monday;
            var dayString = day.ToString();
            Console.WriteLine(dayString);
        }

    }
}
