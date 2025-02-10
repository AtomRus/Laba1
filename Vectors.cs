using Laba1;

namespace Laba
{
    public class Vectors
    {
        public static ArrayVector SumSt(ArrayVector arrayVector1, ArrayVector arrayVector2)
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
        public static int ScalarSt(ArrayVector arrayVector1, ArrayVector arrayVector2)
        {
            if (arrayVector1.GetCoordinates().Length != arrayVector2.GetCoordinates().Length)
            {
                throw new Exception("Невозможно произвести скалярное произведение векторов разных размерностей");
            }
            int sum = 0;
            for(int i = 0; i < arrayVector1.GetCoordinates().Length; i++)
            {
                sum += arrayVector1[i] * arrayVector2[i];
            }
            return sum;
        }
        public static ArrayVector MultNumberSt(ArrayVector arrayVector, int digit)
        {
            for(int i = 0; i < arrayVector.GetCoordinates().Length; i++)
            {
                arrayVector[i] *= digit;
            }
            return arrayVector;
        }
        public static double GetNormSt(ArrayVector arrayVector)
        {
            return arrayVector.GetNorm();
        }
    }
}