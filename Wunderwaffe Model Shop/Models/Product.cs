using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Security.Authentication.ExtendedProtection;

namespace Wunderwaffe_Model_Shop.Models
{
	public class Product
	{
		public int Id { get; set; }
		[MaxLength(100)]
		public string Name { get; set; } = "";
		[MaxLength(1000)]
		public string Description { get; set; } = "";
		[MaxLength(50)]
		public string Category { get; set; } = "";
		[Precision(10, 2)]
		public decimal Price { get; set; }
		[MaxLength(100)]
		public string ImageFileName { get; set; } = "";

	}
}

