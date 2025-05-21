using BlogUygulaması.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogUygulaması.Controllers;

public class CreateWordController : Controller
{
    private readonly DataContext _dataContext;

    public CreateWordController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public ActionResult Index(WordModel model)
    {
        if (ModelState.IsValid)
        {
            var word = new WordModel
            {
                Id = model.Id,
                Resim = model.Resim,
                AnaBaşlık = model.AnaBaşlık,
                DateTime = model.DateTime,
                Açıklama = model.Açıklama
            };
        }
        return View();
    }

}

