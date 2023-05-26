using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Expense_Tracker.Models
{
	public class ApplicationDbContext:DbContext
	{
		public ApplicationDbContext(DbContextOptions options):base(options)
		{}

		public DbSet<Transaction> Transactions { get; set; }
		public DbSet<Category> Categories { get; set; }

    }
}

