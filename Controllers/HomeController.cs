using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DiscosMusica.Models;

namespace DiscosMusica.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Dictionary<int, Disco> discos = Biblioteca.InicializarBiblioteca(); 
        ViewBag.discos = discos;
        Dictionary<int, Disco> biblioteca = Biblioteca.InicializarBiblioteca(); 
        ViewBag.biblioteca = biblioteca;
        return View();
    }
}
