using System.Threading.Tasks;
using BlogUygulaması.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BlogUygulaması.Controllers;

public class AdminController : Controller
{

    private readonly DataContext _dataContext;
    private readonly UserManager<AppUser> _userManager;

    public AdminController(DataContext dataContext, UserManager<AppUser> userManager)
    {
        _dataContext = dataContext;
        _userManager = userManager;
    }

    public ActionResult Index()
    {
        var result = _dataContext.WordModels.ToList();

        return View(result);
    }

    public ActionResult Create()
    {
        var viewModel = new BlogCreateViewModel
        {
            Word = new WordModel(),
            KonularList = _dataContext.KonularModel.ToList()
        };
        return View(viewModel);
    }

    [HttpPost]
    public async Task<ActionResult> Create(BlogCreateViewModel model)
    {
        ModelState.Remove("KonularList");

        if (ModelState.IsValid)
        {
            string fileName = null;
            if (model.Word.Resim != null && model.Word.Resim.Length > 0)
            {
                var extension = Path.GetExtension(model.Word.Resim.FileName);
                fileName = Path.GetRandomFileName() + extension;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await model.Word.Resim.CopyToAsync(stream);
                }
            }

            var word = new WordModel()
            {
                KonularId = model.Word.KonularId,
                AnaBaşlık = model.Word.AnaBaşlık,
                DateTime = model.Word.DateTime,
                Açıklama = model.Word.Açıklama,
                MiniAciklama = model.Word.MiniAciklama,
                ResimDosyaAdi = fileName
            };

            _dataContext.WordModels.Add(word);
            _dataContext.SaveChanges();

            return RedirectToAction("Index", "Admin");
        }

        model.KonularList = _dataContext.KonularModel.ToList();
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

        return RedirectToAction("Index", "Admin");
    }

    public async Task<ActionResult> Design(int id)
    {
        var result = await _dataContext.WordModels.Where(i => i.Id == id).FirstOrDefaultAsync();
        return View(result);
    }

    [HttpPost]
    public async Task<ActionResult> DesignConfirm(int? id, WordModel model)
    {
        if (ModelState.IsValid)
        {
            var result = await _dataContext.WordModels.Where(i => i.Id == id).FirstOrDefaultAsync();
            if (result == null)
            {
                TempData["Message"] = "Güncellenecek blog bulunamadı!";
                return RedirectToAction("Index", "Admin");
            }

            string fileName = result.ResimDosyaAdi;

            if (model.Resim != null && model.Resim.Length > 0)
            {
                var extension = Path.GetExtension(model.Resim.FileName);
                fileName = Path.GetRandomFileName() + extension;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await model.Resim.CopyToAsync(stream);
                }
            }

            result.Konular = model.Konular;
            result.AnaBaşlık = model.AnaBaşlık;
            result.DateTime = model.DateTime;
            result.Açıklama = model.Açıklama;
            result.MiniAciklama = model.MiniAciklama;
            result.ResimDosyaAdi = fileName;

            await _dataContext.SaveChangesAsync();

            return RedirectToAction("Index", "Admin");
        }
        return RedirectToAction("Index", "Admin");
    }

    public ActionResult UserManagement()
    {

        var result = _userManager.Users.ToList();

        return View(result);
    }

}


