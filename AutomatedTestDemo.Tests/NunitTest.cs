using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AutomatedTestDemo.Tests
{
	[TestFixture]
	public class NunitTest
	{
		[Test]
		public void OneEqualsOne()
		{
			Assert.AreEqual(1,1);
		}
	}
}
