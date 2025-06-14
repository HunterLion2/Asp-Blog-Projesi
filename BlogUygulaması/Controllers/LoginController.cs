using System.Threading.Tasks;
using BlogUygulaması.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BlogUygulaması.Controllers;

public class LoginController : Controller
{
    private readonly DataContext _context;
    private readonly UserManager<AppUser> _userManager;

    public LoginController(DataContext context, UserManager<AppUser> userManager)
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
    public async Task<ActionResult> Signin(AppUserCreate model)
    {

        if (ModelState.IsValid)
        {
            var user = new AppUser
            {
                UserName = model.Email,
                AdSoyad = model.AdSoyad,
                Email = model.Email,
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Admin");
            }

            foreach (var error in result.Errors)
            { // Burada yaptığımız şey result.Errors değeri içerisinde çıkan hataları AddModelError değeri ModelState içerisine atmış oluruz error.Description değeri ile de gelen hataları yazdırırız.
                ModelState.AddModelError("", error.Description);
            }
        }
        return View(model);
    }

    public ActionResult AccessDenied()
    {
        return View();
    }

}