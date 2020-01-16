namespace SequenceGeneratorStrategyTMethodAssignment
{
    class FactorialSequence : AbstractSequence
    {
        public FactorialSequence(int count) : base(count) { }

        public FactorialSequence(int count, StrategyEnum strategyEnum) :
            base(count, strategyEnum)
        { }

        protected override void GenerateSequence(int count)
        {
            int curValue = 1;
            for (int i = 1; i <= count; i++)
            {
                curValue *= i;
                sequence.Add(curValue);
            }
        }
    }
}
