namespace OpenIdDemoV1
{
    public class Program
    {
        public static void Main(string[] args) =>
        CreateHostBuilder(args).Build().Run();

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(options => options.UseStartup<Startup>());
    }
}