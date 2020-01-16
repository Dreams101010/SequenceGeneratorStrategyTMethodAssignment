using System;

namespace SequenceGeneratorStrategyTMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractSequence seq = new FactorialSequence(10, StrategyEnum.Multiplication);
            seq.Print();
            Console.WriteLine(seq.PerformStrategy());
            Console.ReadKey();
        }
    }
}
