using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurboAz.Entitities
{
    public class TB_ADS
    {
        public int ID { get; set; }
        public Nullable<int> Brand_ID { get; set; }
        public Nullable<int> Model_ID { get; set; }
        public Nullable<int>  Body_Type_ID { get; set; }
        public Nullable<int> Walk { get; set; }
        public Nullable<int> Color_ID { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Currency_ID { get; set; }
        public bool Credit { get; set; }
        public bool Barter { get; set; }
        public Nullable<int> Fuel_Type_ID { get; set; }
        public Nullable<int> Transmission_ID { get; set; }
        public Nullable<int> Gearbox_ID { get; set; }
        public Nullable<int> Year { get; set; }
        public string NOTE { get; set; }
        public Nullable<int> Engine_Capacity_ID { get; set; }
        public Nullable<int> Engine_Power { get; set; }
        public bool ALLOY_WHEELS { get; set; }
        public bool CENTRAL_CLOSURE { get; set; }
        public bool LEATHER_SALON { get; set; }
        public bool SEAT_VENTILATION { get; set; }
        public bool ABS { get; set; }
        public bool PARKING_RADAR { get; set; }
        public bool XENON_LAMPS { get; set; }
        public bool LUKE { get; set; }
        public bool CONDITIONERS { get; set; }
        public bool REAR_VIEW_CAMERA { get; set; }
        public bool RAIN_SENSOR { get; set; }
        public bool SEAT_HEATING { get; set; }
        public bool SIDE_CURTAINS { get; set; }
        public string NAME { get; set; }
        public Nullable<int> CITY_ID { get; set; }
        public string EMAIL { get; set; }
        public List<TB_ADS_IMAGE> TB_ADS_IMAGE { get; set; }
        public CAR_BRAND CAR_BRAND { get; set; }
        public CAR_MODEL CAR_MODEL { get; set; }
        public GENERAL_INFO GI_BanType { get; set; }
        public GENERAL_INFO GI_Color { get; set; }
        public GENERAL_INFO GI_FuelType { get; set; }
        public GENERAL_INFO GI_Transmission { get; set; }
        public GENERAL_INFO GI_Gearbox { get; set; }
        public GENERAL_INFO GI_City { get; set; }
        public GENERAL_INFO GI_Currency { get; set; }
    }
}
