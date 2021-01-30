using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurboAz.Entitities
{
    public class GENERAL_INFO
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public int TYPE_ID { get; set; }
        public GENERAL_TYPE GENERAL_TYPE { get; set; }
        public List<TB_ADS> TA_BanType { get; set; }
        public List<TB_ADS> TA_Color { get; set; }
        public List<TB_ADS> TA_FuelType { get; set; }
        public List<TB_ADS> TA_Transmission { get; set; }
        public List<TB_ADS> TA_Gearbox { get; set; }
        public List<TB_ADS> TA_City { get; set; }
        public List<TB_ADS> TA_Currency { get; set; }
    }
}
