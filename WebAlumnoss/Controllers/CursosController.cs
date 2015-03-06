using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAlumnoss.Models;

namespace WebAlumnoss.Controllers
{
    public class CursosController : Controller
    {
        CursosEntities db=new CursosEntities();
        // GET: Cursos
        public ActionResult Index()
        {

            return View(db.Cursos);
        }


        public ActionResult alta()
        {
            return View(new Cursos());
        }
        [HttpPost]
        public ActionResult Alta (Cursos model)

        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
        base.Dispose(disposing);
            db.Dispose();

        }

    }

}