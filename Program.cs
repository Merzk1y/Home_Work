//Программа для нахождения кол-ва чисел кратных двум от 0 до n-числа.

using System;
namespace Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, sum, z;
            Console.WriteLine("Введите любое целое число:");
            x = Convert.ToInt32(Console.ReadLine()); //Ввод n-го числа.
            sum = 0;
            z = 0;
            if (x > 0) //Если число положительное.
            {
                while (x > 0)
                {
                    z = x % 2; x--;
                    if (z == 0)
                    {
                        sum++; //Кол-во четных чисел.
                    }
                }

            Console.WriteLine("Кол-во чисел кратных двум:" + "\n" + sum);
            Console.ReadKey();
            }
            else //Если число отрицательное.
            {
                while (x < 0)
                {
                    z = x % 2; x++;
                    if (z == 0)
                    {
                        sum++;//Кол-во четных чисел.
                    }
                }

            Console.WriteLine("Кол-во чисел кратных двум:" + "\n" + sum);
            Console.ReadKey();
            }
            
        }
    }
}
