using Tyuiu.MihajlichenkoSB.Sprint1.Task1.V16.Lib;
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
            Console.WriteLine("* Тема: Организация ввода / вывода в консольных приложениях                *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #16                                                              *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович | ИИП6-25-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* вычисляет результат по формуле x*5*a+2*y и печатает его на экране.       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            double x, a, y;

            Console.WriteLine("Введите значение Х");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение A");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(ds.Calculate(x, a, y));

            Console.ReadKey();
        }
    }
}