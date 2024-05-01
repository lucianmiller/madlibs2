using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;
using System.Collections.Generic;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}