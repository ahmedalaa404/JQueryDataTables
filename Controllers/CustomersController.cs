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
		public IActionResult GetCustomers()
		{
			var AllCustomer = _dbContext.Customers.ToList();
			var RecouredsTotal = AllCustomer.Count();
			var JsonData = new { RecouredFilter = RecouredsTotal, RecouredsTotal, data = AllCustomer };
			return Ok(JsonData);
		}
		public IActionResult index()
		{
		   return View();
		}




	}
}
