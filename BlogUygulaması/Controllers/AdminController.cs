using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers;


public class Admin : Controller
{

    public ActionResult Index()
    {
        return View();
    }

}


