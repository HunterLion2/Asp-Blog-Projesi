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

    public ActionResult Search()
    {
        return View();
    }

    public async Task<ActionResult> CategoryDetailsAsync(int Id)
    {

        var result = await _context.WordModels.Where(i => i.KonularId == Id).ToListAsync();

        ViewData["konuhead"] = await _context.KonularModel.Where(i => i.Id == Id).Select(k => k.Konu).FirstOrDefaultAsync();
        return View(result);
    }

}
