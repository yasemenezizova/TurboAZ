using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurboAz.Entitities
{
    public class GENERAL_TYPE
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public List<GENERAL_INFO> GENERAL_INFO { get; set; }
    }
}
