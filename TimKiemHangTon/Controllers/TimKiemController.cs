using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimKiemHangTon.Models;

namespace TimKiemHangTon.Controllers
{
    public class TimKiemController : Controller
    {
        private readonly db_KhoHangContext _context;

        public TimKiemController(db_KhoHangContext context)
        {
            _context = context;          
        }
        public IActionResult Index(string skey)
        {
            var hangton = _context.HangTons.Where(p => p.InspectionNo == skey).SingleOrDefault();
            return View(hangton);
        }
    }
}
