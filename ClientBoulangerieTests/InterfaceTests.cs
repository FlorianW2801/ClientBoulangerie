using WhatIsAnInterface;
using Xunit;

namespace ClientBoulangerieTests
{
	public class InterfaceTests
	{
		[Fact]
		public void Check_Coucou_Implementation()
		{
			//Arrange
			var c1 = new CoucouClass();
			var c2 = new CoucouAndAddsNumbersClass();

			//Assert
			Assert.True(c1 is ICoucou);
			Assert.True(c2 is ICoucou);
		}

		[Fact]
		public void Check_AddsNumber_Implementation()
		{
			//Arrange
			var c = new CoucouAndAddsNumbersClass();

			//Assert
			Assert.True(c is IAddTwoNumbers);
		}
	}
}
