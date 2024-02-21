using System.ComponentModel.DataAnnotations.Schema;

namespace pokemon_review_api.Models
{
	public class PokemonOwner
	{
		public int PokemonId { get; set; }
		public int OwnerId { get; set; }

		[ForeignKey(nameof(OwnerId))]
		public Owner Owner { get; set; }

		[ForeignKey(nameof(PokemonId))]
		public Pokemon Pokemon { get; set; }
	}
}
