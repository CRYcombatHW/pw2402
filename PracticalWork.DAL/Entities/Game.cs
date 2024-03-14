using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork.DAL.Entities
{
	public class Game
	{
		public int Id { get; set; }

		public string Name { get; set; }
		public string Developer { get; set; }
		public string Style { get; set; }
		public DateTime ReleaseDate { get; set; }
		public bool IsMultiplayer { get; set; }
		public int CopiesSold { get; set; }

		public override string ToString() {
			return $"{Id}: {Name} | {Developer} | {Style} | {IsMultiplayer} | {ReleaseDate} | {CopiesSold} |";
		}
	}
}
