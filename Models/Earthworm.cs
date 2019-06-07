using System;

namespace interfaces
{
    public class Earthworm : IDigging
    {
        public int MaximumDepth { get; set; }

        public void Dig()
        {
            Console.WriteLine("Animal is digging");
        }
    }
}