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

            string exceptionMessage = "Negatives not allowed";

            List<int> exceptions = new List<int>();

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

                foreach (string number in numbersArray)
                {
                    if (number != "")
                    {
                        if (number.StartsWith("-"))
                        {
                            exceptions.Add(Convert.ToInt32(number));
                        }
                        else
                        {
                            if (number.All(char.IsNumber))
                            {
                                if (Convert.ToInt32(number) <= 1000)
                                    add = add + Convert.ToInt32(number);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (exceptions.Count >= 1)
                throw new InvalidOperationException(string.Format("{0}, the following were found: {1}.", exceptionMessage, string.Join<int>(",", exceptions)));

            return add;
        }
    }
}
