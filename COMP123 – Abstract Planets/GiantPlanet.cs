using System;

namespace COMP123___Abstract_Planets
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string _type;

        //public string Type { get { return this._type; } set { this._type = value; } }


        public GiantPlanet(string name, double diameter, double mass,string type) 
            : base(name, diameter, mass)
        {
            name = this.Name;

            type = this._type;
        }

        
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