using System;
class Program
        {
            static void Main(string[] args)
            {
                int number = int.Parse(Console.ReadLine());

                Console.Write("ta liczba rozkłada się na --> " + number + ": ");

                for (int i = 2; i <= number; i++)
                {
                    while (number % i == 0)
                    {
                        Console.Write(i + " ");
                        number /= i;
                    }
                }

                Console.ReadLine();
            }
        }

