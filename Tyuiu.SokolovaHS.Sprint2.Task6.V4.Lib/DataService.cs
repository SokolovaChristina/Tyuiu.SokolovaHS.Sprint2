using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SokolovaHS.Sprint2.Task6.V4.Lib
{
    public class DataService : ISprint2Task6V4
    {
        public string FindCardSuit(int value)
        {
            switch (value)
            {
                case 1: return "Пики";
                case 2: return "Трефы";
                case 3: return "Бубны";
                case 4: return "Червы";
                default: throw new ArgumentException($"Мастей может быть только от 1 до 4. Значение {value}"); ;
            }
        }
    }
}
