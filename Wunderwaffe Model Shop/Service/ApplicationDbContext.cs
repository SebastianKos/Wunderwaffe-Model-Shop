using Microsoft.EntityFrameworkCore;
using Wunderwaffe_Model_Shop.Models;

namespace Wunderwaffe_Model_Shop.Service
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions options) : base(options) 
		{
			
		}

		public DbSet<Product> Products { get; set; }
	}
}
