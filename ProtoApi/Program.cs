
namespace ProtoApi
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			builder.Services.AddCors(options =>
			{
				options.AddPolicy(name: "MyAllowSpecificOrigins",
					policyBuilder =>
					{
						policyBuilder.WithOrigins("http://127.0.0.1:5500") //this makes it possible to listen to "live server"
						//in visual studio code. Remember to use "live server". Essensial to connect frontend to backend
						.AllowAnyHeader()
						.AllowAnyMethod()
						.AllowCredentials();
					});
			});

			
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseCors("MyAllowSpecificOrigins");
			app.UseHttpsRedirection();
			app.UseAuthorization();
			app.MapControllers();
			app.Run();
		}
	}
}
