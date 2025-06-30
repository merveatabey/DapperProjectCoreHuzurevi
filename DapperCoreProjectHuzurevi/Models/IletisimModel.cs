using System;
namespace DapperCoreProjectHuzurevi.Models
{
	public class IletisimModel
	{
        public int Id { get; set; }

        public string Baslik { get; set; }

        public string KisaAciklama { get; set; }

        public string DetayAciklama { get; set; }

        public DateTime KurulusYili { get; set; }

        public string WebSitesi { get; set; }

        public string Telefon { get; set; }

        public string Email { get; set; }

        public string Adres { get; set; }
    }
}

