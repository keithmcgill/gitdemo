using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appOne
{
	class Program
	{
		void Main(string[] args)
		{
			var result = Add(1, 2);
		}

		public int Add(int val1, int val2)
		{
			return val1 + val2;
		}

		public int Subtract(int val1, int val2)
		{
			return val1 - val2;
		}

		public int BadCode(int val1)
		{
			return val1;
		}

	}
}
