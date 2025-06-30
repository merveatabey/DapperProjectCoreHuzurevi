using System;
namespace DapperCoreProjectHuzurevi.Models
{
	public class HakkimizdaViewModel
	{
        public IletisimModel Iletisim { get; set; }

        // İstatistiksel Veriler
        public int ToplamYasliSayisi { get; set; }
        public int PersonelSayisi { get; set; }
        public decimal GunlukOrtalamaZiyaretci { get; set; }
        public decimal AylikEtkinlikSayisi { get; set; }
        public int ToplamKapasite { get; set; }
        public int ToplamSubeSayisi { get; set; }
        public List<YorumModel> Yorumlar { get; set; }
        public IetisimMesajModel IletisimMesaj { get; set; } = new IetisimMesajModel();

    }
}

