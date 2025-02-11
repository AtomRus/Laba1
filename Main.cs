using System.ComponentModel.Design;

namespace Laba1 
{
public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Задание 0.  
            Прочитать необходимый теоретический материал. 
            Задание 1. 
            Описать класс с именем «ArrayVector». Класс описывает вектор в n-мерном пространстве. 
            Координаты конца вектора задаются массивом, количество элементов которого равно n – 
            размерности пространства. Класс должен иметь следующую структуру: 
             поле – массив элементов целого типа (координаты вектора в пространстве); 
             конструктор с параметром – длиной массива; 
             конструктор без параметров, создающий массив из 5 элементов; 
             метод SetElement() установки элемента массива по индексу, параметры метода – 
            индекс элемента и устанавливаемое значение; 
             метод GetElement() чтения элемента массива по индексу, параметр метода – индекс 
            элемента; 
            Примечание: вместо методов SetElement() и GetElement() можно реализовать 
            индексатор – он будет необходим в последующих лабораторных работах; 
             метод GetNorm() вычисления модуля (длины, нормы) вектора; 
             метод SumPositivesFromChetIndex() подсчета суммы всех положительных элементов 
            массива с четными номерами; 
             метод SumLessFromNechetIndex() подсчета суммы тех элементов массива, которые 
            имеют нечетные номера и  одновременно меньше среднего значения всех модулей 
            элементов массива; 
             метод MultChet() подсчета произведения всех четных положительных элементов (по 
            значению); 
             метод MultNechet() подсчета произведения всех нечетных элементов (по значению), не 
            делящихся на три; 
            Примечание: во всех четырех методах производящих действия с элементами массива 
            нумерация элементов массива для конечного пользователя должна начинаться с 
            единицы. То есть, в массиве [2, 3, 4, 5] элемент со значением «3» это второй элемент 
            по индексу с точки зрения пользователя; 
             метод SortUp() сортировки массива по возрастанию; 
             метод SortDown() сортировки массива по убыванию. 
            Где необходимо выбрасывать и обрабатывать разные типы исключений. 
            Задание 2. 
            Добавить класс с именем «Vectors», содержащий публичные статические методы: 
             сложения двух векторов SumSt(), который принимает в качестве параметра 2 объекта 
            типа ArrayVector и возвращает новый объект ArrayVector; 
             скалярного произведения двух векторов ScalarSt(), который принимает в качестве 
            параметра 2 объекта типа ArrayVector и возвращает целое число; 
             умножения вектора на число MultNumberSt(), который принимает в качестве 
            параметра объект типа ArrayVector и целое число и возвращает новый объект 
            ArrayVector. 
             получения модуля/нормы/длины вектора GetNormSt(), который принимает в качестве 
            параметра объект типа ArrayVector и возвращает вещественное число. 
            Выбрасывать исключения во всех методах в случае невозможности проведения указанных 
            действий над векторами (например, FormatException). 
            Задание 3. 
            В классе Program в методе Main() реализовать всю функциональность описанного класса – 
            написать программу, проверяющую все (!) разработанные элементы (члены) классов. 
            Отлавливать все возможные исключения – некорректный ввод пункта меню, 
            некорректный ввод данных, несовпадение длин векторов в статических методах класса 
            Vectors и т.д. То есть сделать программу правильно реагирующей на предсказуемые 
            ошибки. 
            Задание 4. 
            Подготовить отчет о работе.
            ");
            List<string> mainHeaders = new List<string>();
            mainHeaders.Add("ArrayVector");
            mainHeaders.Add("Vectors");
            mainHeaders.Add("Сказать программе Auf Wiedersehen");
            List<string> firstMenuHeaders = new List<string>();
            firstMenuHeaders.Add("Создать вектор");
            firstMenuHeaders.Add("Получить координату вектора");
            firstMenuHeaders.Add("Изменить координату вектора");
            firstMenuHeaders.Add("Получить нормаль вектора");
            firstMenuHeaders.Add("Посчитать сумму положительных координат с четными номерами");
            firstMenuHeaders.Add("Посчитать сумму координат с нечетными номерами такие, что a_n < (|a_1|+|a_n|+..+|a_n|)/n");
            firstMenuHeaders.Add("Посчитать произведение положительных координат с четными номерами");
            firstMenuHeaders.Add("Посчитать произведение координат с нечетными номерами, которые не делятся на 3");
            firstMenuHeaders.Add("Отсортировать координаты по возростанию");
            firstMenuHeaders.Add("Отсортировать координаты по убыванию");
            firstMenuHeaders.Add("В главное меню");
            List<string> secondMenuHeaders = new List<string>();
            secondMenuHeaders.Add("Проверить сложение векторов");
            secondMenuHeaders.Add("Проверить умножение вектора на скаляр");
            secondMenuHeaders.Add("Проверить скалярное произведение");
            secondMenuHeaders.Add("Проверить вычисление модуля вектора");
            secondMenuHeaders.Add("В главное меню");
            bool main_flag = true;
            int kursor = 1;
            while (main_flag)
            {
                Console.WriteLine("Выберите тестируемый класс");
                kursor = MenuRendering(mainHeaders, kursor);
                switch (kursor)
                {
                    case 1:
                    SolutionFirstTask solutionFirstTask = new SolutionFirstTask();
                    ArrayVector arrayVector = new ArrayVector();
                    bool existArrayVector = false;
                    bool firstMenuFlag = true;
                    kursor = 1;
                    while (firstMenuFlag)
                    {
                        kursor = MenuRendering(firstMenuHeaders, kursor);
                        switch (kursor)
                        {
                            case 1:
                            arrayVector = solutionFirstTask.CreateVector();
                            Console.WriteLine("Вектор успешно создан!");
                            solutionFirstTask.ShowCoordinates(arrayVector);
                            existArrayVector = true;
                            break;
                            case 2:
                            if (existArrayVector)
                            {
                                Console.WriteLine("Вектор не создан!");
                            }
                            else 
                            {
                                Console.WriteLine(solutionFirstTask.GetCoordinate(arrayVector));
                            }
                            break;
                            case 3:
                            if (existArrayVector)
                            {
                                Console.WriteLine("Вектор не создан!");
                            }
                            else 
                            {
                                solutionFirstTask.SetCoordinate(arrayVector);
                                Console.WriteLine("Координата успешно обновилась!");
                                solutionFirstTask.ShowCoordinates(arrayVector);
                            }
                            break;
                            case 4:
                            if (existArrayVector)
                            {
                                Console.WriteLine("Вектор не создан!");
                            }
                            else 
                            {
                                Console.WriteLine("Нормаль вектора: " + solutionFirstTask.GetNormVector(arrayVector));
                            }
                            break;
                            case 5:
                            if (existArrayVector)
                            {
                                Console.WriteLine("Вектор не создан!");
                            }
                            else 
                            {
                                Console.WriteLine("Cумма положительных координат с четными номерами: " + solutionFirstTask.GetSumPositivesFromChetIndex(arrayVector));
                            }
                            break;
                            case 6:
                            if (existArrayVector)
                            {
                                Console.WriteLine("Вектор не создан!");
                            }
                            else 
                            {
                                Console.WriteLine("Сумма координат с нечетными номерами такие, что a_n < (|a_1|+|a_n|+..+|a_n|)/n: " + solutionFirstTask.GetSumPositivesFromChetIndex(arrayVector));
                            }
                            break;
                            case 7:
                            if (existArrayVector)
                            {
                                Console.WriteLine("Вектор не создан!");
                            }
                            else 
                            {
                                Console.WriteLine("Произведение положительных координат с четными номерами: " + solutionFirstTask.GetMultChet(arrayVector));
                            }
                            break;
                            case 8:
                            if (existArrayVector)
                            {
                                Console.WriteLine("Вектор не создан!");
                            }
                            else 
                            {
                                Console.WriteLine("Произведение координат с нечетными номерами, которые не делятся на 3: " + solutionFirstTask.GetMultNechet(arrayVector));
                            }
                            break;
                            case 9:
                            if (existArrayVector)
                            {
                                Console.WriteLine("Вектор не создан!");
                            }
                            else 
                            {
                                solutionFirstTask.SortCoordinates(arrayVector);
                                Console.WriteLine("Сортировка произвдедена!");
                                solutionFirstTask.ShowCoordinates(arrayVector);
                            }
                            break;
                            case 10:
                            if (existArrayVector)
                            {
                                Console.WriteLine("Вектор не создан!");
                            }
                            else 
                            {
                                solutionFirstTask.SortCoordinatesDescending(arrayVector);
                                Console.WriteLine("Сортировка произвдедена!");
                                solutionFirstTask.ShowCoordinates(arrayVector);
                            }
                            break;
                            case 11:
                            firstMenuFlag = false;
                            break;
                        }
                    }
                    break;
                    case 2:
                    break;
                }
            }
        }
        public static void ShowContent(int k, List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (i == k)
                {
                    Console.WriteLine("->"+list[i]);
                }
                else
                {
                    Console.WriteLine("  " +list[i]);
                }
            }
        }
        public static int MenuRendering(List<String> headers_list, int index_cursor)
        {
            index_cursor = 1;
            ConsoleKey KEY_KEYBOARD;
            ShowContent(index_cursor, headers_list);
            while ((KEY_KEYBOARD = Console.ReadKey(true).Key) != ConsoleKey.Enter)
            {
                switch (KEY_KEYBOARD)
                {
                    case ConsoleKey.UpArrow:
                        index_cursor--;
                        if (index_cursor == 0)
                        {
                            index_cursor = headers_list.Count - 1;
                        }
                        Console.Clear();
                        ShowContent(index_cursor, headers_list);
                        break;
                    case ConsoleKey.DownArrow:
                        index_cursor++;
                        if (index_cursor == headers_list.Count) {
                            index_cursor = 1;
                        }
                        Console.Clear();
                        ShowContent(index_cursor, headers_list);
                        break;
                }
            }
            return index_cursor;
        }
    }
}