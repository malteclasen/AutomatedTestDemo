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
		public void OneEqualsOne()
		{
			Assert.Equal(1,1);
		}

		[Fact]
		public void OneEqualsTwo()
		{
			Assert.Equal(1, 2);
		}	
	}
}
