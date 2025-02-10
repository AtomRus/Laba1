namespace Laba1
{
    public abstract class AbstractSolution
    {
        protected double InputDataIntoTryParseDouble()
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
        protected int InputDataIntoTryParseInt()
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
    }
}