using JQueryDataTables.Models;
using Microsoft.AspNetCore.Mvc;

using System.Linq;
using System.Linq.Dynamic.Core;

namespace JQueryDataTables.controller
{
	public class CustomersController : Controller
	{
		private readonly ApplicationsDBContext _dbContext;

		public CustomersController(ApplicationsDBContext DbContext)
		{
			_dbContext = DbContext;

		}
		[HttpPost]
		public IActionResult GetCustomers()
		{
			var pagesize = int.Parse(Request.Form["length"]);
			var Skip = int.Parse(Request.Form["start"]);

			var SearchValue = Request.Form["search[value]"];
			var sortColumn = Request.Form[string.Concat("columns[",Request.Form["order[0][column]"],"][name]")];
			var SortColumnDir = Request.Form["order[0][dir]"];


			IQueryable<Customer> Customer = _dbContext.Customers.Where(x => string.IsNullOrEmpty(SearchValue) ? true :
						(x.FirstName.ToLower().Contains(SearchValue) ||
							x.LastName.ToLower().Contains(SearchValue) ||
							x.Email.ToLower().Contains(SearchValue) ||
							 x.Contact.ToLower().Contains(SearchValue))

			);

			if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(SortColumnDir) ))
				Customer = Customer.OrderBy(string.Concat(sortColumn," ", SortColumnDir));




			var data = Customer.Skip(Skip).Take(pagesize).ToList();

			var RecordsTotal = Customer.Count();
			var JsonData = new { RecouredFiltered = RecordsTotal, RecordsTotal, data };
			return Ok(JsonData);
		}

		public IActionResult GetCustomers1()
		{




			IQueryable<Customer> Customer = _dbContext.Customers;






			var data = Customer.Select(x => x);

			var RecordsTotal = Customer.Count();
			var JsonData = new { RecouredFiltered = RecordsTotal, RecordsTotal, data };
			return Ok(JsonData);
		}




	}
}
