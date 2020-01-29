using System;

namespace Curs2CSharpProgramareProcedurala
{
	public class Asignare
	{
		public static void Main(string[] args)
		{
			int a = 3;
            // a = 3;
			int b = (a = 2) * a;
            // a = 2 b = 4
			int c = b * (b = 5);
            // a = 2; b = 4; apoi b = 5; si c = 4 * 5 = 20;
			Console.WriteLine("a =" +a + ", b =" +b + ", c =" +c);
			//Ce va afisa aceasta la executie si de ce ?
			// a =2, b =5, c =20
		}
	}

}
