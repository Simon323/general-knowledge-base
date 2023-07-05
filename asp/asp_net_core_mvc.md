1. In controller directory add new controller
   1. public class EmbedController : Controller
   2. public IActionResult Index()
   3. return View(model);
2. Create Views direcotry and add inside new directory Embed with Index.cshtml
3. Set layout
    ```cshtml
    @{
      Layout = null;
    }
    ```
  
4. Example of including file from wwwroot inside *.cshtml
   1. `<link href="~/styles/reset.css" rel="stylesheet" />`
   2.  `wwwroot/styles/reset.css`
5. Model as a namespace to class / model
6. Set in Startup.cs
    ```csharp
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddOptions();
        services.AddControllersWithViews(); //!!!!!!!!!!!!!
    }
    ``` 
    ```csharp
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      //another extensions
      app.UseStaticFiles(); //allow serve static files from wwwroot
      app.UseEndpoints(endpoints => //allow return rest api and mvc 
      {
          endpoints.MapControllerRoute(
              name: "default",
              pattern: "{controller=Home}/{action=Index}/{id?}");
      });
    }
    ```