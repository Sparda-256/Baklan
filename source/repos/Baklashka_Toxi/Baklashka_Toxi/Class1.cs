using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Baklashka_Toxi
    {
        public class Utilities
        {
            // Функция сложения двух чисел
            public int Add(int a, int b)
            {
                return a + b;
            }

            // Функция вычитания двух чисел
            public int Subtract(int a, int b)
            {
                return a - b;
            }

            // Функция умножения двух чисел
            public int Multiply(int a, int b)
            {
                return a * b;
            }

            // Функция деления двух чисел
            public double Divide(double a, double b)
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Деление на ноль недопустимо.");
                }
                return a / b;
            }

            // Функция конкатенации двух строк
            public string ConcatenateStrings(string str1, string str2)
            {
                return str1 + str2;
            }
        }
    }
