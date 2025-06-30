using System;
using System.ComponentModel.DataAnnotations;

namespace DapperCoreProjectHuzurevi.Models
{
	public class IetisimMesajModel
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Ad Soyad zorunludur.")]
		public string AdSoyad { get; set; }
		[Required(ErrorMessage = "E-posta zorunludur.")]
		[EmailAddress(ErrorMessage = "Geçerli bir e-posta giriniz")]
		public string Eposta { get; set; }

		[Required(ErrorMessage = "Konu zorunludur")]
		public string Konu { get; set; }

        [Required(ErrorMessage = "Mesaj zorunludur.")]
		public string Mesaj { get; set; }

		public DateTime OlusturmaTarihi { get; set; }

	}
}

