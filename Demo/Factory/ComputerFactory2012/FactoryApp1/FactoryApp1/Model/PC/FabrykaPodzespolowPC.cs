using FactoryApp1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Model.PC
{
    class FabrykaPodzespolowPC : IComponentsFactory
    {
        public IDrive ProduceDrive()
        {
            return new DyskDlaPC();
        }

        public IGraph ProduceGraph()
        {
            return new GrafikaDlaPC();
        }

        public IRam ProduceRam()
        {
            return new DDR2();
        }

        public IProcessor ProduceProcessor()
        {
            return new ProcesorDlaPC();
        }

        public ICooler ProduceCooler()
        {
            return new ChlodzenieDlaPC();
        }
    }
}
