namespace LAba1
{
    public class ArrayVector
    {
        int[] coordintates;
        public ArrayVector()
        {
            coordintates = new int[5];
        }
        public ArrayVector(int[] coordinates)
        {
            this.coordintates = coordinates;
        }
        public int this[int index]
        {
            get => coordintates[index];
            set => coordintates[index] = value;
        }
        public double GetNorm()
        {
            return Math.Sqrt(coordintates.Sum(x => x * x));
        }
        public int SumPositivesFromChetIndex()
        {
            return coordintates.Where(p => (p > 0) & (p % 2 == 0)).Sum(p => p);
        }

    }
}