using BlogUygulaması.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Admin.Controllers;

public class Admin : Controller
{

    private readonly DataContext _dataContext;

    public Admin(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public ActionResult Index()
    {
        var result = _dataContext.WordModels.ToList();

        return View(result);
    }

    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<ActionResult> CreateAsync(WordModel model)
    {
        if (ModelState.IsValid)
        {
            var fileName = Path.GetRandomFileName() + "jpg";
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", fileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await model.Resim!.CopyToAsync(stream);
            }

            var word = new WordModel()
            {
                Id = model.Id,
                Konu = model.Konu,
                AnaBaşlık = model.AnaBaşlık,
                DateTime = model.DateTime,
                Açıklama = model.Açıklama,
                MiniAciklama = model.MiniAciklama,
                ResimDosyaAdi = fileName
            };

            _dataContext.WordModels.Add(word);
            _dataContext.SaveChanges();

            return RedirectToAction("Index", "Admin");
        }

        ViewBag.Kategoriler = new SelectList(_dataContext.WordModels.ToList(), "Konu");
        return View(model);
    }

    public async Task<ActionResult> Delete(int Id)
    {

        var result = await _dataContext.WordModels.Where(i => i.Id == Id).FirstOrDefaultAsync();

        return View(result);
    }

    [HttpPost]
    public ActionResult DeleteConfirm(int? id)
    {

        if (id == null)
        {
            return RedirectToAction("Index");
        }

        var entity = _dataContext.WordModels.FirstOrDefault(i => i.Id == id);

        if (entity != null)
        {
            _dataContext.WordModels.Remove(entity);
            _dataContext.SaveChanges();

            TempData["Message"] = $"{entity.AnaBaşlık} Bloğu Silindi";
        }

        return RedirectToAction("Index","Admin");
    }

}


