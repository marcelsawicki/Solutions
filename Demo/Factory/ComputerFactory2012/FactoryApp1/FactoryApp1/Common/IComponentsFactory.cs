using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Common
{
    interface IComponentsFactory
    {
        IDrive ProduceDrive();
        IGraph ProduceGraph();
        IRam ProduceRam();
        IProcessor ProduceProcessor();
        ICooler ProduceCooler();
    }
}
