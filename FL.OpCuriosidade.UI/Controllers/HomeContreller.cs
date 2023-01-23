using FL.OpCuriosidade.UI.Data;
using FL.OpCuriosidade.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FL.OpCuriosidade.UI.Controllers
{
    public class HomeController : Controller 
    {
        private readonly FLOpCuriosidadeDataContext _ctx = new FLOpCuriosidadeDataContext();
        public ViewResult Index() 
        {
            var colaboradores = _ctx.Colaboradores.ToList();

            ViewBag.Total = colaboradores.Count;
            ViewBag.Ativos = colaboradores.Where(w =>w.TipoStatusId == 1).Count();

            return View(colaboradores);
        }
        

    }

}