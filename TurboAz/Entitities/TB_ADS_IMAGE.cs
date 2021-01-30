using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurboAz.Entitities
{
    public class TB_ADS_IMAGE
    {
        public int ID { get; set; }
        public int CAR_IMAGE { get; set; }
        public int ADS_ID { get; set; }
        public TB_ADS TB_ADS { get; set; }
    }
}
