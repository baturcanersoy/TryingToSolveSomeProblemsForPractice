using System;

namespace TryingToSolveSomeProblemsForPractice
{
    class Program
    {
        static void Main(string[] args)
        {
                for (int i = 0; i < 10000; i++)
                {
                    double kontrol = Math.Sqrt((i * i) * 2 - 1);

                    if (Math.Round(kontrol, 1) == kontrol)
                    {
                        Console.WriteLine(i + "  Bir Özel Sayıdır!");
                        Console.WriteLine(i + "^2*2-1 =" + ((i * i * 2) - 1) + "'dir ve " + Math.Sqrt(i * i * 2 - 1) + "nin karesidir.");
                    }
                }
            }
        }
    } 