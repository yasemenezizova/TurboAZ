using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurboAz.Entitities
{
    public class CAR_MODEL
    {

        public int ID { get; set; }
        public string MODEL_NAME { get; set; }
        public string MODEL_CODE { get; set; }
        public int BRAND_ID { get; set; }
        public CAR_BRAND CAR_BRAND { get; set; }
        public List<TB_ADS> TB_ADS { get; set; }
    }
}
