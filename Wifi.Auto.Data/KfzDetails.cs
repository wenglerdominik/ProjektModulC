using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Wifi.Auto.Data
{
    [Serializable()]
    [XmlInclude(typeof(KfzKosten))]

    public class KfzDetails 
    {
        
        #region Properties

        public string Marke { get; set; }
        public string Modell { get; set; }

        public DateTime Zulassung { get; set; } = DateTime.MinValue;
        public string Farbe { get; set; }
        public string Kennzeichen { get; set; }
        public string Leistung { get; set; }
        public string Wartungsintervall { get; set; }
        public double Gesamtkosten { get; set; }


        public List<KfzDetails> Fahrzeugkosten { get; set; } = null;// new List<KfzDetails>();
        
        
        #endregion





    }
}
