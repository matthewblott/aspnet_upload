using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_skeleton.controllers
{
  public class UploadsController : Controller
  {
    public IActionResult Index() => View();

    [HttpPost("Uploads")]
    public async Task<IActionResult> Index(IList<IFormFile> files)
    {
      var size = files.Sum(f => f.Length);
      var filePaths = new List<string>();
      
      foreach (var file in files)
      {
        if (file.Length <= 0) continue;
        
        var filePath = Path.GetTempFileName();
          
        filePaths.Add(filePath);

        await using var stream = new FileStream(filePath, FileMode.Create);
          
        await file.CopyToAsync(stream);

      }
 
      return Ok(new { count = files.Count, size, filePaths });
      
    }
    
  }
  
}