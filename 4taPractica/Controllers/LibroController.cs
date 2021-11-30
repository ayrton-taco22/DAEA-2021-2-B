using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace _4taPractica.Controllers
{
    public class LibroController : Controller
    {
        #region Contexto
        private libroEntities _contexto;
        public libroEntities Contexto
        {
            set { _contexto = value; }
            get {
                if (_contexto == null)
                    _contexto = new libroEntities();
                return _contexto;
            }
        }
        #endregion

        // GET: Libro
        public ActionResult Index()
        {
            return View(Contexto.Prestamos.ToList());
        }

        public ActionResult CreateLibro()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateLibro(Libro nuevoLibro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contexto.Libro.Add(nuevoLibro);
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(nuevoLibro);
            }
            catch
            {
                return View();
            }
        }
    }
}