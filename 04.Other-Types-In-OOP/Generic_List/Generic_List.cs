using System;
using System.Collections.Generic;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> numbers = new GenericList<int>(10);
            numbers.AddAll(new int[] {1,2,3,0,4,5,6,7,8,9,10 });
            numbers.InsertAt(100, 105);
            Console.WriteLine("Value 105 is at key: " + numbers.Find(105));
            Console.WriteLine("The minimum is: " + numbers.Min());
            Console.WriteLine("The maximum is: " + numbers.Max());
            Console.WriteLine(numbers);
        }
    }
}
