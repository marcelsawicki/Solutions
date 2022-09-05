using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Common.Abstract
{
    abstract class Computer
    {
        protected IDrive dysk;
        protected IGraph grafika;
        protected IRam ram;
        protected IProcessor procesor;
        protected ICooler chlodzenie;

        public abstract void Assembly();

        public void InstallSoftware()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Installing software...");
        }

        public void Packing()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Equipment packing...");
        }

        public void Sell()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Equipment selling...");
        }
    }
}
