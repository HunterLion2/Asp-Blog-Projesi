using System.Threading.Tasks;
using BlogUygulaması.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Login.Controllers;

public class Login : Controller
{
    private readonly DataContext _context;
    private readonly UserManager<AppUser> _userManager;

    public Login(DataContext context, UserManager<AppUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public ActionResult Index()
    {
        return View();
    }

    public ActionResult Signin()
    {
        return View();
    }

    [HttpPost]
    public ActionResult SigninPost(AppUserCreate model)
    {

        if(ModelState.IsValid) {
            
        }

        return View();
    }

    public ActionResult AccessDenied()
    {
        return View();
    }

}