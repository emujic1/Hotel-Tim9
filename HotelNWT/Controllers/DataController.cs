using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelNWT.Models;
namespace HotelNWT.Controllers
{
    public class DataController : Controller
    {
        //
        // GET: /Data/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult UserLogin(LoginData d)
        {
            using (hotelEntities dc = new hotelEntities())
            {
                
                var user = dc.user.Where(a => a.username.Equals(d.Username) && a.password.Equals(d.Password)).FirstOrDefault();
                return new JsonResult { Data = user, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }

    }
}
