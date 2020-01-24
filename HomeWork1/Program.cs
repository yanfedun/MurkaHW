using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int a = 3 * 11;
                Console.WriteLine(a); //Операция

                Console.WriteLine(Math.PI); //Пи
                Console.WriteLine("6см"); //Вывод
            }
            {
                double t, v, x, z;

                Console.WriteLine("Введите t:");
                t = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите v:");
                v = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите x:");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите z:");
                z = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"400*t={t * 400}, 1642*v={1642 * v}, x*15={x * 15}, x*z={x * z}");
            } //Операции при введении с клавы 
            {
                double first, second;
                Console.WriteLine("Введите первое число:");
                first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                second = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Среднее арифметическое:{first * second / 2}");
            } //Среднее арифметическое
            {
                double sqrt;
                Console.WriteLine("Введите число которое нужно возвести в квадрат:");
                sqrt = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Квадратом числа {sqrt} является {Math.Pow(sqrt, 2)}");
            }//Корень
            {
                Console.WriteLine("Введите число от 100 до 100000000:  ");
                int var = Convert.ToInt16(Console.ReadLine());

                if (var >= 100 && var <= 100000000)
                {
                    string str = var.ToString();
                    int chot = 0;
                    int nechot = 0;
                    int Length = str.Length;

                    foreach (char ch in str)
                    {
                        int i = (int)ch;
                        if (i % 2 == 0)
                        {
                            chot++;
                        }
                        else if (i % 2 != 0)
                        {
                            nechot++;
                        }
                    }

                    int procChot = 100 * chot / Length;
                    int procNechot = 100 * nechot / Length;

                    Console.WriteLine("Четных чисел {0}, не четных {1}", chot, nechot);
                    Console.WriteLine("Четных чисел {0}%, не четных {1}%", procChot, procNechot);
                    Console.WriteLine("Нажмите Enter...");
                    Console.Read();
                }

                else
                {
                    Console.WriteLine("Число введенно не правильно");
                    Console.WriteLine("Нажмите Enter...");
                    Console.Read();
                }
            }


            Console.ReadLine();
        }
        
    }
}
