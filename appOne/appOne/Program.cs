using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appOne
{
	class Program
	{
		static void Main(string[] args)
		{
			var result = Add(Convert.ToInt32(args[1]), Convert.ToInt32(args[2]));
		}

		public static int Add(int val1, int val2)
		{
			return val1 + val2;
		}

		public static int Subtract(int val1, int val2)
		{
			return val1 - val2;
		}

	}
}
