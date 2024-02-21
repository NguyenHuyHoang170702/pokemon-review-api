namespace pokemon_review_api.Models
{
	public class Owner
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Gym { get; set; }
		public Country Country { get; set; }
		public ICollection<PokemonOwner> pokemonOwners { get; set; }
	}
}
