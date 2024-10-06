namespace ProtoApi
{
	public class Information
	{
		public string? Name { get; set; }
		public string? Place { get; set; }
		public int Age { get; set; }
		public string? Email { get; set; }
		
		public int PhoneNr { get; set; }

		public IFormFile? Image { get; set; }

		public byte[]? ImageData { get; set; }


	}
}
