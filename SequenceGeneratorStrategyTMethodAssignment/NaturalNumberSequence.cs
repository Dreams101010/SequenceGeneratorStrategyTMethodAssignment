namespace SequenceGeneratorStrategyTMethodAssignment
{
    class NaturalNumberSequence : AbstractSequence
    {
        public NaturalNumberSequence(int count) : base(count) { }
        public NaturalNumberSequence(int count, StrategyEnum strategyEnum) :
            base(count, strategyEnum) { }

        protected override void GenerateSequence(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                sequence.Add(i);
            }
        }
    }
}
