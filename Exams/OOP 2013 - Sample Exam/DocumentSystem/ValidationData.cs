using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    public class ValidationData
    {
        public static void LessThanZero(long value,string message)
        {
            string msg = String.Format("Number of {0} can't be less than zero!",message);

            if (value < 0)
                throw new ArgumentOutOfRangeException(msg);
        }
    }
}
