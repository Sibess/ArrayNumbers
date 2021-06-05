using System;
using System.Linq;

namespace ArrayNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindMinMax(new double[] {1.346, 1.6532, 1.8734, 1.8723}));
        }

        public static double[] FindMinMax(double[] values)
        {
            double[] minMax = {values.Min(), values.Max()};
            return minMax;
        }
    }
}
