using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dev_6_0874316_Jordi_Roer_INF2A.Controllers
{
    public class HomeController : Controller
    {
        DevDBContainer db = new DevDBContainer( );

        public ActionResult Index( )
        {

            
            return View( );
        }

        public ActionResult About( )
        {
            ViewBag.Message = "Your application description page.";

            return View( );
        }

        public ActionResult Contact( )
        {
            ViewBag.Message = "Your contact page.";

            return View( );
        }
    }
}