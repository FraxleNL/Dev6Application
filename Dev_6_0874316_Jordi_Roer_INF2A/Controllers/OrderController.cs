    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dev_6_0874316_Jordi_Roer_INF2A.Controllers
{
    public class OrderController : Controller
    {
        DevDBContainer db = new DevDBContainer( );

        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New ( )
        {
            return View( );
        }

        public ActionResult Create(String firstName, String insertion, String lastName, String dateOfBirth, String emailAdress, String city, String sex, Boolean customerWaits )
        {
            Order order = new Order( );
            Customer customer = new Customer( );
            customer.FirstName = firstName;
            customer.Insertion = insertion;
            customer.LastName = lastName;
            //customer.DateOfBirth = DateTime.Parse( dateOfBirth );
            customer.Sex = sex;
            customer.City = city;
            customer.EmailAdress = emailAdress;

            db.Customers.Add( customer );
            db.SaveChanges( );

            order.CustomerID = customer.ID;
            order.CustomerWaits = customerWaits;
            order.OrderComplete = false;
            order.Processed = false;
            //order.StartingTime = DateTime.Now;

            db.Orders.Add( order );
            db.SaveChanges( );

            
            return RedirectToAction( "Index", "Home" );
        }
    }
}
