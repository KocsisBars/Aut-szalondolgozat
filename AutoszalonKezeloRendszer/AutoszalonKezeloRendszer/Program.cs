using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoszalonKezeloRendszer
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Autosalon autosalon = new Autosalon();

			autosalon.UjJarmuHozzaadasa(new Szemelyauto("Toyota", "Corolla", 2021, 8000000, 15000, 5, 6.5, "Fehér"));
			autosalon.UjJarmuHozzaadasa(new Terepjaro("Land Rover", "Defender", 2020, 15000000, 20000, "4WD", true, 3500));
			autosalon.JarmuvekListazasa();

			autosalon.JarmuEladasa("Toyota", "Corolla");
			autosalon.JarmuvekListazasa();

			autosalon.JarmuKeresese("Land Rover", "Defender");

		}
	}
}
