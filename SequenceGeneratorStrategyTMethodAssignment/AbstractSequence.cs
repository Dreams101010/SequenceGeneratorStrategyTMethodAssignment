using System;
using System.Collections.Generic;

namespace SequenceGeneratorStrategyTMethodAssignment
{
    // Abstract sequence
    abstract class AbstractSequence
    {
        protected List<int> sequence = null;
        protected ISequenceStrategy strategy = null;

        // Constructor is template method
        public AbstractSequence(int count)
        {
            if (count <= 0)
            {
                throw new ArgumentException("Count must be positive.");
            }
            sequence = new List<int>();
            GenerateSequence(count);
            strategy = new AdditionStrategy();
        }

        // Selecting strategy via enum
        public AbstractSequence(int count, StrategyEnum strategyEnum) : this(count)
        {
            switch (strategyEnum)
            {
                case StrategyEnum.Addition:
                    {
                        strategy = new AdditionStrategy();
                        break;
                    }
                case StrategyEnum.Multiplication:
                    {
                        strategy = new MultiplicationStrategy();
                        break;
                    }
                case StrategyEnum.Mean:
                    {
                        strategy = new MeanStrategy();
                        break;
                    }
            }
        }

        protected abstract void GenerateSequence(int count);
        public void Print()
        {
            foreach (var i in sequence)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public double PerformStrategy()
        {
            return strategy.PerformStrategy(sequence);
        }
    }
}
