using ChaimWarehouse.WarehouseFolder;
using Microsoft.Extensions.Configuration;
using Serilog;
namespace ChaimWarehouse.Application
{
    /// <summary>
    /// The entry point of the WarehouseManager application.
    /// and starting the main application workflow.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Start the program 
        /// </summary>
        public static void Main()
        {
            EventMessageService eventMessageService = new EventMessageService(Warehouse.GetWarehouse());

            var configuration = new ConfigurationBuilder()
                   .AddJsonFile("C:\\Users\\chaim\\Desktop\\C#\\WarehouseManager\\appsettings.json", optional: false, reloadOnChange: true)
                   .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();

            try
            {
                Log.Information("Starting application");
                var app = new App();
                app.ShowWelcome();
                app.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
       
    }
}
