using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartnerMaintenanceApp.Models;

namespace PartnerMaintenanceApp.Controllers
{
    public class PartnerController : Controller
    {
        private IPartnerService _partnerService;

        // public PartnerController(IPartnerService partnerService)
        // {
        //     _partnerService = partnerService;
        // }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PartnerDetails()
        {
            return View();
        }

        public IActionResult PartnerSearch()
        {
            var PartnerList = new List<Partner>(){
                new Partner{PartnerType=PartnerType.Maintenance, Name="Hari", Email="srihari.venk@gmail.com", QID="qtc0454", ID=1},
                new Partner{PartnerType=PartnerType.Operations, Name="Swetha", Email="swetharamiyer@gmail.com", QID="qtc1111", ID=2}
            };
            return View(PartnerList);
        }

        public IActionResult Edit(int id)
        {
            // var PartnerList = new List<Partner>(){
            //     new Partner{PartnerType=PartnerType.Maintenance, Name="Hari", Email="srihari.venk@gmail.com", QID="qtc0454"},
            //     new Partner{PartnerType=PartnerType.Operations, Name="Swetha", Email="swetharamiyer@gmail.com", QID="qtc1111"}
            // };
            var partnerDetails = new Partner()
            {
                ID = id,
                PartnerType = PartnerType.Maintenance,
                Name = "New Partner",
                Email = "srihari.venk@gmail.com",
                QID="QTC0454 111"
            };
            return View(partnerDetails);
        }



        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
