using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsAnException
{
	public class LittleKiddy
	{
		public void NotHappy()
		{
			Console.WriteLine("littleKiddy: I did not get my toy and I'm not happy, so I'm throwing a tantrum >:(");
			throw new Exception("Waaaaaaaaaaaaaaah!");
		}

		public void Happy()
		{
			Console.WriteLine("littleKiddy:  :DDD");
		}
	}
}
