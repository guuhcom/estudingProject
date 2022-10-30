using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoIntegrador.Controllers
{
    public class ProjetoController : Controller
    {
        // GET: ProjetoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProjetoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProjetoController/CriarProjeto
        public ActionResult Criar()
        {
            return View();
        }

        //GET: ProjetoController/Acompanhar
        public ActionResult Acompanhar()
        {
            return View();
        }

        //GET: ProjetoController/Associar
        public ActionResult Associar()
        {
            return View();
        }


        // POST: ProjetoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProjetoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProjetoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProjetoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProjetoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
