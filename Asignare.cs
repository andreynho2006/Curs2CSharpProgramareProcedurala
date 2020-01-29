using System;

namespace Curs2CSharpProgramareProcedurala
{
	public class Asignare
	{
		public static void Main(string[] args)
		{
			int a = 3;
			int b = (a = 2) * a;
			int c = b * (b = 5);
			Console.WriteLine("a =" +a + ", b =" +b + ", c =" +c);
		}
	}

}
