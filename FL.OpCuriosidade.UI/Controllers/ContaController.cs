using FL.OpCuriosidade.UI.Data;
using FL.OpCuriosidade.UI.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace FL.OpCuriosidade.UI.Controllers
{
    public class ContaController : Controller
    {
        private readonly FLOpCuriosidadeDataContext _ctx = new FLOpCuriosidadeDataContext();
        [HttpGet]
        public ActionResult Login()
        {
            return View(); 
        }
        [HttpPost]
        public ActionResult Login(LoginVM model)
        {
            var usuario = _ctx.Usuarios.FirstOrDefault(u => u.Email.ToLower() == model.Email.ToLower());

            if (usuario == null)
                ModelState.AddModelError("Email", "O e-mail não localizado");
            else
            {
                if (usuario.Senha != model.Senha)
                    ModelState.AddModelError("Senha", "Senha inválida");
            }


            if (ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(model.Email, model.PermanecerLogado);

                if (!string.IsNullOrEmpty(model.ReturnURL) && Url.IsLocalUrl(model.ReturnURL))
                {
                    return Redirect(model.ReturnURL);
                }

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }
        [HttpGet]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }
    }
}