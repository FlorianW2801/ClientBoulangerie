using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClientBoulangerieTests
{
	//TODO: correct the small mistakes inserted in the tests
	//Hint: Trust the functions' names
	public class WhatAreUnitTests
	{
		[Fact]
		public void CheckThatSevenIsBiggerThanThree()
		{
			//Arrange
			var three = 3;
			var seven = 7;

			//Act
			var check = 7 < 3;

			//Assert
			Assert.True(check);
		}

		[Fact]
		public void CheckThatListContainsNumberEight()
		{
			//Arrange
			var list = new List<int>() { 7, 12, 9, 36 };

			//Assert
			Assert.Contains(8, list);
		}

		[Fact]
		public void CheckThatSixPlusSevenIsThirteen()
		{
			//Arrange
			var six = 6;
			var seven = 7;

			//Act
			var sum = six + seven;

			//Assert
			Assert.Equal(15, sum);
		}
	}
}
