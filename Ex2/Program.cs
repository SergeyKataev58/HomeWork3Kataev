using System;

namespace Ex2Kataev  //Задача сумма положительных нечетных числе введенных с клавиатуры
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num = 0;
            Console.WriteLine("Введите числа");
            num = Sum(ref sum);
            Console.WriteLine("Сумма положительных нечетных чисел= " + sum);
        }

        private static int Sum(ref int sum)
        {
            int num;
            string a;
            do
            {
                a = Console.ReadLine();
               bool result = int.TryParse(a, out num);
                if (result)
                {

                    if (num > 0 && num % 2 == 1)
                        sum += num;
                }
                else Console.WriteLine("Число не корректно");
                           
            } while (num != 0);
            return num;
               
        }
    }
}