using FactoryApp1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp1.Model.PC
{
    class DyskDlaPC : IDrive
    {
        private string name = "Drive for PC";

        public IDrive DeliverDrive()
        {
            Console.WriteLine("Add: " + name);
            return new DyskDlaPC();
        }
    }
}
