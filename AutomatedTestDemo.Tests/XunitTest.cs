using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AutomatedTestDemo.Tests
{
	public class XunitTest
	{
		[Fact]
		public void TestMethod1()
		{
			Assert.Equal(1,1);
		}
	}
}
