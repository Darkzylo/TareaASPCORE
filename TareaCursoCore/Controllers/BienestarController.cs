using Microsoft.AspNetCore.Mvc;
using TareaCursoCore.Models;

namespace TareaCursoCore.Controllers
{
    public class BienestarController : Controller
    {

        private SolicitudBeneficio _mantenedor;

        [BindProperty]
        public SolicitudBeneficio? beneficio { get; set; }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AgregarBeneficio()
        {
            _mantenedor.AgregarBeneficio(beneficio.Afiliado, beneficio.Monto);
            return RedirectToAction("Index");
        }

    }
}
