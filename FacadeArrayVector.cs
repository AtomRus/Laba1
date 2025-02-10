using System.Security.Cryptography.X509Certificates;

namespace Laba1 
{
    public class FacadeArrayVector
    {
        public void TryChangeVector(ArrayVector arrayVector, int index, int newVal)
        {
            arrayVector[index] = newVal;
        }
        public ArrayVector TrySumVector(ArrayVector arrayVector1, ArrayVector arrayVector2)
        {
            if (arrayVector1.GetCoordinates().Length != arrayVector2.GetCoordinates().Length)
            {
                throw new Exception("Невозможно сложить вектора разных размерностей");
            }
            ArrayVector arrayVector = new ArrayVector(arrayVector1.GetCoordinates());
            for(int i = 0; i < arrayVector1.GetCoordinates().Length; i++)
            {
                arrayVector[i] = arrayVector1[i] + arrayVector2[i];
            }
            return arrayVector;
        }
        public ArrayVector MultiplyVectorByNumber(ArrayVector arrayVector, int digit)
        {
            for(int i = 0; i < arrayVector.GetCoordinates().Length; i++)
            {
                arrayVector[i] *= digit;
            }
            return arrayVector;
        }
    }
}