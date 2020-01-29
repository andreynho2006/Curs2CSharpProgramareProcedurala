using System;

namespace Curs2CSharpProgramareProcedurala
{
	public class Asignare
	{
		public static void Main(string[] args)
		{
			//////////
			// Ex.1 //
			//////////
			Console.WriteLine("EX.1");
			int a = 3;
            // a = 3;
			int b = (a = 2) * a;
            // a = 2 b = 4
			int c = b * (b = 5);
            // a = 2; b = 4; apoi b = 5; si c = 4 * 5 = 20;
			Console.WriteLine("a =" +a + ", b =" +b + ", c =" +c);
			//Ce va afisa aceasta la executie si de ce ?
			// a =2, b =5, c =20

			//////////
			// Ex.2 //
			//////////
			Console.WriteLine();
			Console.WriteLine("EX.2");
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

			//////////
			// Ex.3 //
			//////////
			Console.WriteLine();
			Console.WriteLine("EX.3");
			int z = 3;
			if (++z < 4)
                // z = 4; 4 < 4 returneaza fals si urmatorul bloc de cod din program nu se executa
				if (z++ < 4)
					Console.WriteLine(a);
				else
					Console.WriteLine(a);
			// Ce se afisa si de ce?

			//////////
			// Ex.4 //
			//////////
			Console.WriteLine();
			Console.WriteLine("EX.4");
			int suma = 0;
			for (int j = 1; j < 10; j++)
			{
				suma = suma + j;
			}
			Console.WriteLine("Suma este: " +suma);
			// Afiseaza
			// Suma este: 45

			//////////
			// Ex.5 //
			//////////
			Console.WriteLine();
			Console.WriteLine("EX.5");
			// Scrieti un program care sa returneze n!(adica n = 1 * 2 * 3 * … *n), unde n< 13 este un numar natural.
			int nFactorial = 1;
			for (int n = 2; n < 13; n++)
			{
				nFactorial *= n;
			}
			Console.WriteLine("n factorial este: " + nFactorial);
			// Afiseaza
			// n factorial este: 479001600

			//////////
			// Ex.6 //
			//////////
			Console.WriteLine();
			Console.WriteLine("EX.6");
			// Scrieti un program care sa returneze minimum a trei numere intregi , folosind instructiunea if - else.
			int primulNumar = 14;
			int alDoileaNumar = 139;
			int alTreileaNumar = 2;
            if(primulNumar < alDoileaNumar && primulNumar < alTreileaNumar)
            {
                Console.WriteLine("Primul numar " + primulNumar + " este cel mai mic dintre cele trei numere intregi.");
            }
            else if (primulNumar < alDoileaNumar && primulNumar < alTreileaNumar)
			{
				Console.WriteLine("Al doilea numar " + alDoileaNumar + " este cel mai mic dintre cele trei numere intregi.");
			}
            else
            {
				Console.WriteLine("Al treilea numar " + alTreileaNumar + " este cel mai mic dintre cele trei numere intregi.");
			}

			//////////
			// Ex.7 //
			//////////
			Console.WriteLine();
			Console.WriteLine("EX.7");
			// Determinati daca un numar este par sau impar.
			Console.WriteLine("Introduceti un numar intreg");
			int number = Console.Read();
            if(number % 2 == 0)
            {
				Console.WriteLine("Numarul introdus este par");
            }
            else
            {
				Console.WriteLine("Numarul introdus este impar");

			}

			//////////
			// Ex.8 //
			//////////
			Console.WriteLine();
			Console.WriteLine("EX.8");
			// Folosind instructiunea switch scrieti un program care sa afiseze ziua
			// saptamanii in functie de numarul acesteia.
			// De exemplu : ziua 1 este echivalenta zilei “Luni”, ziua 2 este “Marti” etc.
			int dayOfWeek = (int)DateTime.Now.DayOfWeek;
            // cast xay  of the week to an integer
			Console.WriteLine(dayOfWeek);
            switch(dayOfWeek)
            {
				case 1:
					Console.WriteLine("Day of week is: Luni");
					break;
				case 2:
					Console.WriteLine("Day of week is: Marti");
					break;
				case 3:
					Console.WriteLine("Day of week is: Miercuri");
					break;
				case 4:
					Console.WriteLine("Day of week is: Joi");
					break;
				case 5:
					Console.WriteLine("Day of week is: Vineri");
					break;
				case 6:
					Console.WriteLine("Day of week is: Sambata");
					break;
				case 7:
					Console.WriteLine("Day of week is: Duminica");
					break;
				default: break;
			}

		}
	}

}
