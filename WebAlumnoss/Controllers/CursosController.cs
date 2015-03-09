using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
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


        public ActionResult Alta()
        {
            return View(new Cursos());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public ActionResult Alta (Cursos model)
        {if (ModelState.IsValid)
        {
            db.Cursos.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
            return View(model);
        }

        public ActionResult Borrar(int id)
        {
            var model = db.Cursos.Find(id);

            try
            {
                db.Cursos.Remove(model);
                db.SaveChanges();
            }

            catch (Exception ee)
            {
                Console.WriteLine(ee);
            }

            return RedirectToAction("Index");
        }

        public ActionResult Modificar(int id)
        {
            var cursos = db.Cursos.Find(id);
            return View(cursos);
        }

        [HttpPost]
        public ActionResult Modificar(Cursos model)
        {
            if (ModelState.IsValid)
            {
                var m = db.Cursos.Find(model.id);
                m.nombre = model.nombre;
                m.inicio= model.inicio;
                m.fin = model.fin;

                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(model);
        }


        protected override void Dispose(bool disposing)
        {
        base.Dispose(disposing);
            db.Dispose();

        }

    }

}