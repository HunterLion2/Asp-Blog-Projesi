using Microsoft.AspNetCore.Mvc;
using BlogUygulaması.Models;

namespace BlogUygulaması.Controllers;

public class HomeController : Controller
{
    private readonly DataContext _context;
    public HomeController(DataContext context)
    {
        _context = context;
    }

    public ActionResult Index()
    {
        var yazilar = _context.WordModels.ToList();
        return View(yazilar);
    }
}
