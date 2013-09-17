using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestDemo.Core
{
	public class Calculator
	{
		public double Value { get; set; }

		public void Add(double value)
		{
			Value += value;
		}
	}
}
