using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Wifi.Auto.Data
{
    [Serializable]
    public class CarBrand
    {
        public string Brand { get; set; } = null;
        public List<string> Models { get; set; } = new List<string>();
    }
}
