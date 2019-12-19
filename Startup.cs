using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace aspnet_skeleton
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services) => services.AddMvc().AddRazorRuntimeCompilation();

    public void Configure(IApplicationBuilder app)
    {
      app.UseDeveloperExceptionPage();
      app.UseStaticFiles();
      app.UseRouting();
      app.UseEndpoints(x => x.MapDefaultControllerRoute());
    }
    
    public static void Main(string[] args) => 
      WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().Build().Run();
    
  }
  
}