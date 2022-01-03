using System.Collections.Generic;

namespace ClientBoulangerieSpace
{
	public class ClientBoulangerie : IPayWithCurrency
	{
		private List<double> _initialCurrency;

		public ClientBoulangerie(List<double> initialCurrency)
		{
			_initialCurrency = initialCurrency;
		}

		public double PayWithCurrency(double amountDue)
		{
			//TODO
			return -1;
		}
	}
}
