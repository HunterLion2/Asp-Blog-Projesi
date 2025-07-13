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
        var yazilar = _context.WordModels.ToList();

        // if (Search != null)
        // {
        //     var search = _context.WordModels.Include(p => p.Konular).FirstOrDefault();
        //     return View(search);
        // }
        return View(yazilar);
    }

}
