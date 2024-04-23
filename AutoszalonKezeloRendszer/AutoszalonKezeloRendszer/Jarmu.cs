using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoszalonKezeloRendszer
{
	internal class Jarmu
	{
		public string Gyarto { get; set; }
		public string Modell { get; set; }
		public int Evjarat { get; set; }
		public int Alapar { get; set; }

		public int KilometeroraAllas { get; set; }

		public Jarmu(string gyarto, string modell, int evjarat, int alapar, int kilometeroraAllas)
		{
			Gyarto = gyarto;
			Modell = modell;
			Evjarat = evjarat;
			Alapar = alapar;
			KilometeroraAllas = kilometeroraAllas;
		}

		public void JarmuInfo()
		{
            Console.WriteLine($"A jármű adatai {Gyarto}, {Modell}, {Evjarat}");
        }

		public virtual int  ArKalkulacio()
		{
			return Alapar - ((DateTime.Now.Year - Evjarat) * 100000);
		}

		public void KmAllasFrissites(int km)
		{
			KilometeroraAllas += km;
        }



	}
}
