using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class HomeController:Controller
    {
        //get Home
        public ActionResult Index()
        {
            return View();
        }
    }
}
