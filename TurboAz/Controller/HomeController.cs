using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TurboAz.Entitities;
using TurboAz.ViewModels;
namespace TurboAz.Controllers
{
    public class HomeController : Controller
    {
        TurboAzContext turboAzContext = new TurboAzContext();
        public IActionResult Index()
        {
            CarViewModel carViewModel = new CarViewModel()
            {

                CAR_BRANDS = turboAzContext.CAR_BRAND.ToList(),
                CAR_MODEL = turboAzContext.CAR_MODEL.ToList(),
                CITY = turboAzContext.GENERAL_INFO.Where(x => x.TYPE_ID == 7).ToList(),
                Currency = turboAzContext.GENERAL_INFO.Where(x => x.TYPE_ID == 3).ToList()
            };
            return (View("Index", carViewModel));

        }
        public IActionResult New()
        {

            CarViewModel carViewModel = new CarViewModel()
            {
                TB_ADS = new TB_ADS(),
                CAR_BRANDS = turboAzContext.CAR_BRAND.ToList(),
                CAR_MODEL = turboAzContext.CAR_MODEL.ToList(),
                BAN_TYPE = turboAzContext.GENERAL_INFO.Where(x => x.TYPE_ID == 1).ToList(),
                COLOR = turboAzContext.GENERAL_INFO.Where(x => x.TYPE_ID == 2).ToList(),
                FUEL_TYPE = turboAzContext.GENERAL_INFO.Where(x => x.TYPE_ID == 4).ToList(),
                TRANSMISSION = turboAzContext.GENERAL_INFO.Where(x => x.TYPE_ID == 5).ToList(),
                GEARBOX = turboAzContext.GENERAL_INFO.Where(x => x.TYPE_ID == 6).ToList(),
                CITY = turboAzContext.GENERAL_INFO.Where(x => x.TYPE_ID == 7).ToList(),
               
            };
            return (View("ADS", carViewModel));
        }
        [HttpPost]
        public IActionResult Save(TB_ADS tB_ADS)
        {
            TurboAzContext turboAzContext = new TurboAzContext();
           
            turboAzContext.TB_ADS.Add(tB_ADS);
         
            turboAzContext.SaveChanges();
            return RedirectToAction("Index");
        }
        //public IActionResult GetMarkaForBrandID(int selectedBrandID)
        //{
        //    var result = turboAzContext.CAR_MODEL.Where(x => x.BRAND_ID == selectedBrandID).ToList();
        //    return Json(result);
        //}
    }
}
