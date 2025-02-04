using Microsoft.AspNetCore.Mvc;
using Basic_MVC_Practice.Models;
using Basic_MVC_Practice.ViewModels;
using System.Collections.Generic;

namespace Basic_MVC_Practice.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Yılmaz",
                Email = "ali.yilmaz@example.com"
            };

            var orders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Laptop", Price = 15000, Quantity = 1 },
                new Order { Id = 2, ProductName = "Mouse", Price = 500, Quantity = 2 },
                new Order { Id = 3, ProductName = "Klavye", Price = 1000, Quantity = 1 }
            };

            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(viewModel);
        }
    }
}
