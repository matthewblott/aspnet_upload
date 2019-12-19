using Microsoft.AspNetCore.Mvc;

namespace aspnet_skeleton.controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index() => View();
    
  }
    
}
