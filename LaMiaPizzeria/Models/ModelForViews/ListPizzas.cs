namespace LaMiaPizzeria.Models.ModelForViews
{
    public class ListPizzas
    {
        public string SearchString { get; set; }

        public List<Pizza> ResultPizza { get; set; }

        public ListPizzas(string searchString, List<Pizza> resultPizza)
        {
            
            SearchString = searchString;
            ResultPizza = resultPizza;
        }
    }
}
