using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniature_engine
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            int add = 0;

            if (string.IsNullOrEmpty(numbers))
                return add;

            string identifier = "//";

            string delimiter = "";

            string newLine = "\n";

            if (numbers.StartsWith(identifier))
            {
                int before = numbers.IndexOf(identifier) + identifier.Length;

                int after = numbers.IndexOf(newLine) + "".Length;

                delimiter = numbers.Substring(before, after - before);
            }

            try
            {
                string[] numbersArray = numbers.Split(new string[] { ",", identifier, delimiter, newLine }, StringSplitOptions.None);

                for (int i = 0; i < numbersArray.Length; i++)
                {
                    if (numbersArray[i] != "" && numbersArray[i].All(char.IsNumber))
                        add = add + Convert.ToInt32(numbersArray[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return add;
        }
    }
}
