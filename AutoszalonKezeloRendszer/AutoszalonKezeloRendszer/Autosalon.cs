using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoszalonKezeloRendszer
{
	internal class Autosalon
	{
		public List<Jarmu> Jarmuvek { get; set; }

		public Autosalon()
		{
			Jarmuvek = new List<Jarmu>();
		}

		public void UjJarmuHozzaadasa(Jarmu jarmu)
		{
			Jarmuvek.Add(jarmu);
            Console.WriteLine($"A {jarmu.Gyarto} gyártmányú, {jarmu.Modell} modellű autó hozzáadva.");
        }

		public bool JarmuEladasa(string gyarto, string modell)
		{
			var jarmu = Jarmuvek.FirstOrDefault(j => j.Gyarto == gyarto && j.Modell == modell);
            if (jarmu != null)
            {
				Jarmuvek.Remove(jarmu);
				return true;
            }
			return false;
        }

		public Jarmu JarmuKeresese(string gyarto, string modell)
		{
			return Jarmuvek.FirstOrDefault(j => j.Gyarto == gyarto && j.Modell == modell);

		}

		public void JarmuvekListazasa()
		{
            foreach (var jarmu in Jarmuvek)
            {
				jarmu.JarmuInfo();
            }
        }
	}
}
