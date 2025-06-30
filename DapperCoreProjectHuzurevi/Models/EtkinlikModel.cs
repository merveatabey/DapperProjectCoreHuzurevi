using System;
namespace DapperCoreProjectHuzurevi.Models
{
	public class EtkinlikModel
	{
		public int EtkinlikId { get; set; }
		public string Baslik { get; set; }
		public string Aciklama { get; set; }
		public DateTime EtkinlikTarihi { get; set; }
		public int SubeId { get; set; }

	}
}

