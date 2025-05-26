using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project_MVC.Models;

namespace Project_MVC.Controllers;

public class NumberController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Tinh()
    {
        return View();
    }
    public int Tinh(int number)
    {
        var value = number;
        return (int)value * value;
    }

}
