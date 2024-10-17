using Microsoft.EntityFrameworkCore;

namespace ProtoApi.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<Information> Information_data { get; set; }
	}
}
