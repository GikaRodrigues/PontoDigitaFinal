using Microsoft.AspNetCore.Http;
using Hamburgueria_Manha.Repositorios;
using SENAI_ponto_digital.Repositorio;
using Microsoft.AspNetCore.Mvc;
using SENAI_ponto_digital.Models;

namespace SENAI_ponto_digital.Controllers
{
    public class DepoimentosController : Controller
    {
        private DepoimentosRepository depoimentosRepository = new DepoimentosRepository();
        
        public IActionResult DepoimentosFeitos(){
            ViewData["NomeView"] = "Depoimentos";
            return View();
        }

        public IActionResult Index(){

            return View();
        }
        public IActionResult CadastroDepoimentos(IFormCollection form){

            Depoimentos depoimentos = new Depoimentos();
            depoimentos.Nome = form["nome"];
            depoimentos.Comentario = form["comentario"];
        

            depoimentosRepository.Inserir(depoimentos);
            
            ViewData["Action"] = "Depoimento";
            return View("Sucesso");
        }
    }
}
