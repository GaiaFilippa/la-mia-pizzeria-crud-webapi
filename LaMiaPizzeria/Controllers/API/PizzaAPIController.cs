using LaMiaPizzeria.Database;
using LaMiaPizzeria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaMiaPizzeria.Controllers.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PizzaAPIController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPizze()
        {
            using (PizzaContext db = new PizzaContext())
            {
                List<Pizza> pizze = db.Pizze.ToList();
                return Ok(pizze);
            }
        }

        [HttpGet("{id}")]
        public IActionResult SearchById(int id)
        {
            using (PizzaContext db = new PizzaContext())
            {
                Pizza? pizzaToSearch = db.Pizze.Where(pizza => pizza.Id == id).FirstOrDefault();

                if (pizzaToSearch != null)
                {
                    return Ok(pizzaToSearch);
                }
                else
                {
                    return NotFound();
                }
            }
        }

        [HttpGet]
        public IActionResult SearchByName(string name)
        {
            using (PizzaContext db = new PizzaContext())
            {
                Pizza? pizzaToSearch = db.Pizze.Where(pizza => pizza.Name.Contains(name)).FirstOrDefault();

                if (pizzaToSearch != null)
                {
                    return Ok(pizzaToSearch);
                }
                else
                {
                    return NotFound();
                }
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] Pizza pizza)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                using (PizzaContext db = new PizzaContext())
                {
                    db.Pizze.Add(pizza);
                    db.SaveChanges();

                    return Ok();
                }
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using (PizzaContext db = new PizzaContext())
            {
                Pizza? pizzaToDelete = db.Pizze.Where(pizza => pizza.Id == id).FirstOrDefault();

                if (pizzaToDelete != null)
                {
                    db.Remove(pizzaToDelete);
                    db.SaveChanges();

                    return Ok();
                }
                else
                {
                    return NotFound("Non ho trovato l'articolo da eliminare!");

                }
            }
        }

    }
}
