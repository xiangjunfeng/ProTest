//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.Run();


using LM.Razor.WebPro1;

//Æô¶¯
Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webHostDefaults => {
    webHostDefaults.UseStartup<Startup>();
}).Build().Run();
