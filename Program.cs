namespace SpendSmart;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a builder object which will be used to configure the application and its services.
        var builder = WebApplication.CreateBuilder(args);

        // Add ControllersWithViews to the service collection. This will add ASP.NET Core MVC services and configure
        // options for controllers with views. ControllersWithViews means that the application will use views
        // for its responses.
        builder.Services.AddControllersWithViews();

        // Configure Kestrel to listen on both HTTP and HTTPS
        builder.WebHost.UseUrls("http://localhost:5000", "https://localhost:5001");
        
        // Build the application. This will create an instance of the application based on the configuration that was
        // created by the builder.
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
