using ClientBoulangerieSpace;
using System;
using System.Collections.Generic;
using Xunit;

namespace ClientBoulangerieTests
{
	public class ClientBoulangerieTests
	{
		[Fact]
		public void GiveExactCurrency_WhenPossible()
		{
			//Arrange
			var currencies = new List<double>() { 100 };
			var client = new ClientBoulangerie(currencies);
			var amountDue = 100;

			//Act
			var result = client.PayWithCurrency(amountDue);

			//Asssert
			Assert.Equal(100, result);
		}

		[Fact]
		public void GiveSmallestBiggerCurrency()
		{
			//Arrange
			var currencies = new List<double>() { 100, 50 };
			var client = new ClientBoulangerie(currencies);
			var amountDue = 47;

			//Act
			var result = client.PayWithCurrency(amountDue);

			//Asssert
			Assert.Equal(50, result);
		}

		[Fact]
		public void RefuseToPay_WhenAmountTooBig()
		{
			//Arrange
			var currencies = new List<double>() { 100, 50 };
			var client = new ClientBoulangerie(currencies);
			var amountDue = 153;

			//Act & Assert
			Assert.Throws<Exception>(() => client.PayWithCurrency(amountDue));
		}

		[Fact]
		public void GiveSeveralCurrency_WhenNeeded()
		{
			//Arrange
			var currencies = new List<double>() { 100, 50, 20, 0.5, 0.2 };
			var client = new ClientBoulangerie(currencies);
			var amountDue = 120.1;

			//Act
			var result = client.PayWithCurrency(amountDue);

			//Asssert
			Assert.Equal(120.2, result);
		}

		[Fact]
		public void DoNotGiveCurrencyTwice()
		{
			//Arrange
			var currencies = new List<double>() { 100, 50, 20 };
			var client = new ClientBoulangerie(currencies);
			var amountDue1 = 110;
			var amountDue2 = 60;

			//Act & Assert
			var result1 = client.PayWithCurrency(amountDue1);
			Assert.Equal(120, result1);
			//Not enough money left after first payment
			Assert.Throws<Exception>(() => client.PayWithCurrency(amountDue2));
		}
	}
}
