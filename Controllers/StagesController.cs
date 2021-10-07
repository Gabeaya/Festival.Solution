using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Festival.Models;
using System.Collections.Generic;
using System.Linq;

namespace Festivals.Controllers
{
  public class StagesController : Controller
  {
    private readonly FestivalContext _db;

    public StagesController(FestivalContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stage> model = _db.Stages.ToList();
      return View(model);
      // IQueryable<Stage> Stages= _db.Stages.OrderBy(x => x.Name);
      // if (!string.IsNullOrEmpty(searchString))
      // {
      //   Stages = Stages.Where(Stage => Stage.Name.Contains(searchString));
      // }
      // return View(Stages.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stage stage)
    {
      _db.Stages.Add(stage);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Stage thisStage = _db.Stages.FirstOrDefault(stage => stage.StageId == id);
      return View(thisStage);
    }
    public ActionResult Edit(int id)
    {
      var thisStage = _db.Stages.FirstOrDefault(Stage => Stage.StageId == id);
      return View(thisStage);
    }

    [HttpPost]
    public ActionResult Edit(Stage stage)
    {
      _db.Entry(stage).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisStage = _db.Stages.FirstOrDefault(stage => stage.StageId == id);
      return View(thisStage);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisStage = _db.Stages.FirstOrDefault(stage => stage.StageId == id);
      _db.Stages.Remove(thisStage);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}