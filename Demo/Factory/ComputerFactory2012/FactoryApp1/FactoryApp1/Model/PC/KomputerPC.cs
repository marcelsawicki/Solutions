using FactoryApp1.Common;
using FactoryApp1.Common.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Model.PC
{
    class KomputerPC : Computer
    {
        private readonly IComponentsFactory _fabrykaPodzespolowKomputerowych;

        public KomputerPC(IComponentsFactory fabrykaPodzespolowKomputerowych)
        {
            _fabrykaPodzespolowKomputerowych = fabrykaPodzespolowKomputerowych;
            Assembly();
        }

        public override void Assembly()
        {
            dysk = _fabrykaPodzespolowKomputerowych.ProduceDrive().DeliverDrive();
            grafika = _fabrykaPodzespolowKomputerowych.ProduceGraph().DeliverGraph();
            procesor = _fabrykaPodzespolowKomputerowych.ProduceProcessor().DeliverProcessor();
            ram = _fabrykaPodzespolowKomputerowych.ProduceRam().DeliverRam();
            chlodzenie = _fabrykaPodzespolowKomputerowych.ProduceCooler().DeliverCooler();
        }
    }
}
