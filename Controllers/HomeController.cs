using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using crud_music.Models;

namespace crud_music.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _db;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _db = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult getArtis()
        {
            var start = Request.Form["start"].FirstOrDefault();
            var length = Request.Form["length"].FirstOrDefault();
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            var searchValue = Request.Form["search[value]"].FirstOrDefault();

            var data = _db.Artists.Select(a => a);

            if (!string.IsNullOrEmpty(searchValue))
            {
                data = data.Where(b => b.artisName.Contains(searchValue) || b.albumName.Contains(searchValue));
            }

            return Json(new
            {
                draw = Convert.ToInt32(HttpContext.Request.Form["draw"].FirstOrDefault()),
                recordsFiltered = data.Count(),
                recordsTotal = data.Count(),
                data = data.Skip(skip).Take(pageSize).ToArray()
            });
        }

        public IActionResult addEdit(int id)
        {
            var model = new artist();

            if (id != 0)
            {
                var data = _db.Artists.Find(id);
                model.artisID = data.artisID;
                model.artisName = data.artisName;
                model.albumName = data.albumName;
                model.imageURL = data.imageURL;
                model.releaseDate = data.releaseDate;
                model.price = data.price;
                model.sampleURL = data.sampleURL;
            }
            return PartialView("addEdit", model);
        }

        public async Task<IActionResult> submitMusic(artist data)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    dynamic dt;
                    dt = data.artisID != 0 ? _db.Artists.FirstOrDefault(a => a.artisID == data.artisID) : new artist();
                    dt.artisName = data.artisName;
                    dt.albumName = data.albumName;
                    dt.imageURL = data.imageURL;
                    dt.releaseDate = data.releaseDate;
                    dt.price = data.price;
                    dt.sampleURL = data.sampleURL;

                    if (data.artisID != 0)
                    {
                        _db.Artists.Update(dt);
                    }
                    else
                    {
                        _db.Artists.Add(dt);
                    }

                    await _db.SaveChangesAsync();

                    return Content("OK");
                }
                catch (Exception ex)
                {
                    return Content(ex.Message.ToString());
                }
            }
            return View(data);
        }

        public IActionResult playMUsic(int id)
        {
            return new JsonResult(_db.Artists.FindAsync(id));
        }

        public async Task<IActionResult> delete(int id)
        {
            try
            {
                var d = _db.Artists.FirstOrDefault(a => a.artisID == id);
                _db.Artists.Remove(d);
                await _db.SaveChangesAsync();
                return Content("OK");
            }
            catch (Exception ex)
            {
                return Content(ex.Message.ToString());
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
