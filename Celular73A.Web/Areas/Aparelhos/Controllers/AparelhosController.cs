using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Celular73A.Model.Entidades;
using Celular73A.Model;

namespace Celular73A.Web.Areas.Aparelhos.Controllers
{
    public class AparelhosController : Controller
    {
        // GET: Aparelhos/Aparelhos
        public ActionResult Index()
        {
            return View();
        }

        // GET: Aparelhos/Aparelhos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Aparelhos/Aparelhos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aparelhos/Aparelhos/Create
        [HttpPost]
        public ActionResult Create(Aparelho aparelho )
        {
            try
            {
                // TODO: Add insert logic here
                Servico.salvar(aparelho);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Aparelhos/Aparelhos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Aparelhos/Aparelhos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Aparelhos/Aparelhos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Aparelhos/Aparelhos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
