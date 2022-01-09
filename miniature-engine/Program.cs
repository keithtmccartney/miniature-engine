using System;

namespace miniature_engine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringCalculator stringCalculator = new StringCalculator();

            Console.WriteLine(stringCalculator.Add("1,2\n3"));
        }
    }
}
