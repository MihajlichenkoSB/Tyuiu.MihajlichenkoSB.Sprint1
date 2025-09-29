using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MihajlichenkoSB.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
            number = Math.Round(number, 3, MidpointRounding.AwayFromZero);
            int rubles = (int)Math.Floor(number);
            int kopeks = (int)Math.Round((number - rubles) * 100, 0, MidpointRounding.AwayFromZero);
            string numberFormatted = number.ToString(CultureInfo.InvariantCulture);
            return $"{numberFormatted} руб. - это {rubles} руб. {kopeks:D2} коп.";
        }
    }
}
