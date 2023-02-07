using System;
using System.Linq;
using System.Threading.Tasks;
using System.Numerics;

namespace Calculator.Additional_Code
{
    public class FactorialCalculate
    {
        static readonly int DegreeOfParallelism = Environment.ProcessorCount;

        public BigInteger Factorial(long x)
        {
            Task<BigInteger>[] parallelTasks =
                Enumerable.Range(1, DegreeOfParallelism)
                            .Select(i => Task.Factory.StartNew(() => Multiply(x, i),
                                         TaskCreationOptions.LongRunning))
                            .ToArray();

            Task.WaitAll(parallelTasks);

            BigInteger finalResult = 1;

            foreach (BigInteger partialResult in parallelTasks.Select(t => t.Result))
            {
                finalResult *= partialResult;
            }

            return finalResult;
        }

        public BigInteger Multiply(long upperBound, int startFrom)
        {
            BigInteger result = 1;

            for (int i = startFrom; i <= upperBound; i += DegreeOfParallelism)
                result *= i;

            return result;
        }
    }
}
