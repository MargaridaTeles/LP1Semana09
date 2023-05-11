using System;

namespace AnimalPerspective
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public override int NumberOfWings => 2;
        public override int NumberOfNipples => 2;
        
        public override string Sound()
        {
            return base.Sound() + "ti ti ti ti ti";
        }
    }
}
