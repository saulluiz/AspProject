using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AspProject.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        private static List<Usuario> listagem = new List<Usuario>(); 
        public static IQueryable<Usuario> Listagem
        {
            get
            {
                return listagem.AsQueryable();
            }
        }
        static Usuario(){
            Usuario.listagem.Add(new Usuario{IdUsuario=1,Nome="Fulano", Email= "Fulano@email.com"});
            Usuario.listagem.Add(new Usuario{IdUsuario=2,Nome="Fulano2", Email= "Fulan2@email.com"});
            Usuario.listagem.Add(new Usuario{IdUsuario=3,Nome="Fulano3", Email= "Fulan3@email.com"});
            Usuario.listagem.Add(new Usuario{IdUsuario=4,Nome="Fulano4", Email= "Fulan4@email.com"});
            Usuario.listagem.Add(new Usuario{IdUsuario=5,Nome="Fulano5", Email= "Fulan5@email.com"});
            Usuario.listagem.Add(new Usuario{IdUsuario=6,Nome="Fulano6", Email= "Fulan6@email.com"});
       
        }
        public static void Salvar(Usuario usuario){
            var usuarioExistente = Usuario.listagem.Find(u=>u.IdUsuario==usuario.IdUsuario);
            if(usuarioExistente != null){
                usuarioExistente.Nome=usuario.Nome;
                usuarioExistente.Email=usuario.Email;
            }
            else{
                int maiorId=Usuario.Listagem.Max(u=>u.IdUsuario);
                usuario.IdUsuario=maiorId+1;
                Usuario.listagem.Add(usuario);
            }
        }
        public static void Excluir(int idUsuario){
            var usuarioExistente = Usuario.listagem.Find(u=>u.IdUsuario==idUsuario);
            if(usuarioExistente!=null){
                Usuario.listagem.Remove(usuarioExistente);
            }
          
            
        }
        


    }
}