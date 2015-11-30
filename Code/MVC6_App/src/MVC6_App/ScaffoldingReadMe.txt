Scaffolding has generated all the files and added the required dependencies.

However the Application's Startup code may required additional changes for things to work end to end.

Add the following namespace usings if not already added:

using Microsoft.AspNet.Routing;
using Microsoft.Extensions.DependencyInjection;
Add the following code to the end of Configure method in your Application's Startup class if not already done:

            // Set up application services
            app.UseServices(services =>
            {
                // Add MVC services to the services container
                services.AddMvc();

            });

            // Add MVC to the request pipeline
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" });
            
                routes.MapRoute(
                    name: "api",
                    template: "{controller}/{id?}");
            });

            // Add static files to the request pipeline
            app.UseStaticFiles();
