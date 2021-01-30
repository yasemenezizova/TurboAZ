using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TurboAz.Entitities
{
    public class CAR_BRAND
    {
       
        public int ID { get; set; }
        public string BRAND_CODE { get; set; }
        public string BRAND_NAME { get; set; }
        public List<CAR_MODEL> CAR_MODEL { get; set; }
        public List<TB_ADS> TB_ADS { get; set; }
    }
}
