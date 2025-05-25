using Microsoft.AspNetCore.Mvc;
using BlogUygulaması.Models;

namespace BlogUygulaması.Controllers;

public class KonuController : Controller
{
    private readonly DataContext _context;
    public KonuController(DataContext context)
    {
        _context = context;
    }

    public ActionResult Index()
    {
        var yazilar = _context.WordModels.ToList();
        return View(yazilar);
    }
}
