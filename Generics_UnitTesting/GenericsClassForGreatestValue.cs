using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_UnitTesting
{
    public class GenericsClassForGreatestValue
    {
        public T GenericMethodForGreatest<T>(T number1,T number2,T number3) where T: IComparable
        {
            if ((number1.CompareTo(number2) > 0) && (number1.CompareTo(number3) > 0))
            {
                return number1;
            }
            else if ((number2.CompareTo(number1) > 0) && (number2.CompareTo(number3) > 0))
            {
                return number2;
            }
            else if ((number3.CompareTo(number2) > 0) && (number3.CompareTo(number1) > 0))
            {
                return number3;
            }
            else return default;
        }
    }
}
