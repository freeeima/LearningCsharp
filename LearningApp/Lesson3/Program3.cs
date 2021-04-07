using System;

namespace LearningApp
{
	class Program3
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Įveskite tris skaičius!");
			int Pirmas = Convert.ToInt32(Console.ReadLine());
			int Antras = Convert.ToInt32(Console.ReadLine());
			int Trečias = Convert.ToInt32(Console.ReadLine());



			switch (Pirmas)
			{
				case 1:
					Console.WriteLine(Pirmas + Antras + Trečias);
					break;
				case 2:
					Console.WriteLine(Pirmas - Trečias);
					break;
				case 3:
					Console.WriteLine(Antras * Trečias);
					break;
				default:
					Console.WriteLine("Klaida");
					break;



			}
		}
	}
}
