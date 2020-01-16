using System.Collections.Generic;
namespace SequenceGeneratorStrategyTMethodAssignment
{
    class AdditionStrategy : ISequenceStrategy
    {
        public double PerformStrategy(List<int> seq)
        {
            double accum = 0;
            foreach (var i in seq)
            {
                accum += i;
            }
            return accum;
        }
    }
}
