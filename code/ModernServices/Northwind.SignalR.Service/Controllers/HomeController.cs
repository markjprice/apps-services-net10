using Microsoft.AspNetCore.Mvc; // To use Controller.
using Northwind.SignalR.Service.Models; // To use ErrorViewModel.
using System.Diagnostics; // To use Activity.

namespace Northwind.SignalR.Hub.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
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
}