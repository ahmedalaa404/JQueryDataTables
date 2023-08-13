using JQueryDataTables.Models;
using Microsoft.AspNetCore.Mvc;

using System.Linq;

namespace JQueryDataTables.controller
{
	public class CustomersController : Controller
	{
		private readonly ApplicationsDBContext _dbContext;

		public CustomersController (ApplicationsDBContext DbContext)
		{
			_dbContext = DbContext;

		}
		[HttpPost]
		public IActionResult GetCustomers()
		{
			var pagesize = int.Parse(Request.Form["length"]);
			var Skip = int.Parse(Request.Form["start"]);
			var AllCustomer = _dbContext.Customers.Skip(Skip).Take(pagesize).ToList();

			var RecouredsTotal = AllCustomer.Count();
			var JsonData = new { RecouredFilter = RecouredsTotal, RecouredsTotal, data = AllCustomer };
			return Ok(JsonData);
		}





	}
}
