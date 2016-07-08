using System;
/// <summary>
/// /Name:      Mohamoud Mohamed
/// Student #:  300435435
/// Assignment: Abstract Planets
/// Version:    2.0 with notes  
/// </summary>
namespace COMP123___Abstract_Planets
{
    /// <summary>
    /// Class for main driver program
    /// </summary>
    public  class Program
    {
        /// <summary>
        /// Main Driver method
        /// </summary>
        /// <param name="args"></param>
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


      /// <summary>
      /// This method asks the user to press a key to exit
      /// </summary>
      public static void WaitForAnyKey()
      {
          Console.WriteLine("press any key to exit");
          Console.ReadKey();
      }
    }
}
