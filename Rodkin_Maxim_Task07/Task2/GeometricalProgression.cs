namespace Task2
{
    class GeometricalProgression:ISeries
    {
        double start, step;
        int currentIndex;

        public GeometricalProgression(double start, double step)
        {
            this.start = start;
            this.step = step;
            this.currentIndex = 1;
        }

        public double GetCurrent()
        {
            var result = start;
            for (int i = 1; i < currentIndex; i++)
            {
                result *= step;
            }
            return result;
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 1;
        }
    }
}
