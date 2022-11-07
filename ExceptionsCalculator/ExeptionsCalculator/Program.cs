using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Domaci_zadatak5 {
	class Program {



		//static void Calculate(int a, int b) {
		//	int c;
		//	Console.WriteLine("Unesite znak operacije");
		//	var g = Operation(Convert.ToString(Console.ReadLine()));

		//	if (g == "+") {
		//		c = a + b;
		//		Console.WriteLine("Zbir dva cela broja je: {0}", c);
		//	}
		//	else if (g == "*") {
		//		c = a * b;
		//		Console.WriteLine("Proizvod dva cela broja je: {0}", c);
		//	}
		//	else if (g == "/") {
		//		c = a / b;
		//		Console.WriteLine("Kolicnik dva cela broja je: {0}", c);
		//	}
		//	else if (g == "-") {
		//		c = a - b;
		//		Console.WriteLine("Razlika dva cela broja je: {0}", c);
		//	}
		//}

		static void Calculate(double a, double b, char g) {
			double c = 0;
			if (g == '+') {
				c = a + b;
				Console.WriteLine("Zbir dva decimalna broja je: {0}", c);
			}
			else if (g == '*') {
				c = a * b;
				Console.WriteLine("Proizvod dva decimalna broja je: {0}", c);
			}
			else if (g == '/') {
				try {
					c = a / b;
				}
				catch (DivideByZeroException e)
				{
					Console.WriteLine(e.Message);
					Console.WriteLine("Exception linija uhvacena {0} ", e.StackTrace);

				}
				catch (Exception e) {
					Console.WriteLine(e.Message);
					Console.WriteLine("Exception linija uhvacena {0} ", e.StackTrace);

				}
				//finally {

					Console.WriteLine("Kolicnik dva decimalna broja je: {0}", c);
				
			}
			else if (g == '-') {
				c = a - b;
				Console.WriteLine("Razlika dva decimalna broja je: {0}", c);
			}
			else {
				Console.WriteLine("Morate uneti *,/,- ili +!");
			}
		}
		//static DivideByZeroException Calculate(int a, double b) {
		//	double c = 0;
		//	DivideByZeroException e;
		//	if (Operation(Convert.ToString(Console.ReadLine())) == "+") {
		//		c = a + b;
		//		Console.WriteLine("Zbir celog i decimalnog broja je: {0}", c);
		//	}
		//	else if (Operation(Convert.ToString(Console.ReadLine())) == "*") {
		//		c = a * b;
		//		Console.WriteLine("Proizvod celog i decimalnog broja je: {0}", c);
		//	}
		//	else if (Operation(Convert.ToString(Console.ReadLine())) == "/") {
		//		try {
		//			c = a / b;
		//		}
		//		catch (DivideByZeroException e) {
		//			Console.WriteLine("Exception linija uhvacena {0} ", e);
		//		}
		//		finally {
		//			Console.WriteLine("Kolicnik celog i decimalnog broja je: {0}", c);
		//		}
		//	}
		//	else if (Operation(Convert.ToString(Console.ReadLine())) == "-") {
		//		c = a - b;
		//		Console.WriteLine("Razlika celog i decimalnog broja je: {0}", c);
		//	}
		//	return e;
		//}
		//static string Operation(string a) {
		//	string b = a.ToString();
		//	if (b == "+" || b == "-" || b == "*" || b == "/") {

		//		return b;
		//	}
		//	return "Morate uneti *,/,- ili +!";

		//}

		static void Main(string[] args) {
			Console.WriteLine("Unesite dva cela ili decimalna broja i znak operacije koju zelite da bude izvrsena:");
			try { Calculate(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToChar(Console.ReadLine())); }
			catch (Exception e) {

				Console.WriteLine(e.Message);
				Console.WriteLine(e.StackTrace);
				Console.WriteLine(e);
			}
			
			//Console.WriteLine("Unesite dva cela broja: ");
			//Calculate(Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine()));

			Console.ReadLine();
		}
	}
}
