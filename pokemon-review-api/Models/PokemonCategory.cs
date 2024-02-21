using System.ComponentModel.DataAnnotations.Schema;

namespace pokemon_review_api.Models
{
	public class PokemonCategory
	{
		public int PokemonId { get; set; }
		public int CategoryId { get; set; }
		[ForeignKey(nameof(PokemonId))]
		public Pokemon Pokemon { get; set; }

		[ForeignKey(nameof(CategoryId))]
		public Category Category { get; set; }
	}
}
