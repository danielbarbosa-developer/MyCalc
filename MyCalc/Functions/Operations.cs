using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
   
    public class Operations
    {
        public Values Calculate(Values values)
        {
            if (values.Operator== "+")
            {
                values.Result = values.FirstNumber + values.SecondNumber;
            }
            if (values.Operator == "-")
            {
               values.Result = values.FirstNumber - values.SecondNumber;
            }
            if (values.Operator == "*")
            {
                values.Result = values.FirstNumber * values.SecondNumber;
            }
            if (values.Operator == "/")
            {
                if(values.SecondNumber == 0)
                {
                    throw new System.DivideByZeroException();

                }
                else
                {
                    values.Result = values.FirstNumber / values.SecondNumber;
                }
               
            }
            return values;
        }
        
    }
}
