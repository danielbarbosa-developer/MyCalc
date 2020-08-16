using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class Keyboard
    {
        public static string KeyboardEntries (string number, string lastNumber)
        {
            if (string.IsNullOrWhiteSpace(lastNumber))
            {
                return number;
            }
            else
            {
                number = lastNumber + number;
                return number;
            }
        }
    }
}
