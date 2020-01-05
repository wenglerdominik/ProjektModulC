using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Wifi.Auto.Data
{
	[Serializable()]
	[XmlInclude(typeof(KfzKostenAllg))]
	[XmlInclude(typeof(KfzKostenTank))]

	public class KfzData
	{

		#region Properties

		public string Marke { get; set; }
		public string Modell { get; set; }

        public string Zulassung { get; set; } = null;
		public string Farbe { get; set; }
		public string Kennzeichen { get; set; }
		public string Leistung { get; set; }
		public string Wartungsintervall { get; set; }
		public double Gesamtkosten { get; set; }
        public double Monatskosten { get; set; }
		public List<string> ImagePath { get; set; } = null;

        public List<KfzData> Fahrzeugkosten { get; set; } = null;
        public List<KfzData> KostDeleted { get; set; } = null;


		#endregion





	}
}
