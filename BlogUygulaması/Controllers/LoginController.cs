using System.Threading.Tasks;
using BlogUygulaması.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BlogUygulaması.Controllers;

public class LoginController : Controller
{
    private readonly DataContext _context;
    private readonly UserManager<AppUser> _userManager;

    private SignInManager<AppUser> _signInManager;

    public LoginController(DataContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
    {
        _context = context;
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<ActionResult> Index(AccountLoginModel model, string? returnUrl)
    {
        if (ModelState.IsValid)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user != null)
            {
                await _signInManager.SignOutAsync();

                var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.BeniHatirla, true);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                else if (result.IsLockedOut)
                {
                    // GetLockoutEndDateAsync(user) bilgisi kullanıcının giriş için ne kadar sonra hesabının kitlendiği bilgisini bize söyler
                    var locoutDate = await _userManager.GetLockoutEndDateAsync(user);
                    var timeLeft = locoutDate.Value - DateTime.UtcNow;

                    ModelState.AddModelError("", $"Hesabınız Kitlenmiştir.Lütfen {timeLeft.Minutes + 1} dakika sonra tekrar deneyiniz.");
                }
            }
            else
            {
                ModelState.AddModelError("", "Böyle Bir Hesap Bulunmamaktadır");
            }
        }
        else
        {

        }
        return View(model);
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