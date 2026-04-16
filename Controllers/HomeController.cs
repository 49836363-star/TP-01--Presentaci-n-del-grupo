using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP01.Models;

namespace TP01.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Grupo g1= new Grupo();
        ViewBag.Grupo= g1.DevolverIntegrantes();
        return View();
    }
    public IActionResult SelectIntegrante(int dni)
    {
        Grupo g1= new Grupo();
        ViewBag.integrante = g1.GetIntegrante(dni);
        ViewBag.DNI= dni;
        return View();
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
