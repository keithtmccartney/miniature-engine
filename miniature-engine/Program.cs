using System;

namespace miniature_engine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringCalculator stringCalculator = new StringCalculator();

            Console.WriteLine(stringCalculator.Add("//+\n1+2+3+4+5+999+1000+1001+9+10"));
        }
    }
}
