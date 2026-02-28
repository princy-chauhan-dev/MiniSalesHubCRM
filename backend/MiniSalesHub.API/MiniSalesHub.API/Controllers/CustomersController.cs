using Microsoft.AspNetCore.Mvc;
using MiniSalesHub.API.Models;

namespace MiniSalesHub.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private static List<Customer> customers = new List<Customer>();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(customers);
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            customer.Id = customers.Count + 1;
            customers.Add(customer);
            return Ok(customer);
        }
    }
}