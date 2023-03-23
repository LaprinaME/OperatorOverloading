using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main()
        {
            // Создаем два рациональных числа
            RationalNumber r1 = new RationalNumber(2, 3);
            RationalNumber r2 = new RationalNumber(3, 4);

            // Примеры использования перегруженных операторов
            RationalNumber sum = r1 + r2;
            RationalNumber difference = r1 - r2;
            RationalNumber product = r1 * r2;
            RationalNumber quotient = r1 / r2;
            bool isEqual = r1 == r2;
            bool isNotEqual = r1 != r2;
            bool isGreater = r1 > r2;
            bool isLess = r1 < r2;

            // Вывод результатов
            Console.WriteLine("r1 = " + r1);
            Console.WriteLine("r2 = " + r2);
            Console.WriteLine("r1 + r2 = " + sum);
            Console.WriteLine("r1 - r2 = " + difference);
            Console.WriteLine("r1 * r2 = " + product);
            Console.WriteLine("r1 / r2 = " + quotient);
            Console.WriteLine("r1 == r2: " + isEqual);
            Console.WriteLine("r1 != r2: " + isNotEqual);
            Console.WriteLine("r1 > r2: " + isGreater);
            Console.WriteLine("r1 < r2: " + isLess);
            //Перевод строки
            Console.ReadLine();
        }
    }
}
