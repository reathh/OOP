using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.String_Disperser
{
    class Program
    {
        static void Main(string[] args)
        {
            StringDisperser myDisperser = new StringDisperser(new string[] { "let's", "test", "some", "classes" });
            StringDisperser copyOfMyDisperser = new StringDisperser(new string[] { "let's", "test", "some", "classes" });
            StringDisperser mySecondDisperser = new StringDisperser(new string[] { "what", "should", "I", "write", "this", "time" });
            Console.WriteLine(myDisperser == copyOfMyDisperser);
            Console.WriteLine(myDisperser);

            StringDisperser cloneofMyDisperser = (StringDisperser)myDisperser.Clone();
            cloneofMyDisperser.Strings = "modified";

            Console.WriteLine(cloneofMyDisperser);
            Console.WriteLine(myDisperser);

            Console.WriteLine(myDisperser.CompareTo(mySecondDisperser));

            int count = 0;
            foreach (var ch in myDisperser)
            {
                Console.WriteLine(++count + " character: " + ch);
            }
        }
    }
}
