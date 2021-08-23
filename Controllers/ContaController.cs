using GerenciamentoDeIdentidades.ViewModels;
using System.Web.Mvc;

namespace GerenciamentoDeIdentidades.Controllers
{
    public class ContaController : Controller
    {
        //chamada da view Cadastrar
        public ActionResult Cadastrar()
        {
            return View();
        }

        //método POST do cadastro na View. Submeter as informações inseridas no formulário
        [HttpPost]
        public ActionResult Cadastrar(ContaCadastrarViewModel modelo)
        {
            return View();
        }
    }
}