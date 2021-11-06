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


		// Exercise 2 TODO 1 : Substract

		// Exercise 2 TODO 2 : Multiply

		// Exercise 2 TODO 3 : Divide

		// Exercise 2 TODO 4 : Power without Math.Pow than refactor

		// *****Exercise 3*****
		/*
		 * The business changed idea and they want the calculator to support also operations using 
		 * 3 instead of 2 operands.
		 * Adjust code and tests
		 */

		// *****Exercise 4*****
		/*
		 * The business changed idea and they want the calculator to support operations on decimals
		 * instead of int. Adjust the code and the tests cases
		 */
	}
}
