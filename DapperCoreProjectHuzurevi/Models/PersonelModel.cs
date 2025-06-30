using System;
namespace DapperCoreProjectHuzurevi.Models
{
	public class PersonelModel
	{
        public int PersonelID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Gorev { get; set; }
        public string UzmanlikAlani { get; set; }
        public DateTime? IseBaslamaTarihi { get; set; }
    }
}

