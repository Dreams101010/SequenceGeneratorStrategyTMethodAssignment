using System.Collections.Generic;

namespace SequenceGeneratorStrategyTMethodAssignment
{
    class MultiplicationStrategy : ISequenceStrategy
    {
        public double PerformStrategy(List<int> seq)
        {
            double accum = 1;
            foreach (var i in seq)
            {
                accum *= i;
            }
            return accum;
        }
    }
}
