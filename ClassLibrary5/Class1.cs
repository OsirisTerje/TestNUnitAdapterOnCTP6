using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary5
{
	public class Class1 : IClass1
	{
		public int Answer => 42; 
	}

	public class Class2 : Class1
	{
		public new int Answer { get; set; }
	}
}
