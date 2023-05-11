using System;

namespace AnimalPerspective
{
    public class Bat : Animal
    {
        public override string Sound()
        {
            return base.Sound() + "ti ti ti ti ti";
        }
    }
}
