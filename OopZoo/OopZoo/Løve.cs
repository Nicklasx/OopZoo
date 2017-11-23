using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopZoo
{
	class Løve : Species
	{
		private string navn;

		public Løve(string navn) : base(species)
		{
			this.navn = navn;
		}

		public new string Describe()
		{
			return "Dette dyr er en " + navn;
		}

		public string AnimalName
		{
			get { return navn; }
			set { navn = value; }
		}
	}
}
