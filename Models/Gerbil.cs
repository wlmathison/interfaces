using System;

namespace interfaces
{
    public class Gerbil : IWalking
    {
        public int MaximumSpeed { get; set; }
        public void Walk()
        {
            Console.WriteLine("Animal is now walking");
        }

    }
}