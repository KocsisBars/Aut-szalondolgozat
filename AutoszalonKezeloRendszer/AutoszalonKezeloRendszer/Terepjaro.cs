using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoszalonKezeloRendszer
{
	internal class Terepjaro : Jarmu
	{
		public string Hajtas { get; set; }
		public bool OffroadKepessegek { get; set; }

		public int Vontatokepesseg { get; set; }

		public Terepjaro(string gyarto, string modell, int evjarat, int alapar, int kilometeroraAllas, string hajtas, bool offroadKepessegek, int vontatokepesseg) 
			: base(gyarto, modell, evjarat, alapar,kilometeroraAllas)
		{
			Hajtas = hajtas;
			OffroadKepessegek = offroadKepessegek;
			Vontatokepesseg = vontatokepesseg;
		}

		public void OffroadCsomegFelszerel()
		{
            if (OffroadKepessegek)
            {
				Alapar += 750000;
				OffroadKepessegek = true;
            }
        }
		public void VontatokepessegBeallitasa(int kepesseg)
		{
			Vontatokepesseg = kepesseg;
		}
	}
}
