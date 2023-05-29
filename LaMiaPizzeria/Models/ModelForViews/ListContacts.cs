namespace LaMiaPizzeria.Models.ModelForViews
{
    public class ListContacts
    {
        public List<Contacts> ResultContact { get; set; }

        public ListContacts(List<Contacts> resultContacts)
        {

            ResultContact = resultContacts;
        }
    }
}
