using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedTestDemo.Core;
using FluentAssertions;
using Xunit;

namespace AutomatedTestDemo.Tests
{
	public class CalculatorTests
	{
		[Fact]
		public void StartsWithZero()
		{
			var calculator = new Calculator();

			calculator.Value.Should().Be(0);
		}

		[Fact]
		public void AddsValues()
		{
			var calculator = new Calculator { Value = 4 };

			calculator.Add(2);

			calculator.Value.Should().Be(6);
		}
	}
}
