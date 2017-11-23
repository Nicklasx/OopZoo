using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopZoo
{
	class Species : Animal
	{
		private string species;

		public Species(string species)
		{
			this.species = species;
		}

		public string Describe()
		{
			return "Dette dyr er en " + species;
		}

		public override string animal()
		{
			return Describe();
		}

		public string Animal
		{
			get { return species; }
			set { species = value; }
		}

	}
}