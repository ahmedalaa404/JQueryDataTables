using System;
using System.ComponentModel.DataAnnotations;

namespace JQueryDataTables.Models
{
	public class Customer
	{

		public int Id { get; set; }
		[Required]
		[MaxLength(50)]
		public string FirstName { get; set; }
		[Required]
		[MaxLength(50)]
		public string LastName { get; set; }
		[Required]
		[MaxLength(20)]
		public string Contact { get; set; }
		[Required]
		[MaxLength(120)]
		public string Email { get; set; }
		public DateTime BirthDate { get; set; }





	}
}
