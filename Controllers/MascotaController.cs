using Microsoft.AspNetCore.Mvc;
using VeterinariaMVC.Models;

namespace VeterinariaMVC.Controllers
{
    public class MascotaController : Controller
    {
        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                // Aquí podrías guardar la mascota en una base de datos o lista temporal
                ViewBag.Mensaje = "Mascota registrada correctamente";
            }
            return View();
        }
    }
}