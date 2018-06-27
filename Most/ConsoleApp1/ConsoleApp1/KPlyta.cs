using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
		class KPlyta : Plyta
		{
			public KPlyta(Tlok type, String name, PlytaInterface plytkaInterface) : base(type, name, plytkaInterface)
			{
			}

			public override void Akcja()
			{
				plytkaInterface.Akcja();
			}

		}
}