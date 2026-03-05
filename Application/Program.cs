using ChaimWarehouse.WarehouseFolder;
using Serilog;
namespace ChaimWarehouse.Application
{
    /// <summary>
    /// The entry point of the WarehouseManager application.
    /// This class is responsible for initializing the logging system,
    /// setting up required services such as event listeners,
    /// and starting the main application workflow.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Initializes the logging configuration, creates the main App instance,
        /// displays the welcome message, and starts the command loop.
        /// </summary>
        /// <param name="args">
        /// args passed to the application.
        /// not used but available for future extensions.
        /// </param>
        public static void Main(string[] args)
        {
            EventMessageService eventMessageService = new EventMessageService(Warehouse.GetWarehouse());
            Log.Logger = new LoggerConfiguration()
                 .MinimumLevel.Debug()
                 .WriteTo.Console()
                 .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day)
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
