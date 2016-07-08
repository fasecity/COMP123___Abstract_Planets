using System;

namespace COMP123___Abstract_Planets
{
    /// <summary>
    /// Ths is the GiantPlanet class that derives from Planet.cs also
    /// implements IHasMoons,IHasRings Interfaces
    /// </summary>
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        //Private instance varable
        private string _type;

        /// <summary>
        /// This is the contructor for GaiantPlanet
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string name, double diameter, double mass,string type) 
            : base(name, diameter, mass)
        {
            name = this.Name;

            type = this._type;
        }

        /// <summary>
        /// This method checks to see if the planet has moons
        /// </summary>
        /// <returns>bool</returns>
        public bool HasMoons()
        {
            if (MoonCount>0)
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
        /// this method checks if Giantplanet has rings
        /// </summary>
        /// <returns>bool</returns>
        public bool HasRings()
        {
            if (RingCount > 0)
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
       
    }
}