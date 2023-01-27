using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZAD_WEB_2b.Controllers;
using ZAD_WEB_2b.Models.Databse;
using ZAD_WEB_2b.Models.Entities;

namespace ZAD_WEB_2b.Areas.InfoSystem.Controllers
{
    [Area("InfoSystem")]
    public class InformaceController : Controller
    {
        readonly InfoDbContext _infoDbcontext;
        public InformaceController(InfoDbContext infoDbcontext)
        {
            _infoDbcontext = infoDbcontext;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Informace informace)
        {
            _infoDbcontext.Add(informace);
            _infoDbcontext.SaveChanges();


            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", String.Empty), new { area = String.Empty });
        }
    }
}
