using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3Djalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
			//triângulo, paralelogramo, trapézio.



			double a, b, c, num;
			string figura = null;
			var area = Convert.ToDouble(null);

			Console.WriteLine("Programa que calcula a área da figura geométrica escolhida!");
			Console.WriteLine("Digite o número correspondente à figura desejada: ");
			Console.WriteLine();
			Console.WriteLine("1. Triângulo");
			Console.WriteLine("2. Paralelogramo");
			Console.WriteLine("3. Trapézio");
			Console.WriteLine();
			num = double.Parse(Console.ReadLine());

			switch (num)
			{
				case 1:
					figura = ("Triângulo");
					Console.WriteLine("Digite o valor da base:");
					b = double.Parse(Console.ReadLine());
					Console.WriteLine("Digite o valor da altura:");
					a = double.Parse(Console.ReadLine());

					area = b * a / 2;
					break;

				case 2:
					figura = ("Paralelogramo");
					Console.WriteLine("Digite o valor da base:");
					b = double.Parse(Console.ReadLine());
					Console.WriteLine("Digite o valor da altura:");
					a = double.Parse(Console.ReadLine());

					area = b * a;
					break;

				case 3:
					figura = ("Trapézio retângulo");
					Console.WriteLine("Digite o valor da base maior:");
					b = double.Parse(Console.ReadLine());
					Console.WriteLine("Digite o valor da base menor:");
					c = double.Parse(Console.ReadLine());
					Console.WriteLine("Digite o valor da altura:");
					a = double.Parse(Console.ReadLine());

					area = (b + c) * a / 2;
					break;
			}


			Console.WriteLine();
			Console.WriteLine("Seu " + figura + " tem área total de: " + area + "cm².");

			Console.ReadKey();
		}
    }
}
