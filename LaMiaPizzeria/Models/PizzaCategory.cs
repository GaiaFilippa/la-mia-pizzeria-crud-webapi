namespace LaMiaPizzeria.Models
{
	public class PizzaCategory
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }

		public List<Pizza> Pizze { get; set; }

		public PizzaCategory ()
		{

		}

		public PizzaCategory(string name, string? description)
		{
			Name = name;
			Description = description;
			Pizze = new List<Pizza>();
		}

	}
}
