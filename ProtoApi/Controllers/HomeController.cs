using Microsoft.AspNetCore.Mvc;
using ProtoApi.Data;

namespace ProtoApi.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private static List<Information> _informationList = new List<Information>();
		private readonly ApplicationDbContext _context;
		public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
		{
			_logger = logger;
			_context = context;
		}


		[HttpPost]
		[Route("PostApiScheme")] //my method to post the data, its also the one JS is using to post data
		public async Task<IActionResult> viewData([FromForm] Information information)
		{
			_logger.LogInformation("Application scheme received");
			if (information.Image != null)
			{
				MemoryStream ms = new MemoryStream();
				information.Image.CopyTo(ms);
				information.ImageData = ms.ToArray();
			}

			_context.Information_data.Add(information); //this is to add the data to the database. Rembember its the variabel of dbcontext class
			await _context.SaveChangesAsync(); //this is to save the data to the database

			_informationList.Add(information); //this act as a "mellom lager" so we can use it else where
											   //its the same as changes.Add();
			return Ok(information);

		}

		[HttpGet]
		[Route("GetApiScheme")] //This is to fetch the data, also the one the second JS is depending on
		public async Task<IActionResult> GetInformation() //you dont need a model or anything fancy here, just return the list
        {
            return Ok(_informationList);
        }


    }
}
