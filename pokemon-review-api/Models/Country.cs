﻿namespace pokemon_review_api.Models
{
	public class Country
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public ICollection<Owner> Owners { get; set; }
	}
}
