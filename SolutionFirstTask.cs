namespace Laba1 
{
    public class SolutionFirstTask : AbstractSolution
    {
        FacadeArrayVector facadeArrayVector = new FacadeArrayVector();

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
            ArrayVector arrayVector = new ArrayVector();
            try
            {
                arrayVector = facadeArrayVector.TryCreateVector(inputCoordinates);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            return arrayVector;
        }
        public void ChangeVector(ArrayVector arrayVector)
        {
            Console.WriteLine("Введите изменяемую координату");
            int coordinate = InputDataIntoTryParseInt();
            Console.WriteLine("Введите изменяемую координату");
            int newVal = InputDataIntoTryParseInt();
            try
            {
                facadeArrayVector.TryChangeVector(arrayVector, coordinate, newVal);
            } catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
        public double GetNormalVector(ArrayVector arrayVector)
        {
            return facadeArrayVector.TryGetNormalVector(arrayVector);
        }
        
    }
}