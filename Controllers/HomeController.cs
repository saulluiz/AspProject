using System.Linq;
using System.Security.Cryptography.X509Certificates;
using AspProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspProject.Controllers{
    public class HomeController:Controller{
        public IActionResult Index(){
            return View();
        }
        public IActionResult Usuarios(){
            return View(Usuario.Listagem);
        }
        [HttpGet]
        public IActionResult Cadastrar(int? id){
            var usuario=new Usuario();
            if(id!=null){
                if(Usuario.Listagem.Any(u=>u.IdUsuario==id))
             usuario=Usuario.Listagem.Single(u=>u.IdUsuario==id);
            }
           

            return View(usuario);//passa todo o objeto "Listagem" como um Model a pag
        }
        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {
            Usuario.Salvar(usuario);
            return RedirectToAction("Usuarios");
        }
        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id.HasValue && Usuario.Listagem.Any(u=> u.IdUsuario == id)){

                var usuario=Usuario.Listagem.Single(u=>u.IdUsuario == id);

                return View(usuario);
            }
            return RedirectToAction("Usuarios");
        }
        [HttpPost]
        public IActionResult Excluir(Usuario usuario)
        {
           Usuario.Excluir(usuario.IdUsuario);
           return RedirectToAction("Usuarios");
        }
        
    }
}