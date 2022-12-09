using Microsoft.AspNetCore.Builder;

namespace LM.Razor.WebPro1
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services) 
        {

        }
        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {
            if (!env.IsDevelopment()) 
            {
                app.UseHsts(); //添加安全访问中间件
            }

            app.UseRouting(); //启动终结点路由（做选择）

            app.UseAuthorization();

            app.UseDefaultFiles();

            app.UseEndpoints(endpoints =>{
                endpoints.MapRazorPages();
                //endpoints
                endpoints.MapGet("/", () => "hello world!");
            });
        }
    }
}
