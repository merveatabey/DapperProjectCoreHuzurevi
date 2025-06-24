using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperCoreProjectHuzurevi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DapperCoreProjectHuzurevi.Controllers
{
    public class PersonelController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //personelleri kategoriye göre filtreleyerek al
            return View(DP.Listeleme<PersonelModel>("PersonelViewForKategori"));
        }
    }
}

