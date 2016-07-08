using System;

namespace COMP123___Abstract_Planets
{
    public class TerrestrialPlanet : Planet, IHabitable, IHasMoons
    {
        private bool _oxegen;
        public TerrestrialPlanet(string name, double diameter, double mass,bool Oxygen) : base(name, diameter, mass)
        {
            _oxegen = Oxygen;
        }

        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                Console.WriteLine("This planet has moons");
                return true;
            }
            else
            {
                Console.WriteLine("This planet has no moons");
                return false;
            }
        }

        public bool Habitable()
        {
            if (_oxegen == true)
            {
                Console.WriteLine("this planet is habitable");
                return true;
            }
            else
            {
                Console.WriteLine("this planet is not habitable");
                return false;

            }
        }
    }
}