using System;

namespace Curs2CSharpProgramareProcedurala
{
	public class Asignare
	{
		public static void Main(string[] args)
		{
            // Ex.1

			int a = 3;
            // a = 3;
			int b = (a = 2) * a;
            // a = 2 b = 4
			int c = b * (b = 5);
            // a = 2; b = 4; apoi b = 5; si c = 4 * 5 = 20;
			Console.WriteLine("a =" +a + ", b =" +b + ", c =" +c);
			//Ce va afisa aceasta la executie si de ce ?
			// a =2, b =5, c =20


            // Ex. 2

            double d = 2.95;
			// declarare variabila de tip double;
			int i = 4;
			// declarare variabila de tip integer
			Console.WriteLine(++d > i ? d : i);
			// Ce se poate spune despre acesta?
			// ++d returneaza 3.95; 3.95 < 4 => returneaza valoarea variabilei i adica 4;
			// (daca ++d ar fi mai mare decat i ( i = 4 ) atunci ar returna valoarea variabilei d 
			// Se compileaza?
			// Da;
			// Ce afiseaza?
			// Afiseaza 4

			// Ex. 3

			int z = 3;
			if (++z < 4)
                // z = 4; 4 < 4 returneaza fals si urmatorul bloc de cod din program nu se executa
				if (z++ < 4)
					Console.WriteLine(a);
				else
					Console.WriteLine(a);
			// Ce se afisa si de ce?

			// Ex. 4

			int suma = 0;
			for (int j = 1; j < 10; j++)
			{
				suma = suma + j;
			}
			Console.WriteLine("Suma este: " +suma);

		}
	}

}
