using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica4
{
	class Program
	{
		static void Main(string[] args)
		{
			int calificacion1, calificacion2, calificacion3, calificacion4, calificacion5;
			int totalcalificacion, promedio;
			Console.WriteLine("Primera Calificacion");
			calificacion1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Segunda Calificacion");
			calificacion2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Tercera Calificacion");
			calificacion3 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Cuarta Calificacion");
			calificacion4 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Quinta Calificacion");
			calificacion5 = Convert.ToInt32(Console.ReadLine());

			totalcalificacion = calificacion1 + calificacion2 + calificacion3 + calificacion4 + calificacion5;

			promedio = totalcalificacion / 5;
			Console.WriteLine("El total de calificacion es {0}", totalcalificacion);
			Console.WriteLine("El toltal de las calificaciones es {0}", promedio);
			Console.ReadKey();

		}
	}
}
