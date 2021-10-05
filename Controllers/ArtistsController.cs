using Microsoft.AspNetCore.Mvc;
using Festival.Models;
using System.Collections.Generic;
using System.Linq;

namespace Festival.Controllers
{
  public class ArtistsController : Controllers
  {
    private readonly FestivalContext _db;

    public ArtistsController(FestivalContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Artist> model = _db.Artists.ToList();
      return View(model);
    }
  }
}