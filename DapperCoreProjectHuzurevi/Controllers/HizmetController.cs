using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperCoreProjectHuzurevi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DapperCoreProjectHuzurevi.Controllers
{
    public class HizmetController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(string baslik)
        {
            var etkinlikList = DP.Listeleme<EtkinlikModel>("GetEtkinlik");

            // Aynı başlığa sahip olanlardan sadece ilkini al
            var benzersizEtkinlikler = etkinlikList
                .GroupBy(e => e.Baslik)             //etkinlikleri başlığa göre grupla
                .Select(g => g.First())             //her gruptan ilk etkinliği al
                .ToList();

            return View(benzersizEtkinlikler);
        }
    }
}

