using System.ComponentModel;

namespace Laba1 
{
    public class SolutionFirstTask : AbstractSolution
    {
        public int GetCoordinate(ArrayVector arrayVector)
        {
            Console.WriteLine("Выберите нужную координату");
            int index = InputDataIntoTryParseInt();
            while (index < 0 || index > arrayVector.GetCoordinates().Length)
            {
                Console.WriteLine("Ошибка. Неподходящий индекс. Введите индекс заново");
                index = InputDataIntoTryParseInt();
            }
            return arrayVector[index - 1];
        }
        public void SetCoordinate(ArrayVector arrayVector)
        {
            int index = InputDataIntoTryParseInt();
            while (index < 0 || index > arrayVector.GetCoordinates().Length)
            {
                Console.WriteLine("Ошибка. Неподходящий индекс. Введите индекс заново");
                index = InputDataIntoTryParseInt();
            }
            Console.WriteLine("Выберите новую координату");
            int newCoord = InputDataIntoTryParseInt();
            arrayVector[index - 1] = newCoord;
        }
        public ArrayVector CreateVector()
        {
            Console.WriteLine("Введите размерность вектора");
            int dim = InputDataIntoTryParseInt();
            while (dim < 1)
            {
                Console.WriteLine("Некорректный ввод! Введите размерность вектора");
                dim = InputDataIntoTryParseInt();
            }
            int[] inputCoordinates = new int[dim];
            for(int i = 0 ; i < dim; i++)
            {
                Console.WriteLine("Введите " + i + "-ую координату вектора");
                inputCoordinates[i] = InputDataIntoTryParseInt();
            }
            return new ArrayVector(inputCoordinates);
        }
        public double GetNormalVector(ArrayVector arrayVector)
        {
            return arrayVector.GetNorm();
        }
        public int GetSumPositivesFromChetIndex(ArrayVector arrayVector)
        {
            return arrayVector.SumPositivesFromChetIndex();
        }
        public int GetSumLessFromNechetIndex(ArrayVector arrayVector)
        {
            return arrayVector.SumLessFromNechetIndex();
        }
        public double GetMultChet(ArrayVector arrayVector)
        {
            return arrayVector.MultChet();
        }
        public double GetMultNechet(ArrayVector arrayVector)
        {
            return arrayVector.MultNechet();
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