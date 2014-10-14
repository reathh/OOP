
namespace AsynchronousTimer
{
    using System;
    using System.Threading;

    // define a class
    public class AsyncTimer
    {
        // define fields
        private uint ticks;
        private uint interval; 
        private Action<int> method;
        
        // define a construtor
        public AsyncTimer(Action<int> method,uint ticks, uint interval)
        {
            this.ticks = ticks;
            this.interval = interval;
            this.method = method;
        }

        // define a method to run the timer
        public void Run()
        {
            while (this.ticks > 0)
            {
                Thread.Sleep((int)this.interval);               
                // check if the method is invoked
                if (this.method != null)
                {
                    this.method((int)this.ticks);
                }
   
                this.ticks--;
            }          
        }
    }
}
