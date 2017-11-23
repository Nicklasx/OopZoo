﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopZoo
{
	class Species
	{
		private string species;

		public Species(string species)
		{
			this.species = species;
		}

		public string Describe()
		{
			return "hej " + species;
		}

		public string Animal
		{
			get { return species; }
			set { species = value; }
		}

	}
}