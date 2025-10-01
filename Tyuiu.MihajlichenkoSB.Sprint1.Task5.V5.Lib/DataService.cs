using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MihajlichenkoSB.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            if (x < 0)
                throw new ArgumentException("Число должно быть положительным.");

            x = x - Math.Floor(x);
            x *= 10;
            return (int)Math.Floor(x);
        }
    }
}
