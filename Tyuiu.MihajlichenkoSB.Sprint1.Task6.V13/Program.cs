using Tyuiu.MihajlichenkoSB.Sprint1.Task6.V13.Lib;
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
            Console.WriteLine("* Написать программу, которая вычисляет выражение 9*(6/2*3)/9/3            *");
            Console.WriteLine("* и печатает результат на экране.                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите строку:");

            string input = Console.ReadLine() ?? string.Empty;


            bool result = ds.CheckWordsAlphabet(input);

            if (result)
                Console.WriteLine("Буквы строки расположены по алфавиту.");
            else
                Console.WriteLine("Буквы строки НЕ расположены по алфавиту.");


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(ds.CheckWordsAlphabet(input));

            Console.ReadKey();
        }
    }
}
