using Tyuiu.MihajlichenkoSB.Sprint1.Task5.V5.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint1.Task0.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 |  Выполнил: Михайличенко С.Б. | ИИПб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                         *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #18                                                              *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович | ИИП6-25-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                     *");
            Console.WriteLine("* Присвоить целой переменной d первую цифру из дробной части положительного*");
            Console.WriteLine("* вещественного числа x(так, если x = 32.597, то d = 5).                   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.Write("Введите положительное число: ");

            if (double.TryParse(Console.ReadLine(), out double x) && x > 0)
            {
                int d = ds.Calculate(x);
                Console.WriteLine($"Первая цифра дробной части: {d}");
            }
            else
            {
                Console.WriteLine("Ошибка ввода! Введите положительное вещественное число.");
            }
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(ds.Calculate(x));

            Console.ReadKey();
        }
    }
}