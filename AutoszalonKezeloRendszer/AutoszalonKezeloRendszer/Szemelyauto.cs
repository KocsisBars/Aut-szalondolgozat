using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoszalonKezeloRendszer
{
	internal class Szemelyauto : Jarmu
	{
		public int UlesekSzama { get; set; }
		public double Fogyasztas { get; set; }

		public string Szin { get; set; }

		public Szemelyauto(string gyarto, string modell, int evjarat, int alapar, int kilometeroraAllas, int ulesekszama, double fogyasztas, string szin) 
			: base(gyarto, modell, evjarat, alapar, kilometeroraAllas)
		{
			UlesekSzama = ulesekszama;
			Fogyasztas = fogyasztas;
			Szin = szin;
		}

		public void KenyelmiExtraBeszerzese(string extra)
		{
            if (extra == "TV")
            {
				Alapar += 75000;
            }
            else if (extra == "Pohártartó")
            {
				Alapar += 5000;
            }
        }

		public void SzínFrissitése(string ujSzin) 
		{
			Szin = ujSzin;
		}
	}
}
