using System;

namespace delegate_1
{
    class Program
    {
        delegate int AvarageHandler(int a, int b, int c);
        static void Main(string[] args)
        {
            AvarageCalculator();
            Console.ReadLine();
        }

        static void AvarageCalculator()
        {
            try
            {
                Console.WriteLine("Bведите три числа через ПРОБЕЛ:");
                string[] numbers = Console.ReadLine().Split(' ');

                AvarageHandler avarageHandler = (a, b, c) => { return (a + b + c) / 3; };

                Console.WriteLine("Среднее арифметическое этих чисел = " + avarageHandler(Convert.ToInt32(numbers[0]), Convert.ToInt32(numbers[1]), Convert.ToInt32(numbers[2])));
            }
            catch
            {
                Console.WriteLine("Некорректный ввод! Попроуйте ещё раз.");
                AvarageCalculator();
            }
        }
    }
}
