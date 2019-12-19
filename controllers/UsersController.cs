using aspnet_skeleton.models;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_skeleton.controllers
{
  public class UsersController : Controller
  {
    public IActionResult Index() => View(new UserViewModel());

    [HttpPost]
    public IActionResult Create() => RedirectToAction(nameof(Index));
    
  }
  
}