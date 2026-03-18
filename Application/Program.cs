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
            var eventMessageService = new EventMessageService(Warehouse.Instance);

            var appConfiguration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build()
                .Get<WarehouseSettings>();

            Warehouse.Instance.Settings = appConfiguration;

            var loggerConfiguration = new ConfigurationBuilder()
               .AddJsonFile("appsettings.logger.json", optional: false, reloadOnChange: true)
               .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(loggerConfiguration)
                .CreateLogger();

            try
            {
                Log.Information("Starting application");
                var app = new App();
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
