using Microsoft.AspNetCore.Mvc;
using BlogUygulaması.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogUygulaması.Controllers;

public class HomeController : Controller
{
    private readonly DataContext _context;
    public HomeController(DataContext context)
    {
        _context = context;
    }

    public ActionResult Index(string Search)
    {
        var yazilar = _context.WordModels.OrderByDescending(w => w.DateTime).Take(3).ToList();

        if (Search != null) {

            var digerYazilar = _context.WordModels.Where(w => w.AnaBaşlık.ToLower().Contains(Search.ToLower()));

            ViewBag.DigerYazilar = digerYazilar;
        }
        else
        {
            var digerYazilar = _context.WordModels.OrderByDescending(w => w.DateTime).Skip(3).ToList();

            ViewBag.DigerYazilar = digerYazilar;
        }
        return View(yazilar);
    }

}
