using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DapperCoreProjectHuzurevi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DapperCoreProjectHuzurevi.Controllers
{
    public class PersonelController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(string gorev = null)
        {
            DynamicParameters param = new DynamicParameters();

            if (string.IsNullOrEmpty(gorev))
            {
                @ViewBag.Gorev = null;
                var tumPersoneller = DP.Listeleme<PersonelModel>("GetPersonellerByGorev");
                return View(tumPersoneller);
            }
            else
            {
                param.Add("@Gorev", gorev);
                ViewBag.Gorev = gorev;
                var filtreliPersoneller = DP.Listeleme<PersonelModel>("GetPersonellerByGorev", param);
                return View(filtreliPersoneller);

            }
        }
    }
}

