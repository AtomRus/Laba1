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
            get => coordintates[index];
            set => coordintates[index] = value;
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
            int product = 1;
            bool f = false;

            foreach (int element in coordintates)
            {
                if (element > 0 && element % 2 == 0)
                {
                    f = true;
                    product *= element;
                    if (product == 0) return 0;
                }
            }

            if (!f)
            {
                return 0;
            }
            
            return product;
        }
        public int MultNechet()
        {
            int product = 1;
            bool f = false;

            foreach (int element in coordintates)
            {
                if (element % 2 != 0 && element % 3 != 0)
                {
                    f = true;
                    product *= element;
                    if (product == 0) return 0;
                }
            }

            if (!f)
            {
                return 0;
            }

            return product;
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