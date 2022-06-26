using System;

namespace lab1_Pla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа, которая выводит все числа от А до В в порядке убывания или возрастания");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Введите A");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите B");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Между числами А={a} и В={b} лежат числа");
                if (a < b)
                {
                    for (int i = a + 1; i < b; i++)
                    {
                        Console.Write($"{i} ");
                    }
                }
                if (a > b)
                {
                    for (int i = a - 1; i > b; i--)
                    {
                        Console.Write($"{i} ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Нажмите 0 что бы попробовать ещё раз");
                Console.WriteLine("Нажмите * что бы выйти");
                while (flag)
                {
                    string z = Console.ReadLine();
                    if (z == "0")
                    {
                        break;
                    }
                    if (z == "*")
                    {
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("Неизвестная команда");
                    }
                }
            }

        }
    }
}
