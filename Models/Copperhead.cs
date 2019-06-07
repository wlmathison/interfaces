using System;

namespace interfaces
{
    public class Copperhead : IDigging, ISwimming
    {
        public int MaximumDepth { get; set; }
        public int MaximumSwimDepth { get; set; }

        public void Swim()
        {
            Console.WriteLine("Animal is now swimming");
        }

        public void Dig()
        {
            Console.WriteLine("Animal is digging");
        }
    }
}