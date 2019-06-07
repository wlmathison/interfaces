using System;

namespace interfaces
{
    public class Betta : ISwimming
    {
        public int MaximumSwimDepth { get; set; }

        public void Swim()
        {
            Console.WriteLine("Animal is now swimming");
        }
    }
}