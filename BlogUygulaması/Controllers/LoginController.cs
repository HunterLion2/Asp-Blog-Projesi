using System.Threading.Tasks;
using BlogUygulaması.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Login.Controllers;

public class Login : Controller
{

    public ActionResult Index()
    {
        return View();
    }

}