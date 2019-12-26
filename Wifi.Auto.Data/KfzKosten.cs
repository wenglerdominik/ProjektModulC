using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Wifi.Auto.Data
{
    [Serializable()]
    public class KfzKosten : KfzDetails
    {


        public string KostenKategorie { get; set; }
        public DateTime KostenDatum { get; set; }
        public double KostenWert { get; set; }
        public string KostenKilom { get; set; }
        public string KostenZahlweise { get; set; }

        public string KostenBemerkung { get; set; }

        public double AllgemeinGesamtkosten { get; set; }

        public double Tankbetrag { get; set; }
        public DateTime TankDatum { get; set; }
        public int TankKilometer { get; set; }
        public int TankMenge { get; set; }
        public double TankGesamtKosten { get; set; }

    }
}
