using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> customers = new List<Customer>
        { new Customer{Id=1,Name = "Customer 1"},
            new Customer{Id=2,Name ="Customer 2"}
        };
        public IActionResult Customers()
        {
            return View(customers);
        }
    }
}
