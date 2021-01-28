using System;

namespace FindingSpecialNumbers//Karesinin 2 katinin 1 eksigi bir tamsayinin karesi olan sayilari bulmaya calıstık.
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
                    Console.WriteLine(i+"'nin karesinin 2 katinin 1 eksigi "+sayi+"'nin karesidir ve bu nedenle "+i+"özel sayidir.");
                }
            }

        }
    }
}
