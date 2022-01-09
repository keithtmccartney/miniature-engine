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

            try
            {
                add = Convert.ToInt32(numbers);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return add;
        }
    }
}
