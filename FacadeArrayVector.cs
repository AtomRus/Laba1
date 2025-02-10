namespace Laba1 
{
    public class FacadeArrayVector
    {
        public ArrayVector TryCreateVector(int[] coordinates)
        {
            return new ArrayVector(coordinates);
        }
        public void TryChangeVector(ArrayVector arrayVector, int index, int newVal)
        {
            arrayVector[index] = newVal;
        }
        public double TryGetNormalVector(ArrayVector arrayVector)
        {
            return arrayVector.GetNorm();
        }
    }
}