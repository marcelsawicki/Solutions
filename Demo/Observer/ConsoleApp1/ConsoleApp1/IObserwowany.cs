using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IObserwowany
    {
        void DodajObserwatora(IObserwator obserwator);
        void UsunObserwatora(IObserwator obserwator);
        void PowiadamiajObserwatorow();
    }
}
