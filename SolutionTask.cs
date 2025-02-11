using System.ComponentModel;

namespace Laba1 
{
    public class SolutionTask 
    {
        public double InputDataIntoTryParseDouble()
        {
            double variable;
            string inputData = Console.ReadLine();
            while (!Double.TryParse(inputData, out variable))
            {
                Console.WriteLine("Некорректный ввод данных. Введите еще раз число");
                inputData = Console.ReadLine();
            }
            return variable;
        }
        public int InputDataIntoTryParseInt()
        {
            int variable;
            string inputData = Console.ReadLine();
            while (!Int32.TryParse(inputData, out variable))
            {
                Console.WriteLine("Некорректный ввод данных. Введите еще раз число");
                inputData = Console.ReadLine();
            }
            return variable;
        }
        public void ShowCoordinates(ArrayVector arrayVector)
        {
            Console.WriteLine();
            Console.Write("Координаты вектора: ");
            for(int i = 0; i < arrayVector.GetCoordinates().Length; i++)
            {
                Console.Write(arrayVector[i] + " ");
            }
            Console.WriteLine();
        }
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
        public double GetNormVector(ArrayVector arrayVector)
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
        public void SortCoordinates(ArrayVector arrayVector)
        {
            arrayVector.SortUp();
        }
        public void SortCoordinatesDescending(ArrayVector arrayVector)
        {
            arrayVector.SortDown();
        }
    }
}