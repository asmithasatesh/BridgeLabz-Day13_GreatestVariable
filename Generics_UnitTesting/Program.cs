using System;

namespace Generics_UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            GreatestNum obj = new GreatestNum();
            //Check greatest number among three number
            Console.WriteLine("****INT DATATYPE****");
            int number1, number2, number3;
            Console.WriteLine("Enter number 1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Greatest number is {0} ",obj.LargestNumber(number1,number2,number3));

            //Check greatest number among three number
            Console.WriteLine("****FLOAT DATATYPE****");
            float numberf1, numberf2, numberf3;
            Console.WriteLine("Enter number 1");
            numberf1 = (float)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            numberf2 = (float)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            numberf3 = (float)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Greatest number is {0} ", obj.LargestNumberFloat(numberf1, numberf2, numberf3));

        }
    }
}
