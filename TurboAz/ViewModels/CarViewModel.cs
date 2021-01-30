using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurboAz.Entitities;

namespace TurboAz.ViewModels
{
    public class CarViewModel
    {
        public TB_ADS TB_ADS { get; set; }
        public List<CAR_BRAND> CAR_BRANDS { get; set; }
        public List<CAR_MODEL> CAR_MODEL { get; set; }
        public List<GENERAL_INFO> BAN_TYPE { get; set; }
        public List<GENERAL_INFO> COLOR { get; set; }
        public List<GENERAL_INFO> FUEL_TYPE { get; set; }
        public List<GENERAL_INFO> TRANSMISSION { get; set; }
        public List<GENERAL_INFO> GEARBOX { get; set; }
        public List<GENERAL_INFO> CITY { get; set; }
        public TB_ADS_IMAGE TB_ADS_IMAGE { get; set; }
        public List<GENERAL_INFO> Currency { get; set; }
    }
}
