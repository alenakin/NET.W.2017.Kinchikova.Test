using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Solution
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, IAveragingAlgorithm averagingMethod)
        {
            CheckInput(values, averagingMethod);

            return averagingMethod.CalculateAverage(values);
        }

        public double CalculateAverage(List<double> values, Func<List<double>, double> averagingMethod)
        {
            CheckInput(values, averagingMethod);

            return averagingMethod(values);
        }

        private void CheckInput(List<double> values, object averagingMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (averagingMethod == null)
            {
                throw new ArgumentNullException(nameof(averagingMethod));
            }
        }
    }
}
