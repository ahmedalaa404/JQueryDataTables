using JQueryDataTables.helper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Text.Json;

namespace JQueryDataTables
{
	public class Program
	{
		public static void Main(string[] args)
		{

	
			CreateHostBuilder(args).Build().Run();





        }

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}
