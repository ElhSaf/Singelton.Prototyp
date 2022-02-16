using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns

{
    class Singlton
    {
        public static int counter = 0;
        private static Singlton _Instance;  //sparar objektet som Siglton innehåller, lite som name = Elham, men här har den objektet.
        private string _name;

        //Man kan ha Public eller private nedan står private exempel
        private Singlton(string name)
        {
            _name = name;
            counter++;
        }
        public static Singlton GetInstance(string name)
        {   //detta kollar bara om objekt finns eller ej om man ändrar objekt namnet i MAin så kommer endå visa första namnet som är Jim.
            if (_Instance == null)
            {
                _Instance = new Singlton(name);   // flr att se om Instance är om eller ej om den är tom då lägg till.
            }
            
            return _Instance;   // när den är utanför så kommer den visa om det redan finns eller om det inte finns kommer den lägga till o sen visa.
        }
        public void PrintInfo()
        {
            Console.WriteLine("NAme: " + _name);
            Console.WriteLine("Counter: " + counter);
        }
    }
}
