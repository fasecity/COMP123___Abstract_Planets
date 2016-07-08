using System;

namespace COMP123___Abstract_Planets
{
    public  class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet= new GiantPlanet("Saturn",2000,3000,"ice");
            

            giantPlanet.ToString();
            Console.WriteLine(giantPlanet.ToString());

            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth",1000,2000,true);
            var x = terrestrialPlanet.ToString();
            Console.WriteLine(x);
            terrestrialPlanet.Habitable();

            Console.WriteLine();
            WaitForAnyKey();

        }

      public static void WaitForAnyKey()
      {
          Console.WriteLine("press any key to exit");
          Console.ReadKey();
      }
    }
}
