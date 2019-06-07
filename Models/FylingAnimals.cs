using System.Collections.Generic;

namespace interfaces
{
    public class FlyingAnimals
    {
        public List<IFlying> animals { get; set; } = new List<IFlying>();
    }
}