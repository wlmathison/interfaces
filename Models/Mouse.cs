using System;

namespace interfaces
{
    public class Mouse : IWalking
    {
        public int MaximumSpeed { get; set; }
        public void Walk()
        {
            Console.WriteLine("Animal is now walking");
        }

    }
}