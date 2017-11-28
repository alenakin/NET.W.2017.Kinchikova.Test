using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6.Solution
{
    public class SequanceGenerator<T>
    {
        public static IEnumerable<T> GenerateSequance(T a, T b, int n, Func<T, T, T> func)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException("n must be greater than zero");
            }

            return CalculateSequance(a, b, n, func);
        }

        private static IEnumerable<T> CalculateSequance(T a, T b, int n, Func<T, T, T> func)
        {
            T x = a;
            T y = b;
            yield return x;

            for (int i = 2; i <= n; i++)
            {
                yield return y;
                T temp = y;
                y = func(y, x);
                x = temp;
            }
        }
    }
}
