using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlocoNotasVideoYoutube.Models;
using BlocoNotasVideoYoutube.Data;

namespace BlocoNotasVideoYoutube.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        this._context = context;
    }

    public IActionResult Index()
    {
        var notas = _context.Notas
            .OrderByDescending(n => n.DataAtualizacao)
            .ToList();

        return View(notas);
    }

}
