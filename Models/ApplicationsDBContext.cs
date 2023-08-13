using Microsoft.EntityFrameworkCore;

namespace JQueryDataTables.Models
{
	public class ApplicationsDBContext : DbContext
	{


		public ApplicationsDBContext(DbContextOptions<ApplicationsDBContext> Options) : base(Options)
		{

		}


		public DbSet<Customer> Customers { get; set; }
		#region Old Configuraing
		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	optionsBuilder.UseSqlServer("server=.;database=JQueryDataTables;Trusted_Connection=true");
		//}
		#endregion



	}
}
