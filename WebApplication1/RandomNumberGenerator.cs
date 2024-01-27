namespace WebApplication1
{
    public class RandomNumberGenerator
    {
        private readonly Random random;

        public RandomNumberGenerator()
        {
            // Инициализация генератора случайных чисел
            random = new Random();
        }

        public int GenerateRandomNumber(int minValue, int maxValue)
        {
            if (minValue > maxValue)
            {
                throw new ArgumentException("Минимальное значение не может быть больше максимального.");
            }

            // Генерация случайного числа в заданном диапазоне
            return random.Next(minValue, maxValue + 1);
        }
    }
}
