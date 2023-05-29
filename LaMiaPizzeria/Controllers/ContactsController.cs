using LaMiaPizzeria.Database;
using LaMiaPizzeria.Models;
using LaMiaPizzeria.Models.ModelForViews;
using Microsoft.AspNetCore.Mvc;

namespace LaMiaPizzeria.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            using (PizzaContext db = new PizzaContext())
            {
                List<Contacts> feedbacks = db.Feedbacks.ToList();
                return View("Index", feedbacks);
            }
        }

        [HttpGet]
        public IActionResult Feedback()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Contacts newfeedbacks)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", newfeedbacks);
            }

            using (PizzaContext db = new PizzaContext())
            {
                db.Feedbacks.Add(newfeedbacks);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

        }

    }
}
