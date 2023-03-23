using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading
{
    class RationalNumber
    {
        /*Класс "RationalNumber" представляет собой рациональное число, которое имеет числитель и знаменатель. 
         * Он определяет конструктор, который принимает числитель и знаменатель.
         * Перегружает операторы сложения, вычитания, умножения, деления, а также операторы сравнения.*/
        private int numerator; // числитель
        private int denominator; // знаменатель

        // конструктор класса, принимающий числитель и знаменатель
        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен нулю!");
            }

            // делаем числитель и знаменатель неотрицательными

            /*В конструкторе класса "RationalNumber" происходит проверка, что знаменатель не равен нулю. 
            Потому что деление на ноль не имеет смысла и приведет к ошибке. 
            Если знаменатель равен нулю, то генерируется исключение. 
            Выбрасывается исключение ArgumentException с сообщением об ошибке.*/

            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
            // находим наибольший общий делитель и делим числитель и знаменатель на него
            int gcd = Gcd(numerator, denominator);
            // Ключевое слово "this" ссылается на текущий экземпляр класса
            this.numerator = numerator / gcd;
            this.denominator = denominator / gcd;
        }
        // метод для нахождения наибольшего общего делителя
        private int Gcd(int a, int b)
        {
            //Возвращает абсолютное значение числа одинарной точности с плавающей запятой
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        //Для объявления оператора используется ключевое слово "operator"
        /*В языке C# допускается определять назначение опе­ратора по отношению к создаваемому классу. 
         * Этот процесс называется перегрузкой операторов. */

        // перегрузка оператора сложения

        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            int numerator = a.numerator * b.denominator + b.numerator * a.denominator;
            int denominator = a.denominator * b.denominator;
            return new RationalNumber(numerator, denominator);
            //Создаём новый объект типа RationalNumber, передавая в его конструктор значения numerator и denominator, вычисленные в предыдущих строках кода
        }

        // перегрузка оператора вычитания
        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            int numerator = a.numerator * b.denominator - b.numerator * a.denominator;
            int denominator = a.denominator * b.denominator;
            return new RationalNumber(numerator, denominator);
        }

        // перегрузка оператора умножения
        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            int numerator = a.numerator * b.numerator;
            int denominator = a.denominator * b.denominator;
            return new RationalNumber(numerator, denominator);
        }
        // перегрузка оператора деления
        public static RationalNumber operator /(RationalNumber a, RationalNumber b)
        {
            int numerator = a.numerator * b.denominator;
            int denominator = a.denominator * b.numerator;
            return new RationalNumber(numerator, denominator);
        }

        // перегрузка оператора равенства
        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            return a.numerator == b.numerator && a.denominator == b.denominator;
        }
        // перегрузка оператора неравенства
        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            return !(a == b);
        }
        // перегрузка оператора больше
        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            return a.numerator * b.denominator > b.numerator * a.denominator;
        }

        // перегрузка оператора меньше
        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            return a.numerator * b.denominator < b.numerator * a.denominator;
        }
        // перегрузка оператора больше или равно
        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            return a.numerator * b.denominator >= b.numerator * a.denominator;
        }
        // перегрузка оператора меньше или равно
        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            return a.numerator * b.denominator <= b.numerator * a.denominator;
        }
        // перегрузка оператора преобразования в строку
        public override string ToString()
        {
            return numerator + "/" + denominator;
        }
    }
}