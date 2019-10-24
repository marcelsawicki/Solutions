using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverApp
{
    interface IObserwowany
    {
        void DodajObserwatora(IObserwator obserwator);
        void UsunObserwatora(IObserwator obserwator);
        void PowiadamiajObserwatorow();
    }
}
