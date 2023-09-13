﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LessonOne.Models;

namespace LessonOne.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    // constructor
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        return View(); // returns Views/Home/About.cshtml
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
