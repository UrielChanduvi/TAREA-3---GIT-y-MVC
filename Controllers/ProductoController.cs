using Microsoft.AspNetCore.Mvc;
using VeterinariaMVC.Models;
using System.Collections.Generic;

namespace VeterinariaMVC.Controllers
{
    public class ProductoController : Controller
    {
        // Simulación de almacenamiento temporal
        private static List<Producto> productos = new List<Producto>();

        public IActionResult Index()
        {
            return View(productos);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Producto producto)
        {
            if (ModelState.IsValid)
            {
                productos.Add(producto);
                ViewBag.Mensaje = "Producto agregado correctamente";
                return RedirectToAction("Index");
            }
            return View(producto);
        }
    }
}
