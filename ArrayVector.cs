namespace Laba1
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
            get => coordintates[index - 1];
            set => coordintates[index - 1] = value;
        }
        public int[] GetCoordinates()
        {
            return coordintates;
        }
        public double GetNorm()
        {
            return Math.Sqrt(coordintates.Sum(x => x * x));
        }
        public int SumPositivesFromChetIndex()
        {
            return coordintates.Where((number,index) => (number > 0) & ((index + 1) % 2 == 0)).Sum(p => p);
        }
        public int SumLessFromNechetIndex()
        {
            return coordintates.Where((number,index) => ((index + 1) % 2 != 0) & (number < coordintates.Sum(p => Math.Abs(p))/coordintates.Length)).Sum(p => p);
        }
        public int MultChet()
        {
            return coordintates.Where(p => (p > 0) & (p % 2 == 0)).Aggregate((x,y) => x * y);
        }
        public int MultNechet()
        {
            return coordintates.Where(p => (p % 3 != 0) & (p % 2 == 1)).Aggregate((x,y) => x * y);
        }
        public void SortUp()
        {
            coordintates = coordintates.OrderBy(p => p).ToArray();
        }
        public void SortDown()
        {
            coordintates = coordintates.OrderByDescending(p => p).ToArray();  
        }
    }
}