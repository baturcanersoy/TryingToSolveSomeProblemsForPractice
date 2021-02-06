using System;

namespace FindingSpecialNumbers//I tried to find some special numbers. İf we call these numbers as x;
//((x^2)*2)-1=y^2 and y must be integer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i < 10001; i++)

            {
                int calculate = ((i*i)*2)-1;
                double squareRoot = Math.Sqrt(calculate);
                string convert = squareRoot.ToString();
                int sayi = 0;
                if (int.TryParse(convert, out sayi))
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
