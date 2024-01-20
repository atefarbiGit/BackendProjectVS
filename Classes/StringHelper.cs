using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendProjectVS.Classes
{
    public class StringHelper
    {
        public int CountDigits(string input)
        {
            int digitCount = 0;
            foreach (char character in input)
            {
                if (char.IsDigit(character))
                {
                    digitCount++;
                }
            }
            return digitCount;
        }
    }

}
