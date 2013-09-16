using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomatedTestDemo.Tests
{
	[TestClass]
	public class MsTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			Assert.AreEqual(1,1);
		}
	}
}
