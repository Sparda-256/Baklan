namespace Baklashka_Toxi
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект класса Utilities из библиотеки
            Utilities utils = new Utilities();

            // Примеры вызова функций
            int sum = utils.Add(5, 3);
            Console.WriteLine($"Сумма: {sum}");

            int difference = utils.Subtract(10, 4);
            Console.WriteLine($"Разность: {difference}");

            int product = utils.Multiply(7, 6);
            Console.WriteLine($"Произведение: {product}");

            try
            {
                double quotient = utils.Divide(20, 4);
                Console.WriteLine($"Частное: {quotient}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            string concatenated = utils.ConcatenateStrings("Hello, ", "World!");
            Console.WriteLine($"Конкатенация строк: {concatenated}");
        }
    }
}
