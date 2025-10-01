using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MihajlichenkoSB.Sprint1.Task6.V13.Lib
{
    public class DataService : ISprint1Task6V13
    {
        public bool CheckWordsAlphabet(string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            for (int i = 1; i < value.Length; i++)
            {
                if (char.ToLower(value[i]) < char.ToLower(value[i - 1]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}