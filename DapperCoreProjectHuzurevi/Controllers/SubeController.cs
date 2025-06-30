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
    public class SubeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(string subeAdi)
        {
            DynamicParameters param = new DynamicParameters();
            if (string.IsNullOrEmpty(subeAdi))
            {
                var subeler = DP.Listeleme<SubeModel>("GetSubeBySubeAdi");
                return View(subeler);

            }
            else
            {
                param.Add("@SubeAdi", subeAdi);
                var filtreliSubeler = DP.Listeleme<SubeModel>("GetSubeBySubeAdi", param).FirstOrDefault();
                return View(filtreliSubeler);

            }
        }
    }
}

