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
    public class IletisimController : Controller
    {

        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new HakkimizdaViewModel();
            model.Iletisim = DP.Listeleme<IletisimModel>("GetHakkimizda").FirstOrDefault();
            return View(model);
        }



        [HttpPost]
        public IActionResult Index(HakkimizdaViewModel model)
        {
            try
            {
                if (model.IletisimMesaj == null)
                    model.IletisimMesaj = new IetisimMesajModel();

                var param = new DynamicParameters();
                model.IletisimMesaj.OlusturmaTarihi = DateTime.Now;

                param.Add("@AdSoyad", model.IletisimMesaj.AdSoyad);
                param.Add("@Eposta", model.IletisimMesaj.Eposta);
                param.Add("@Konu", model.IletisimMesaj.Konu);
                param.Add("@Mesaj", model.IletisimMesaj.Mesaj);
                param.Add("@OlusturmaTarihi", model.IletisimMesaj.OlusturmaTarihi);

                DP.ExecuteReturn("InsertIletisimMesajlari", param);

                return RedirectToAction("Home", "Index");
            }
            catch (Exception ex)
            {
                return Content("Hata: " + ex.Message); // geçici olarak ekranda hata göster
            }
        }




        public IActionResult About()
        {
          
            var model = new HakkimizdaViewModel();
            model.Iletisim = DP.Listeleme<IletisimModel>("GetHakkimizda").FirstOrDefault();
            model.ToplamYasliSayisi = DP.ExecuteScalar<int>("GetToplamYasli");
            model.PersonelSayisi = DP.ExecuteScalar<int>("GetToplamPersonel");
            model.GunlukOrtalamaZiyaretci = DP.ExecuteScalar<decimal>("GetOrtalamaZiyaretci");
            model.AylikEtkinlikSayisi = DP.ExecuteScalar<decimal>("GetAylikEtkinlik");
            model.ToplamKapasite = DP.ExecuteScalar<int>("GetToplamKapasite");
            model.ToplamSubeSayisi = DP.ExecuteScalar<int>("GetToplamSubeSayisi");
            model.Yorumlar = DP.Listeleme<YorumModel>("GetZiyaretciYorumlari").ToList();



            return View(model);
        }


        public IActionResult Istatistik()
        {

            var model = new HakkimizdaViewModel();
            model.ToplamYasliSayisi = DP.ExecuteScalar<int>("GetToplamYasli");
            model.PersonelSayisi = DP.ExecuteScalar<int>("GetToplamPersonel");
            model.GunlukOrtalamaZiyaretci = DP.ExecuteScalar<decimal>("GetOrtalamaZiyaretci");
            model.AylikEtkinlikSayisi = DP.ExecuteScalar<decimal>("GetAylikEtkinlik");
            model.ToplamKapasite = DP.ExecuteScalar<int>("GetToplamKapasite");
            model.ToplamSubeSayisi = DP.ExecuteScalar<int>("GetToplamSubeSayisi");



            return View(model);
        }


    }
}

