using Microsoft.AspNetCore.Mvc;
using SistemaFinanceiroUGB232.Models;

namespace SistemaFinanceiroUGB232.Controllers
{
    public class InstituicaoController : Controller
    {
        private static IList<Instituicao> instituicoes = new List<Instituicao>()
        {
            new Instituicao ()
            {
                InstituicaoID = 1,
                Nome =  "Hogwarts",
                Endereco = "Escócia"
            },

            new Instituicao ()
            {
                InstituicaoID = 2,
                Nome = "Mansao X",
                Endereco = "Nova York"
            }


        };
        public IActionResult Index()
        {
            return View(instituicoes);
        }
    }
}
