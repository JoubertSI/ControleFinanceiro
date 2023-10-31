using Microsoft.AspNetCore.Mvc;
using SistemaFinanceiroUGB232.Models;

namespace SistemaFinanceiroUGB232.Controllers
{
    public class DepartamentoController : Controller
    {
        private static IList<Departamento> departamentos = new List<Departamento>()
        {
            new Departamento ()
            {
                DepartamentoId = 1,
                Nome =  "Adm",

            },

            new Departamento ()
            {
                DepartamentoId = 2,
                Nome = "Financeiro",

            } 
        };
        public IActionResult Index()
        {
            return View();
        }
    }
}
