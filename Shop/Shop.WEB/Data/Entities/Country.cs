namespace Shop.WEB.Data.Entities
{
	using System;
	using System.ComponentModel.DataAnnotations;

	public class Country : IEntity
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }
		
    }
}