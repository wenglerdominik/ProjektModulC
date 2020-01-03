using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Wifi.Auto.Data
{
    [Serializable]
    public class Cars
    {
        public List<CarBrand> CarCollection { get; set; } = new List<CarBrand>();
    }
}
