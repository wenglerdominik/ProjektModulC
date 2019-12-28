using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.Auto.Data
{
	public class KfzKostenTank : KfzData
	{
		public double Tankbetrag { get; set; }
		public string TankDatum { get; set; }
		public int TankKilometer { get; set; }
		public int TankMenge { get; set; }
        public int GefahreneKm { get; set; }
        public double Verbrauch { get; set; }

    }
}
