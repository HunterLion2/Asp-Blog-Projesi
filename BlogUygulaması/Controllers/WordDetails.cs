using System.Threading.Tasks;
using BlogUygulaması.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogUygulaması.Controllers;

public class WordDetails : Controller
{
    private readonly DataContext _context;

    public WordDetails(DataContext context)
    {
        _context = context;
    }

    public async Task<ActionResult> Index(int Id)
    {
        var result = await _context.WordModels.Where(i => i.Id == Id).FirstOrDefaultAsync();

        return View(result);
    }

}

