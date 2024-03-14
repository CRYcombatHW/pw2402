using Microsoft.EntityFrameworkCore;
using PracticalWork.DAL.Entities;

namespace PracticalWork.DAL
{
	public class Context : DbContext
	{
		private string _connectionString => @"Data Source=CRYCOMBATPC\MSSQL2019;Initial Catalog=GamesData;TrustServerCertificate=True;Integrated Security=True;Connect Timeout=30;";

		DbSet<Game> Games { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseSqlServer(_connectionString);
		}
	}
}
