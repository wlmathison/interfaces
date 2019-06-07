using System;

namespace interfaces
{
    public class Parakeet : IFlying, IWalking
    {
        public int MaximumSpeed { get; set; }
        public void Fly()
        {
            Console.WriteLine("Animal is now flying");
        }
        public void Walk()
        {
            Console.WriteLine("Animal is now walking");
        }
    }
}