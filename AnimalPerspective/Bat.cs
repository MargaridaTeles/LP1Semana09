using System;

namespace AnimalPerspective
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public int NumberOfWings => 2;
        public int NumberOfNipples => 2;
        
        public override string Sound()
        {
            return base.Sound() + "<Click>";
        }
    }
}
