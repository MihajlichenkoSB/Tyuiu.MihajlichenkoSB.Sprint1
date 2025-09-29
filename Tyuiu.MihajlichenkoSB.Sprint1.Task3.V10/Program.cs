using System.Globalization;
using Tyuiu.MihajlichenkoSB.Sprint1.Task3.V10.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint1.Task0.V18
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;

            DataService ds = new DataService();
            Console.Title = "Спринт #1 |  Выполнил: Михайличенко С.Б. | ИИПб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                  *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #10                                                              *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович | ИИП6-25-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая преобразует введенное с клавиатуры дробное   *");
            Console.WriteLine("* число в денежный формат. Ответ округлите до 3 знаков после запятой.      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.Write("Введите дробное число -> ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(ds.NumberToMoney(number));

            Console.ReadKey();
        }
    }
}