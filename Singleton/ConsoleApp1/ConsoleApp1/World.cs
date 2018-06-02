using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class World
    {
        private static World instancja=null;
        
        // konstruktor musi byc provate aby uniemozliwic utworzenie obiektu za pomaca
        // operatora new
        private World()
        {
        }

        public World GetInstance()
        {
            return instancja;
        }
        public static World Utworz()
        {
            if (instancja == null)
            {
                Console.WriteLine("Obiekt nie istnieje.");
                instancja = new World();
                return instancja;
                
            }
            Console.WriteLine("Obiekt juz istnieje!");
            return instancja;
        }
    }
}
