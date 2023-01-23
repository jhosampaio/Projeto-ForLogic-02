using FL.OpCuriosidade.UI.Data;
using FL.OpCuriosidade.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FL.OpCuriosidade.UI.Controllers
{
    [Authorize]
    public class ColaboradoresController : Controller
    {
        private readonly FLOpCuriosidadeDataContext _ctx = new FLOpCuriosidadeDataContext();
        public ViewResult Index() 
        {
            var colaboradores = _ctx.Colaboradores.ToList();            
            
            return View(colaboradores);
        }       
        
        public ViewResult Relatorios()
        {
            return View();
        }
        public ViewResult ImprimirRelatorios()
        {
            var colaboradores = _ctx.Colaboradores.ToList();
            return View(colaboradores);
        }
        [HttpGet]
        public ViewResult AddCadastro(int? id)
        {
            Colaborador colaborador = new Colaborador();
            if( id!= null)
            {
                colaborador = _ctx.Colaboradores.Find(id);
            }
            return View(colaborador);
        }

        [HttpPost]
        public ActionResult AddCadastro(Colaborador colaborador)
        {
            if (ModelState.IsValid)
            {
                if (colaborador.Id == 0)
                {
                    _ctx.Colaboradores.Add(colaborador);
                }
                else
                {
                    _ctx.Entry(colaborador).State = System.Data.Entity.EntityState.Modified;
                }

                _ctx.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }
        
        public ActionResult Deletar(int id)
        {
            var colaborador = _ctx.Colaboradores.Find(id);            
            if (colaborador == null)
            {
                return HttpNotFound();
            }
            _ctx.Colaboradores.Remove(colaborador);
            _ctx.SaveChanges();
            return null;
        }
        protected override void Dispose(bool disposing)
        {

            _ctx.Dispose();

        }
    }
}