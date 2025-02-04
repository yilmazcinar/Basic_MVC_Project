//namespace Basic_MVC_Practice.ViewModels
//{
//    public class CustomerOrderViewModel
//    {

//        public Customer Customer { get; set; }

//        public List<Order> Orders { get; set; } 
//    }
//}

namespace Basic_MVC_Practice.ViewModels
{
    using Basic_MVC_Practice.Models;
    using System.Collections.Generic;

    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; }
    }
}
