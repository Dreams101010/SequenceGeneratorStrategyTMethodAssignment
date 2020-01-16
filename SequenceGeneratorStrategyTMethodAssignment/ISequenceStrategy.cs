using System.Collections.Generic;

namespace SequenceGeneratorStrategyTMethodAssignment
{
    interface ISequenceStrategy
    {
        double PerformStrategy(List<int> seq);
    }
}
