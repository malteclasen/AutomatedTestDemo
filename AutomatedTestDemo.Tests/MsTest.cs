using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomatedTestDemo.Tests
{
	[TestClass]
	public class MsTest
	{
		[TestMethod]
		public void OneEqualsOne()
		{
			Assert.AreEqual(1,1);
		}

		[TestMethod]
		public void Addition()
		{
			var a = 1;
			var b = 2;

			var result = a + b;
			
			Assert.AreEqual(result, 3);
		}

		[TestMethod]
		public void AdditionFluent()
		{
			var a = 1;
			var b = 2;

			var result = a + b;

			result.Should().Be(3);
		}
	
	}
}
