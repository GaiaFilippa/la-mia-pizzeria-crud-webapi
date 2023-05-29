using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaMiaPizzeria.Models
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Il campo del nome è obbligatorio!")]
        [StringLength(50, ErrorMessage = "Il campo del nome può riportare al massimo 50 caratteri.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Il campo della descrizione è obbligatorio!")]
        [Column(TypeName = "text")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Il campo URL dell'immagine è obbligatorio!")]
        [Url(ErrorMessage = "L'URL inserito non è un URL valido!")]
        [StringLength(300, ErrorMessage = "Il campo URL dell'immagine può contenere al massimo 300 caratteri")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Il campo del prezzo è obbligatorio!")]
        [Range(1, float.MaxValue)]
        public float Price { get; set; }

		public int? PizzaCategoryId { get; set; }
		public PizzaCategory? Category { get; set; }

		public Pizza()
        {

        }

        public Pizza(string name, string description, string image, float price)
        {
            Name = name;
            Description = description;
            Image = image;
            Price = price;
        }
    }
}
