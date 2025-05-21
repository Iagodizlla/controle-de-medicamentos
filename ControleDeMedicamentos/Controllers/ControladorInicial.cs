using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace ControleDeMedicamentos.Controllers;

[Route("/")]
public class ControladorInicial : Controller
{
    [HttpGet]
    public IActionResult PaginaInicial()
    {
        return View();
    }
}