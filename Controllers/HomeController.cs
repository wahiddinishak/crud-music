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


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
