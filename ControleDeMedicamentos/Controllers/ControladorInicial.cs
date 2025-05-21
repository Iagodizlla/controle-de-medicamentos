using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using System.Web.Mvc;

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