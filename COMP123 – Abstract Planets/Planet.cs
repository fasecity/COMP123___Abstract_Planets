using System;
using System.Runtime.InteropServices;

namespace COMP123___Abstract_Planets
{
    public abstract class Planet
    {
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private double _rotationPeriod;
        private int _ringCount;

        public double Diameter
        {
            get
            {
                return this._diameter;
            }

        }

        public double Mass
        {
            get
            {
                return this._mass;
            }

        }

        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }

        }

        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        public Planet(string name, double diameter, double mass)
        {
            _name = name;
            _diameter = diameter;
            _mass = mass;
           
            MoonCount = this._moonCount;
            

        }

        
        public override string ToString()
        {
            return "Name:   "+ Name+ ",     Diameter:  " + Diameter + ",     Mass:  " +Mass;
           
        }
    }
}
