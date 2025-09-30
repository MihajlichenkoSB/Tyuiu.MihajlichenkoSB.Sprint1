using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MihajlichenkoSB.Sprint1.Task4.V19.Lib
{
    public class DataService : ISprint1Task4V19
    {
        public double Calculate(double x, double y)
        {
            if (Math.Abs(x - 2) < 1e-9)
                throw new DivideByZeroException("Знаменатель равен нулю!");

            double result = (x + y) / Math.Abs(x - 2);
            return Math.Round(result, 3);
        }
    }
}
