using System;

namespace AnimalKingdom
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public int NumberOfNipples => 4;
        public int NumberOfWings => 2;
        public override string Sound()
        {
            return base.Sound() + "Chi-chi-chi";
        }
    }
}