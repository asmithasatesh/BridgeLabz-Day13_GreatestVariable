using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_UnitTesting
{
   public class ExtendGenericClass<T> where T : IComparable
    {
        public T[] arrayList;
        public ExtendGenericClass(T[] arrayList)
        {
            this.arrayList = arrayList;
        }
        public T[] Sort(T[] arrayList)
        {
            Array.Sort(arrayList);
            return arrayList;
        }
        public T MaximumValueFunction( T[] arrayList)
        {
            var sortarrayval = Sort(arrayList);
            return sortarrayval[^1];
        }
        public T MaxMethod()
        {
            T maxValue = this.MaximumValueFunction(arrayList);
            return maxValue;
        }
        public void PrintGreatestValue()
        {
            var max = MaxMethod();
            Console.WriteLine("Maximum value is: {0}", max);
        }

    }
}
