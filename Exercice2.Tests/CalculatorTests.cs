using System;
using Xunit;

namespace Exercice2.Tests
{
	public class CalculatorTests
	{
		[Fact]
		public void Add()
		{
			// Arrange
			int first = 1, second = 2;

			// Act
			var result = Calculator.Add(first, second);

			// Assert
			Assert.Equal(3, result);
		}
	}
}
