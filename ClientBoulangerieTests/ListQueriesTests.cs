using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ClientBoulangerieTests
{
	public class ListQueriesTests
	{
		[Fact]
		public void ReturnMax()
		{
			//Arrange
			var list = new List<int>() { 12, 47, 23 };

			//Act
			int result = 0; //TODO

			//Assert
			Assert.Equal(47, result);
		}

		[Fact]
		public void GetAllPositiveElements()
		{
			//Arrange
			var list = new List<int>() { 12, 47, -6, 23, 36, -3, -12 };

			//Act
			List<int> result = null; //TODO

			//Assert
			Assert.Equal(4, result.Count);
			Assert.Contains(12, result);
			Assert.Contains(23, result);
			Assert.Contains(36, result);
			Assert.Contains(47, result);
		}

		[Fact]
		public void RemoveOneElement_HavingValue57()
		{
			//Arrange
			var list = new List<int>() { 19, 57, 48, 36 };

			//Act
			//TODO

			//Assert
			Assert.Equal(3, list.Count);
			Assert.Contains(19, list);
			Assert.Contains(48, list);
			Assert.Contains(36, list);
			Assert.DoesNotContain(57, list);
		}

		[Fact]
		public void ReturnSmallestElement_BiggerThan_OrEqualTo_25()
		{
			//Arrange
			var list1 = new List<int>() { 12, 47, 23, 54 };
			var list2 = new List<int>() { 3, 54 };
			var list3 = new List<int>() { 9, 25, 36 };

			//Act
			//TODO: use the same code on the three lists to get respectively all three results
			int result1 = 0;
			int result2 = 0; 
			int result3 = 0; 

			//Assert
			Assert.Equal(47, result1);
			Assert.Equal(54, result2);
			Assert.Equal(25, result3);
		}

		[Fact]
		public void SumAllElements()
		{
			//Arrange
			var list = new List<int>() { 12, 47, 23, 56 };

			//Act
			int sum = 0; //TODO

			//Assert
			Assert.Equal(12 + 47 + 23 + 56, sum);
		}
	}
}
