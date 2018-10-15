namespace Task3
{
    interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }
}
