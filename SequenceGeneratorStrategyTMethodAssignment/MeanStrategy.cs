using System.Collections.Generic;

namespace SequenceGeneratorStrategyTMethodAssignment
{
    class MeanStrategy : ISequenceStrategy
    {
        public double PerformStrategy(List<int> seq)
        {
            if (seq.Count == 0) return 0;
            double accum = 0;
            foreach (var i in seq)
            {
                accum += i;
            }
            accum /= seq.Count;
            return accum;
        }
    }
}
