using System.Collections.Generic;

namespace interfaces
{
    public class WalkingAnimals
    {
        public List<IWalking> animals { get; set; } = new List<IWalking>();
    }
}