using Microsoft.AspNetCore.Mvc;
using BlogUygulaması.Models;
using Microsoft.EntityFrameworkCore;

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
        var yazilar = _context.KonularModel.ToList();
        return View(yazilar);
    }

    public async Task<ActionResult> CategoryDetailsAsync(int Id)
    {

        var result = await _context.WordModels.Where(i => i.KonularId == Id).ToListAsync();

        return View(result);
    }

}
