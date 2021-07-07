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
            Console.WriteLine("Greatest number is {0} \n",obj.LargestNumber(number1,number2,number3));

            //Check greatest number among three number
            Console.WriteLine("\n****FLOAT DATATYPE****");
            float numberf1, numberf2, numberf3;
            Console.WriteLine("Enter number 1");
            numberf1 = (float)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            numberf2 = (float)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            numberf3 = (float)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Greatest number is {0} \n", obj.LargestNumberFloat(numberf1, numberf2, numberf3));

            //Check which string is greater amoung three strings
            Console.WriteLine("\n****STRING DATATYPE****");
            string string1, string2, string3;
            Console.WriteLine("Enter string 1");
            string1 = Console.ReadLine();
            Console.WriteLine("Enter string 2");
            string2 = Console.ReadLine();
            Console.WriteLine("Enter string 3");
            string3 = Console.ReadLine();
            Console.WriteLine("Greatest string is {0} \n", obj.LargestNumberString(string1,string2,string3));

            //generics Method
            GenericsClassForGreatestValue obj1 = new GenericsClassForGreatestValue();
            Console.WriteLine("****GENERICS INT DATATYPE****");
            Console.WriteLine("Greatest number is {0} \n", obj1.GenericMethodForGreatest<int>(number1, number2, number3));
            Console.WriteLine("****GENERICS FLOAT DATATYPE****");
            Console.WriteLine("Greatest number is {0} \n", obj1.GenericMethodForGreatest<float>(numberf1, numberf2, numberf3));
            Console.WriteLine("****GENERICS STRING DATATYPE****");
            Console.WriteLine("Greatest number is {0} \n", obj1.GenericMethodForGreatest<string>(string1, string2, string3));






        }
    }
}
