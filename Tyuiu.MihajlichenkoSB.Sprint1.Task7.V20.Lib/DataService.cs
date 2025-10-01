using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MihajlichenkoSB.Sprint1.Task7.V20.Lib
{
    public class DataService : ISprint1Task7V20
    {
        public double Calculate(double x, double y)
        {
            double numerator = 2 + Math.Pow(Math.Cos(x + y), 2);
            double denominator = 1 + Math.Abs(x - (3 * x) / (1 + Math.Pow(x * y, 2)));
            double result = numerator / denominator + x * y;

            return Math.Round(result, 3);
        }
    }
}
