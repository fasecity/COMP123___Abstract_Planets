using System;

namespace COMP123___Abstract_Planets
{
    /// <summary>
    /// Ths is the TerrestrialPlanet class that derives from Planet.cs also
    /// implements IHasMoons,IHabitable Interfaces
    /// </summary>
    public class TerrestrialPlanet : Planet, IHabitable, IHasMoons
    {
        //private instance variable
        private bool _oxegen;

        /// <summary>
        /// This is the constructor for TerrestrialPlanet
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="Oxygen"></param>
        public TerrestrialPlanet(string name, double diameter, double mass,bool Oxygen) 
            : base(name, diameter, mass)
        {
            _oxegen = Oxygen;
        }

        /// <summary>
        ///This method checks to see if the planet has moons
        /// </summary>
        /// <returns>bool</returns>
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
        /// <summary>
        ///This method checks to see if the planet has oxegeb
        /// </summary>
        /// <returns>bool</returns>
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