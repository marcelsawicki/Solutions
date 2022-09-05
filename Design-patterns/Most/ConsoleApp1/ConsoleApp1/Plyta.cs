using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	abstract class Plyta
	{
		protected PlytaInterface plytkaInterface;
		protected Tlok type;
		protected String name;


		public Plyta(Tlok type, String name, PlytaInterface plytkaImp)
		{
			this.type = type;
			this.name = name;
			this.plytkaInterface = plytkaImp;
		}

		public String Get()
		{
			return name + " " + type;
		}

		public void Set(String s, Tlok type)
		{
			this.name = s;
			this.type = type;
		}


		public abstract void Akcja();
	}
}
