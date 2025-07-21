using System.Threading.Tasks;
using BlogUygulaması.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogUygulaması.Controllers;

public class UserController : Controller
{
    private readonly DataContext _context;

    public UserController(DataContext context)
    {
        _context = context;
    }

    public async Task<ActionResult> Index()
    {
        return View();
    }

}

