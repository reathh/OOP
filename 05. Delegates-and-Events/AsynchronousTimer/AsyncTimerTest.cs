
namespace AsynchronousTimer
{
    using System;

    // test the program
    public class AsyncTimerTest
    {
        static void Main()
        {
            // define two methods using lambda expressions to pass them to the AsyncTimer construtor
            Action<int> firstTest = (num) => Console.WriteLine("I am the first test.Timer:{0}",num);
            Action<int> secondTest = (num) => Console.WriteLine("I am the second test.Timer:{0}",num);
            
            // create two Asynchtimers
            var firstTimer = new AsyncTimer(firstTest, 10, 500);
            var secondTimer = new AsyncTimer(secondTest, 5, 1000);

            //run the tests
            firstTimer.Run();
            secondTimer.Run();
        }
    }
}
