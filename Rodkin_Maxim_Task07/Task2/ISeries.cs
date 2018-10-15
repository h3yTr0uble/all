namespace Task2
{
    interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }
}
