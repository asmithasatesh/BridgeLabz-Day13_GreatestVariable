using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_UnitTesting
{
    public class GenericClassModifiedwhere<T> where T : IComparable
    {

        public T number1, number2, number3;
        //Parameterised constructor
        public GenericClassModifiedwhere(T number1, T number2, T number3)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.number3 = number3;
        }
        public static T GenericMethodForGreatest(T number1, T number2, T number3)
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
        //This function calls MaxVal and return it to main method
        public T FindMaxNumber()
        {
            T max = GenericClassModifiedwhere<T>.GenericMethodForGreatest(this.number1, this.number2, this.number3);
            return max;
        }
    }
}
