using System;

namespace HomeWork3Kataev
{
    class Complex
    {
        public int a, b;

        public Complex(int re, int im)
        {
            a = re;
            b = im;

        }

        public static Complex Otr(Complex x, Complex y) //Вычитание комплекс чисел
        {
            return new Complex(re: x.a - y.a, im: x.b - y.b);

        }

        public static Complex Proiz(Complex x, Complex y) //Произведение
        {
            return new Complex(re: (x.a * y.a) - (x.b * y.b), im: (x.b * y.a) + (x.a * y.b));
        }

          public override string ToString()
        {
             if (b != 0)
            {if (b<0)
                    return $"{a} - {-b}i"; 
            else
                    return $"{a} + {b}i";
            }
             else
                return $"{a}";
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex z1 = new Complex(re: 1, im: 2);
            Console.WriteLine($"Комплексное число 1 =" + z1);
            Complex z2 = new Complex(re: 4, im: 5);
            Console.WriteLine($"Комплексное число 2 =" + z2);

            Complex z3 = Complex.Otr(z1, z2);
            Complex z4 = Complex.Proiz(z1, z2);
            Console.WriteLine($"Разность комплексных чисел 1 и 2 =" + z3);
            Console.WriteLine($"Произведение комплексных чисел 1 и 2 =" + z4);
        }
    }
}
