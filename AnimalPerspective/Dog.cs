using System;

namespace AnimalPerspective
{
    public class Dog : Animal, IMammal
    {
        public override int NumberOfNipples => 8;
        
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
}
