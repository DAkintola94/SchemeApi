using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProtoApi
{
	public class Information
	{
		public string? Name { get; set; }

		public string? Place { get; set; }

		public int Age { get; set; }

		public string? Email { get; set; }
		[Key]
		public int PhoneNr { get; set; }

		[NotMapped]
		public IFormFile? Image { get; set; }

		[NotMapped]
		public byte[]? ImageData { get; set; }


	}
}
