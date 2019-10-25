using AppBancoDLL;
using AppBancoDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            var metodoUsuario = new UsuarioDAO();
            var TodosUsuarios = metodoUsuario.Listar();
            return View(TodosUsuarios);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
               var metodoUsuario = new UsuarioDAO();
                metodoUsuario.Insert(usuario);
                return RedirectToAction("Index");
            }
            return View(usuario);
        }
    }
}