namespace PeakExplores
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.UseDefaultFiles(); // Enables index.html as default
            app.UseStaticFiles();  // Allows loading static files from wwwroot

            app.Run();
        }
    }
}
