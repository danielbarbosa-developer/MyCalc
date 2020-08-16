using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class Values
    {
        public double FirstNumber = 0;
        public double SecondNumber = 0;
        public double Result = 0;
        public string Operator = string.Empty;

        public void SetValue(double value)
        {
            if (string.IsNullOrWhiteSpace(Operator))
                FirstNumber = value;
            else
                SecondNumber = value;
        }
    }
}
