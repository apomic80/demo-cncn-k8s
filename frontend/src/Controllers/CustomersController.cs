using frontend.src.Models.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace frontend.src.Controllers
{
    public class CustomersController
        : Controller
    {
        private readonly MyAppDbContext context = null;

        public CustomersController(MyAppDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var customers = this.context.Customers.ToList();
            return View(customers);
            
        }
    }
}