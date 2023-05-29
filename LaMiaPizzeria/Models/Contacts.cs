using System.ComponentModel.DataAnnotations;

namespace LaMiaPizzeria.Models
{
    public class Contacts
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il campo titolo è obbligatorio!")]
        [StringLength(100, ErrorMessage = "Il campo titolo può essere lungo al massimo 100 caratteri")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Il campo titolo è obbligatorio!")]
        [StringLength(100, ErrorMessage = "Il campo titolo può essere lungo al massimo 100 caratteri")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Il campo titolo è obbligatorio!")]
        [EmailAddress(ErrorMessage = "L'email inserita non è valida!")]
        public string Email { get; set; }
        public string Feedback { get; set; }

        public Contacts()
        {
           
        }

        public Contacts(string name, string surname, string email, string feedback)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Feedback = feedback;
        }
    }
}
