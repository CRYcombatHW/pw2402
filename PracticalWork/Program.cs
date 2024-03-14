using PracticalWork.DAL;
using PracticalWork.DAL.Entities;

namespace PracticalWork
{
	internal class Program
	{
		static void Main(string[] args) {
			using Context context = new Context();

			AddGames(context);
			context.SaveChanges();

			WriteGames(context);
		}

		private static void AddGames(Context context) {
			Game genshinImpact = new Game() {
				Name = "Genshin Impact",
				Style = "Adventure game",
				Developer = "miHoYo",
				IsMultiplayer = true,
				ReleaseDate = DateTime.Parse("09.28.2020"),
				CopiesSold = 139500000,
			};
			Game starRail = new Game() {
				Name = "Honkai - Star Rail",
				Style = "Adventure game",
				Developer = "miHoYo",
				IsMultiplayer = true,
				ReleaseDate = DateTime.Parse("04.09.2023"),
				CopiesSold = 100000000,
			};

			context.Games.Add(genshinImpact);
			context.Games.Add(starRail);
		}

		private static void WriteGames(Context context) {
			foreach (Game game in context.Games) {
				Console.WriteLine(game);
			}
		}
	}
}
