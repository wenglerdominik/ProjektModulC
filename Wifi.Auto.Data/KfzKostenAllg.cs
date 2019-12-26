using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Wifi.Auto.Data
{
	[Serializable()]
	public class KfzKostenAllg : KfzData
    {


		public string KostenKategorie { get; set; }
		public string KostenDatum { get; set; }
		public double KostenWert { get; set; }
		public string KostenKilom { get; set; }
		public string KostenZahlweise { get; set; }

		public string KostenBemerkung { get; set; }
			

	}
}
